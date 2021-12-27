
namespace UP_Kamerka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchCams = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zdjecie = new System.Windows.Forms.Button();
            this.filmik = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.brightnessSlider = new System.Windows.Forms.TrackBar();
            this.contrastSlider = new System.Windows.Forms.TrackBar();
            this.saturationSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resolutionBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stopRecording = new System.Windows.Forms.Button();
            this.resolutionButt = new System.Windows.Forms.Button();
            this.motionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // searchCams
            // 
            this.searchCams.Location = new System.Drawing.Point(49, 30);
            this.searchCams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCams.Name = "searchCams";
            this.searchCams.Size = new System.Drawing.Size(201, 57);
            this.searchCams.TabIndex = 0;
            this.searchCams.Text = "Wykryj kamerki";
            this.searchCams.UseVisualStyleBackColor = true;
            this.searchCams.Click += new System.EventHandler(this.searchCams_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(303, 46);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(58, 751);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(130, 40);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(211, 751);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(126, 39);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(948, 607);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // zdjecie
            // 
            this.zdjecie.Location = new System.Drawing.Point(362, 751);
            this.zdjecie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zdjecie.Name = "zdjecie";
            this.zdjecie.Size = new System.Drawing.Size(136, 39);
            this.zdjecie.TabIndex = 5;
            this.zdjecie.Text = "Zdjęcie";
            this.zdjecie.UseVisualStyleBackColor = true;
            this.zdjecie.Click += new System.EventHandler(this.zdjecie_Click);
            // 
            // filmik
            // 
            this.filmik.Location = new System.Drawing.Point(520, 751);
            this.filmik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filmik.Name = "filmik";
            this.filmik.Size = new System.Drawing.Size(133, 39);
            this.filmik.TabIndex = 6;
            this.filmik.Text = "Nagraj";
            this.filmik.UseVisualStyleBackColor = true;
            this.filmik.Click += new System.EventHandler(this.filmik_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1106, 751);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(140, 38);
            this.exit.TabIndex = 7;
            this.exit.Text = "Wyjdź";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // brightnessSlider
            // 
            this.brightnessSlider.Location = new System.Drawing.Point(1108, 109);
            this.brightnessSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brightnessSlider.Maximum = 255;
            this.brightnessSlider.Minimum = -255;
            this.brightnessSlider.Name = "brightnessSlider";
            this.brightnessSlider.Size = new System.Drawing.Size(147, 56);
            this.brightnessSlider.TabIndex = 8;
            this.brightnessSlider.Scroll += new System.EventHandler(this.brightnessSlider_Scroll);
            // 
            // contrastSlider
            // 
            this.contrastSlider.Location = new System.Drawing.Point(1108, 182);
            this.contrastSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contrastSlider.Maximum = 255;
            this.contrastSlider.Minimum = -255;
            this.contrastSlider.Name = "contrastSlider";
            this.contrastSlider.Size = new System.Drawing.Size(147, 56);
            this.contrastSlider.TabIndex = 9;
            this.contrastSlider.Scroll += new System.EventHandler(this.contrastSlider_Scroll);
            // 
            // saturationSlider
            // 
            this.saturationSlider.Location = new System.Drawing.Point(1108, 259);
            this.saturationSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saturationSlider.Minimum = -10;
            this.saturationSlider.Name = "saturationSlider";
            this.saturationSlider.Size = new System.Drawing.Size(147, 56);
            this.saturationSlider.TabIndex = 10;
            this.saturationSlider.Scroll += new System.EventHandler(this.saturationSlider_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1148, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Jasność";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1148, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kontrast";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1148, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nasycenie";
            // 
            // resolutionBox
            // 
            this.resolutionBox.FormattingEnabled = true;
            this.resolutionBox.Location = new System.Drawing.Point(1115, 326);
            this.resolutionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resolutionBox.Name = "resolutionBox";
            this.resolutionBox.Size = new System.Drawing.Size(140, 24);
            this.resolutionBox.TabIndex = 14;
            this.resolutionBox.SelectedIndexChanged += new System.EventHandler(this.resolutionBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1132, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rozdzeilczość";
            // 
            // stopRecording
            // 
            this.stopRecording.Location = new System.Drawing.Point(671, 751);
            this.stopRecording.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopRecording.Name = "stopRecording";
            this.stopRecording.Size = new System.Drawing.Size(105, 39);
            this.stopRecording.TabIndex = 16;
            this.stopRecording.Text = "Zatrzymaj nagrywanie";
            this.stopRecording.UseVisualStyleBackColor = true;
            this.stopRecording.Click += new System.EventHandler(this.stopRecording_Click);
            // 
            // resolutionButt
            // 
            this.resolutionButt.Location = new System.Drawing.Point(1115, 354);
            this.resolutionButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resolutionButt.Name = "resolutionButt";
            this.resolutionButt.Size = new System.Drawing.Size(140, 46);
            this.resolutionButt.TabIndex = 17;
            this.resolutionButt.Text = "Zatwierdź rozdzielczość";
            this.resolutionButt.UseVisualStyleBackColor = true;
            this.resolutionButt.Click += new System.EventHandler(this.resolutionButt_Click);
            // 
            // motionLabel
            // 
            this.motionLabel.AutoSize = true;
            this.motionLabel.Location = new System.Drawing.Point(1132, 622);
            this.motionLabel.Name = "motionLabel";
            this.motionLabel.Size = new System.Drawing.Size(114, 17);
            this.motionLabel.TabIndex = 18;
            this.motionLabel.Text = "Motion Detection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 844);
            this.Controls.Add(this.motionLabel);
            this.Controls.Add(this.resolutionButt);
            this.Controls.Add(this.stopRecording);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resolutionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saturationSlider);
            this.Controls.Add(this.contrastSlider);
            this.Controls.Add(this.brightnessSlider);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.filmik);
            this.Controls.Add(this.zdjecie);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchCams);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchCams;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button zdjecie;
        private System.Windows.Forms.Button filmik;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TrackBar brightnessSlider;
        private System.Windows.Forms.TrackBar contrastSlider;
        private System.Windows.Forms.TrackBar saturationSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox resolutionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stopRecording;
        private System.Windows.Forms.Button resolutionButt;
        private System.Windows.Forms.Label motionLabel;
    }
}

