using System;
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

namespace Visualization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NamePicture.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        ushort[,] data;
        int h, w; // создаем переменные высоту h и ширину w изображения
        int s; // переменная, которая будет хранить информацию о выбранном сдвиге
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

                Bitmap bitmap = new Bitmap(w, h);
                
                // Заполнение каждого пикселя значениями RGB
                for (int x = 0; x < w; x++)
                {
                    for (int y = 0; y < h; y++)
                    {
                        // Генерация цвета пикселя
                        // Например, создадим градиентный переход по RGB
                        int rgb = shiftPix(data[x, y], 0);
                        // Установка цвета пикселя в bitmap
                        Color pixelColor = Color.FromArgb(rgb, rgb, rgb);
                        bitmap.SetPixel(x, y, pixelColor);
                    }
                }

                // Устанавливаем bitmap как изображение для PictureBox
                pictureBox1.Image = bitmap;

            }

        }

        private int shiftPix(int x, int s)
        {
            x = x & 0x3FF;
            x = x >> s;
            x = x & 0xFF;
            return x;
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

        private void NamePicture_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void X_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // Получаем координаты курсора относительно PictureBox
            int x = e.X;
            int y = e.Y;

            // Обновляем TextBox с координатами
            X.Text = $"{x}";
            XM.Text = $"{x}";
            Y.Text = $"{y}";
            if (pictureBox1.Image != null)
            {
                bright.Text = $"{shiftPix(data[x, y], s)}";
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void shift_box(object sender, EventArgs e)
        {
            s = 0;

            Bitmap bitmap = new Bitmap(w, h);
            if (Shift0.Checked)
            {
                s = 0;
            }
            else if (Shift1.Checked)
            {
                s = 1;
            }
            else
            {
                s = 2;
            }
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    // Генерация цвета пикселя
                    // Например, создадим градиентный переход по RGB
                    int rgb = shiftPix(data[x, y], s);
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
            shift_box(sender, e);
        }

        private void Shift1_CheckedChanged(object sender, EventArgs e)
        {
            shift_box(sender, e);
        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
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

        private void Shift2_CheckedChanged(object sender, EventArgs e)
        {
            shift_box(sender, e);
        }
    }
}