﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;
using System.Runtime.Remoting.Messaging;

namespace Visualization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NamePicture.Text = "";
        }

        ushort[,] data;
        int h, w; // создаем переменные высоту h и ширину w изображения
        byte s = 0; // переменная, которая будет хранить информацию о выбранном сдвиге

        Bitmap bitmap;
        Bitmap zoomLoup;

        int z; //область увеличения в пикселях
        int m; //увеличение
        byte brightnessFactor;
        ushort[,] loupaPixel;

        ushort[,,,] loupa;

        private void Loading_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Настройка диалогового окна
            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "Все файлы (*.*)|*.*"; // Вы можете изменить фильтр по своему усмотрению
            openFileDialog.InitialDirectory = @"C:\"; // Устанавливаем начальную директорию

            // Показываем диалоговое окно и проверяем, был ли выбран файл
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь к выбранному файлу
                string filePath = openFileDialog.FileName;
                NamePicture.Text = Path.GetFileName(filePath);

                data = readFile(filePath); //функция для побайтового чтения файла

                bitmap = new Bitmap(w, h);
                shift_box();

            }

        }

        private byte shiftPix(ushort x)
        {
            x = (ushort)(x & 0x3FF);
            x = (ushort)(x >> s);
            x = (ushort)(x & 0xFF);
            return (byte)x;
        }

        private ushort[,] readFile(string filePath)  //реализация функции для побайтового чтения файла
        {

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                // Чтение первых двух байтов и запись в переменную h
                h = reader.ReadUInt16();  // Предполагается, что байты представляют короткое целое число

                // Чтение следующих двух байтов и запись в переменную w
                w = reader.ReadUInt16();  // Аналогично, читаем 2 байта

                data = new ushort[w, h];
                
                // Чтение данных в массив ushort
                for (int i = 0; i < w; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        data[i, j] = reader.ReadUInt16();
                    }
                }
                return data;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // Получаем координаты курсора относительно PictureBox
            int x = e.X;
            int y = e.Y;
            // Обновляем TextBox с координатами
            X.Text = $"{x}";
            Y.Text = $"{y}";
            if (pictureBox1.Image != null)
            {
                if (Interpolate.Checked)
                {
                    
                }
                else
                {
                    bright.Text = $"{shiftPix(data[x, y])}";
                    brightnessFactor = (byte)brightnessTrackBar.Value;
                    m = zoomTrackBar.Value;
                    z = pixelColv.Value;
                    loupaPixel = new ushort[z, z];
                    zoomLoup = new Bitmap(z * m, z * m);

                    for (int i = 0; i < z; i++)
                    {
                        for (int j = 0; j < z; j++)
                        {
                            loupaPixel[i, j] = data[x + i, y + j];
                        }
                    }

                    createZL();
                }
            }
        }



        private void createZL()
        {
            ushort k;
            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < z; j++)
                {
                    k = loupaPixel[i, j];
                    for (int x = 0; x < m; x++)
                    {
                        for (int y = 0; y < m; y++)
                        {
                            // Вычисляем положение в новом массиве 15x15
                            int newX = i * m + x;
                            int newY = j * m + y;

                            // Генерация цвета пикселя
                            byte rgb = shiftPix(k);

                            // Установка цвета пикселя в bitmap
                            Color pixelColor = Color.FromArgb(rgb, rgb, rgb);
                            zoomLoup.SetPixel(newX, newY, pixelColor);
                        }
                    }
                }
            }

            Loupe.Image = zoomLoup;
        }

        private void shift_box()
        {

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    // Генерация цвета пикселя
                    byte rgb = shiftPix(data[x, y]);
                    // Установка цвета пикселя в bitmap
                    Color pixelColor = Color.FromArgb(rgb, rgb, rgb);
                    bitmap.SetPixel(x, y, pixelColor);
                }
            }
            // Устанавливаем bitmap как изображение для PictureBox
            pictureBox1.Image = bitmap;
        }

        private void Shift0_CheckedChanged(object sender, EventArgs e)
        {
            s = 0;
            shift_box();
        }

        private void Shift1_CheckedChanged(object sender, EventArgs e)
        {
            s = 1;
            shift_box();
        }

        private void Shift2_CheckedChanged(object sender, EventArgs e)
        {
            s = 2;
            shift_box();
        }

        private void Interpolate_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void scrollStep_ValueChanged(object sender, EventArgs e)
        {

            // Получаем текущее значение для установки шага прокрутки
            int scrollS = (int)scrollStep.Value;

            // Устанавливаем шаг прокрутки вручную
            panel2.VerticalScroll.SmallChange = scrollS;
            panel2.HorizontalScroll.SmallChange = scrollS;
        }
    }
}