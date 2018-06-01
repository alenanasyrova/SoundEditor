namespace SoundEditor
{
    partial class FormSoundEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.buttonTrim = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.duration = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.artist = new System.Windows.Forms.Label();
            this.album = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.buttonCombine = new System.Windows.Forms.Button();
            this.echo = new System.Windows.Forms.Button();
            this.overdrive = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customWaveViewer1 = new SoundEditor.CustomWaveViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.openFileButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFileButton.ForeColor = System.Drawing.Color.White;
            this.openFileButton.Location = new System.Drawing.Point(295, 371);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(150, 40);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Открыть";
            this.openFileButton.UseVisualStyleBackColor = false;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.Transparent;
            this.pauseButton.BackgroundImage = global::SoundEditor.Properties.Resources.play_pause;
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(199, 371);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(65, 40);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "    ";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // buttonTrim
            // 
            this.buttonTrim.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonTrim.Enabled = false;
            this.buttonTrim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTrim.ForeColor = System.Drawing.Color.White;
            this.buttonTrim.Location = new System.Drawing.Point(340, 111);
            this.buttonTrim.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonTrim.Name = "buttonTrim";
            this.buttonTrim.Size = new System.Drawing.Size(150, 40);
            this.buttonTrim.TabIndex = 2;
            this.buttonTrim.Text = "Обрезать";
            this.buttonTrim.UseVisualStyleBackColor = false;
            this.buttonTrim.Click += new System.EventHandler(this.buttonTrim_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(349, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Location = new System.Drawing.Point(426, 82);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.duration.AutoSize = true;
            this.duration.Location = new System.Drawing.Point(8, 190);
            this.duration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.duration.Name = "label3";
            this.duration.Size = new System.Drawing.Size(0, 13);
            this.duration.TabIndex = 7;
            this.duration.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(8, 209);
            this.length.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.length.Name = "label4";
            this.length.Size = new System.Drawing.Size(0, 13);
            this.length.TabIndex = 8;
            this.length.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox3.Location = new System.Drawing.Point(383, 82);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(25, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(343, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "  min       sec";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(374, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = ":";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(419, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "  min        sec";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(450, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = ":";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox4.Location = new System.Drawing.Point(460, 82);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(25, 20);
            this.textBox4.TabIndex = 15;
            // 
            // artist
            // 
            this.artist.AutoSize = true;
            this.artist.BackColor = System.Drawing.Color.Transparent;
            this.artist.Location = new System.Drawing.Point(11, 95);
            this.artist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.artist.Name = "artist";
            this.artist.Size = new System.Drawing.Size(13, 13);
            this.artist.TabIndex = 17;
            this.artist.Text = "  ";
            // 
            // album
            // 
            this.album.AutoSize = true;
            this.album.BackColor = System.Drawing.Color.Transparent;
            this.album.Location = new System.Drawing.Point(11, 116);
            this.album.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.album.Name = "album";
            this.album.Size = new System.Drawing.Size(22, 13);
            this.album.TabIndex = 18;
            this.album.Text = "     ";
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Location = new System.Drawing.Point(11, 64);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(44, 23);
            this.title.TabIndex = 29;
            this.title.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.BackColor = System.Drawing.Color.Transparent;
            this.year.Location = new System.Drawing.Point(11, 137);
            this.year.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(22, 13);
            this.year.TabIndex = 20;
            this.year.Text = "     ";
            this.year.Click += new System.EventHandler(this.label12_Click);
            // 
            // buttonCombine
            // 
            this.buttonCombine.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCombine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCombine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCombine.ForeColor = System.Drawing.Color.White;
            this.buttonCombine.Location = new System.Drawing.Point(194, 111);
            this.buttonCombine.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCombine.Name = "buttonCombine";
            this.buttonCombine.Size = new System.Drawing.Size(150, 40);
            this.buttonCombine.TabIndex = 22;
            this.buttonCombine.Text = "Склеить";
            this.buttonCombine.UseVisualStyleBackColor = false;
            this.buttonCombine.Click += new System.EventHandler(this.buttonCombine_Click);
            // 
            // echo
            // 
            this.echo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.echo.Enabled = false;
            this.echo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.echo.ForeColor = System.Drawing.Color.White;
            this.echo.Location = new System.Drawing.Point(487, 111);
            this.echo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.echo.Name = "echo";
            this.echo.Size = new System.Drawing.Size(110, 40);
            this.echo.TabIndex = 27;
            this.echo.Text = "Эхо";
            this.echo.UseVisualStyleBackColor = false;
            this.echo.Click += new System.EventHandler(this.echo_Click);
            // 
            // overdrive
            // 
            this.overdrive.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.overdrive.Enabled = false;
            this.overdrive.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.overdrive.ForeColor = System.Drawing.Color.White;
            this.overdrive.Location = new System.Drawing.Point(594, 111);
            this.overdrive.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.overdrive.Name = "overdrive";
            this.overdrive.Size = new System.Drawing.Size(110, 40);
            this.overdrive.TabIndex = 28;
            this.overdrive.Text = "OverDrive";
            this.overdrive.UseVisualStyleBackColor = false;
            this.overdrive.Click += new System.EventHandler(this.overdrive_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SoundEditor.Properties.Resources.logo1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 45);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // customWaveViewer1
            // 
            this.customWaveViewer1.BackColor = System.Drawing.Color.Gainsboro;
            this.customWaveViewer1.Location = new System.Drawing.Point(189, 168);
            this.customWaveViewer1.Name = "customWaveViewer1";
            this.customWaveViewer1.PenColor = System.Drawing.Color.DodgerBlue;
            this.customWaveViewer1.PenWidth = 1F;
            this.customWaveViewer1.SamplesPerPixel = 128;
            this.customWaveViewer1.Size = new System.Drawing.Size(658, 179);
            this.customWaveViewer1.StartPosition = ((long)(0));
            this.customWaveViewer1.TabIndex = 26;
            this.customWaveViewer1.WaveStream = null;
            this.customWaveViewer1.Load += new System.EventHandler(this.customWaveViewer1_Load);
            // 
            // FormSoundEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SoundEditor.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(890, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.overdrive);
            this.Controls.Add(this.echo);
            this.Controls.Add(this.customWaveViewer1);
            this.Controls.Add(this.buttonCombine);
            this.Controls.Add(this.year);
            this.Controls.Add(this.title);
            this.Controls.Add(this.album);
            this.Controls.Add(this.artist);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.length);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonTrim);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.openFileButton);
            this.MaximizeBox = false;
            this.Name = "FormSoundEditor";
            this.Text = "ZvukRed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button buttonTrim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label artist;
        private System.Windows.Forms.Label album;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Button buttonCombine;
        private CustomWaveViewer customWaveViewer1;
        private System.Windows.Forms.Button echo;
        private System.Windows.Forms.Button overdrive;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


