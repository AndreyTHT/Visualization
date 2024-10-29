﻿namespace Visualization
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.Normalize = new System.Windows.Forms.CheckBox();
            this.Loupe = new System.Windows.Forms.PictureBox();
            this.Interpolate = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.scrollStep = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bright = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NamePicture = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Shift2 = new System.Windows.Forms.RadioButton();
            this.Shift1 = new System.Windows.Forms.RadioButton();
            this.Shift0 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Loading = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pixelColv = new System.Windows.Forms.TrackBar();
            this.panel.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loupe)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scrollStep)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelColv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.groupBox6);
            this.panel.Controls.Add(this.groupBox5);
            this.panel.Controls.Add(this.groupBox4);
            this.panel.Controls.Add(this.groupBox3);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.Loading);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1684, 655);
            this.panel.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pixelColv);
            this.groupBox6.Controls.Add(this.brightnessTrackBar);
            this.groupBox6.Controls.Add(this.zoomTrackBar);
            this.groupBox6.Controls.Add(this.Normalize);
            this.groupBox6.Controls.Add(this.Loupe);
            this.groupBox6.Controls.Add(this.Interpolate);
            this.groupBox6.Location = new System.Drawing.Point(945, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(727, 619);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Инструмент «Лупа»";
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(18, 568);
            this.brightnessTrackBar.Maximum = 100;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(323, 45);
            this.brightnessTrackBar.TabIndex = 21;
            this.brightnessTrackBar.Value = 50;
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.Location = new System.Drawing.Point(18, 471);
            this.zoomTrackBar.Maximum = 5;
            this.zoomTrackBar.Minimum = 1;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(327, 45);
            this.zoomTrackBar.TabIndex = 20;
            this.zoomTrackBar.Value = 2;
            // 
            // Normalize
            // 
            this.Normalize.AutoSize = true;
            this.Normalize.Enabled = false;
            this.Normalize.Location = new System.Drawing.Point(18, 19);
            this.Normalize.Name = "Normalize";
            this.Normalize.Size = new System.Drawing.Size(139, 17);
            this.Normalize.TabIndex = 19;
            this.Normalize.Text = "Нормировать яркость";
            this.Normalize.UseVisualStyleBackColor = true;
            // 
            // Loupe
            // 
            this.Loupe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Loupe.Location = new System.Drawing.Point(18, 80);
            this.Loupe.Name = "Loupe";
            this.Loupe.Size = new System.Drawing.Size(349, 182);
            this.Loupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Loupe.TabIndex = 0;
            this.Loupe.TabStop = false;
            // 
            // Interpolate
            // 
            this.Interpolate.AutoSize = true;
            this.Interpolate.Enabled = false;
            this.Interpolate.Location = new System.Drawing.Point(18, 48);
            this.Interpolate.Name = "Interpolate";
            this.Interpolate.Size = new System.Drawing.Size(116, 17);
            this.Interpolate.TabIndex = 18;
            this.Interpolate.Text = "Интерполировать";
            this.Interpolate.UseVisualStyleBackColor = true;
            this.Interpolate.CheckedChanged += new System.EventHandler(this.Interpolate_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.scrollStep);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(730, 24);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(140, 58);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Шаг прокрутки:";
            // 
            // scrollStep
            // 
            this.scrollStep.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.scrollStep.Location = new System.Drawing.Point(4, 17);
            this.scrollStep.Margin = new System.Windows.Forms.Padding(2);
            this.scrollStep.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.scrollStep.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.scrollStep.Name = "scrollStep";
            this.scrollStep.Size = new System.Drawing.Size(51, 23);
            this.scrollStep.TabIndex = 0;
            this.scrollStep.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.scrollStep.ValueChanged += new System.EventHandler(this.scrollStep_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.bright);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.X);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.Y);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(1, 355);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(187, 140);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Координаты курсора:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 101);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Яркость:";
            // 
            // bright
            // 
            this.bright.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bright.ForeColor = System.Drawing.Color.Black;
            this.bright.Location = new System.Drawing.Point(93, 98);
            this.bright.Margin = new System.Windows.Forms.Padding(2);
            this.bright.Name = "bright";
            this.bright.ReadOnly = true;
            this.bright.Size = new System.Drawing.Size(51, 23);
            this.bright.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Y";
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.X.ForeColor = System.Drawing.Color.Black;
            this.X.Location = new System.Drawing.Point(93, 30);
            this.X.Margin = new System.Windows.Forms.Padding(2);
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Size = new System.Drawing.Size(51, 23);
            this.X.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "=";
            // 
            // Y
            // 
            this.Y.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Y.ForeColor = System.Drawing.Color.Black;
            this.Y.Location = new System.Drawing.Point(93, 64);
            this.Y.Margin = new System.Windows.Forms.Padding(2);
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Size = new System.Drawing.Size(51, 23);
            this.Y.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "=";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NamePicture);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(116, 24);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(235, 58);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Загружены изображения:";
            // 
            // NamePicture
            // 
            this.NamePicture.AutoSize = true;
            this.NamePicture.Location = new System.Drawing.Point(9, 21);
            this.NamePicture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NamePicture.Name = "NamePicture";
            this.NamePicture.Size = new System.Drawing.Size(46, 17);
            this.NamePicture.TabIndex = 0;
            this.NamePicture.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Shift2);
            this.groupBox1.Controls.Add(this.Shift1);
            this.groupBox1.Controls.Add(this.Shift0);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(482, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(128, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сдвигать коды на:";
            // 
            // Shift2
            // 
            this.Shift2.AutoSize = true;
            this.Shift2.Location = new System.Drawing.Point(70, 17);
            this.Shift2.Margin = new System.Windows.Forms.Padding(2);
            this.Shift2.Name = "Shift2";
            this.Shift2.Size = new System.Drawing.Size(34, 21);
            this.Shift2.TabIndex = 2;
            this.Shift2.TabStop = true;
            this.Shift2.Text = "2";
            this.Shift2.UseVisualStyleBackColor = true;
            this.Shift2.CheckedChanged += new System.EventHandler(this.Shift2_CheckedChanged);
            // 
            // Shift1
            // 
            this.Shift1.AutoSize = true;
            this.Shift1.Location = new System.Drawing.Point(39, 17);
            this.Shift1.Margin = new System.Windows.Forms.Padding(2);
            this.Shift1.Name = "Shift1";
            this.Shift1.Size = new System.Drawing.Size(34, 21);
            this.Shift1.TabIndex = 1;
            this.Shift1.Text = "1";
            this.Shift1.UseVisualStyleBackColor = true;
            this.Shift1.CheckedChanged += new System.EventHandler(this.Shift1_CheckedChanged);
            // 
            // Shift0
            // 
            this.Shift0.AutoSize = true;
            this.Shift0.Checked = true;
            this.Shift0.Location = new System.Drawing.Point(8, 17);
            this.Shift0.Margin = new System.Windows.Forms.Padding(2);
            this.Shift0.Name = "Shift0";
            this.Shift0.Size = new System.Drawing.Size(34, 21);
            this.Shift0.TabIndex = 0;
            this.Shift0.TabStop = true;
            this.Shift0.Text = "0";
            this.Shift0.UseVisualStyleBackColor = true;
            this.Shift0.CheckedChanged += new System.EventHandler(this.Shift0_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(1, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 251);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1217, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Loading
            // 
            this.Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Loading.Location = new System.Drawing.Point(6, 28);
            this.Loading.Margin = new System.Windows.Forms.Padding(2);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(105, 54);
            this.Loading.TabIndex = 1;
            this.Loading.Text = "Загрузить";
            this.Loading.UseVisualStyleBackColor = true;
            this.Loading.Click += new System.EventHandler(this.Loading_Click);
            // 
            // pixelColv
            // 
            this.pixelColv.Location = new System.Drawing.Point(18, 517);
            this.pixelColv.Maximum = 100;
            this.pixelColv.Minimum = 4;
            this.pixelColv.Name = "pixelColv";
            this.pixelColv.Size = new System.Drawing.Size(323, 45);
            this.pixelColv.TabIndex = 22;
            this.pixelColv.Value = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 655);
            this.Controls.Add(this.panel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1700, 800);
            this.MinimumSize = new System.Drawing.Size(932, 562);
            this.Name = "Form1";
            this.Text = "Visualization";
            this.panel.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loupe)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scrollStep)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelColv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Loading;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bright;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Shift2;
        private System.Windows.Forms.RadioButton Shift1;
        private System.Windows.Forms.RadioButton Shift0;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label NamePicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown scrollStep;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox Normalize;
        private System.Windows.Forms.PictureBox Loupe;
        private System.Windows.Forms.CheckBox Interpolate;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.TrackBar pixelColv;
    }
}

