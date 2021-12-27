using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace UP_Kamerka
{
    public partial class Form1 : Form
    {
        //System.Drawing.Size currentResolution;
        //List<System.Drawing.Size> videoResolutions = new List<System.Drawing.Size>();
        CameraController cc;
        

        public Form1()
        {
            InitializeComponent();
            cc = new CameraController(this);
            this.Closing += WindowClosing;
        }

        public Image getPictureBoxImage()
        {
            return pictureBox1.Image;
        }

        public void setPictureBoxImage(Bitmap bitmap)
        {
            pictureBox1.Image = bitmap;
        }

        public void setMotionLabelText(string text)
        {
            motionLabel.Text = text;
        }

        private void WindowClosing(object sender, CancelEventArgs e)
        {
            cc.StopCamera();   //wylaczanie kamerki przy wyjsciu z programu
        }

        private void searchCams_Click(object sender, EventArgs e)
        {
            cc.SearchCams(comboBox1); //wyszukanie dostępnych kamer i dodanie ich do comboBox
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            cc.StopCamera();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                cc.SetCamera(comboBox1.SelectedIndex);
                resolutionBox.Items.Clear();
                cc.FillResolutionBox(resolutionBox);
                StartCamera();  //uruchomienie kamery
            }

        }

        private void StartCamera()
        {
            cc.StartCamera();
            //pictureBox1.Image = (System.Drawing.Bitmap.FromFile(@"C:\Users\Paweł\Documents\studia\3 rok\UP\kamera\z lab\wysłany program\ja plaża piach 2.jpg"));
        }

        private void zdjecie_Click(object sender, EventArgs e)
        {
            stopButton_Click(sender, e);    //zatrzymanie obrazu 
            cc.SavePicture();
            StartCamera(); //wznowienie transmisji

        }



        private void filmik_Click(object sender, EventArgs e)
        {
            cc.StartRecording();
        }

        private void exit_Click(object sender, EventArgs e) //przycisk do zamykania programu
        {
            Environment.Exit(0);
        }

        private void brightnessSlider_Scroll(object sender, EventArgs e)    //ustawianie jasnosci
        {
            cc.setBrightness(brightnessSlider.Value);
        }

        private void contrastSlider_Scroll(object sender, EventArgs e)  //ustawianie kontrastu
        {
            cc.setContrast(contrastSlider.Value);
        }

        private void saturationSlider_Scroll(object sender, EventArgs e)    //ustawianie nasycenia
        {
            cc.setSaturation(saturationSlider.Value);
        }

        private void resolutionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tu bylo ustawianie rozdzielczosci ale dodalismy do tego osobny przycisk aby byc pewnym ze dziala
        }

        private void SetResolution()
        {
            //currentResolution = (System.Drawing.Size)resolutionBox.SelectedItem;  //wybranie odpowiedniej rozdzielczosci jako obecna
            /*for (int i = 0; i < camera.VideoCapabilities.Length; i++) //sprawdzenie ktora rozdzielczosc z dostepnych jest rowna wybranej
            {
                if (currentResolution.Equals(camera.VideoCapabilities[i].FrameSize))
                {
                    camera.VideoResolution = camera.VideoCapabilities[i];   //przypisanie odpowiedniej rozdzielczosci do obecnej rozdzielczosci kamery
                }
            }*/
            cc.SetResolution(resolutionBox.SelectedIndex);   //dziala tak samo jak kod powyzej

        }

        private void stopRecording_Click(object sender, EventArgs e)
        {
            cc.StopRecording();
        }

        private void resolutionButt_Click(object sender, EventArgs e)
        {
            cc.StopCamera();
            Thread.Sleep(500);  //poczekanie az kamerka sie wylaczy bo inaczej nie zadziala
            SetResolution();    //ustawienie wybranej rozdzielczosci z listy wyboru
            StartCamera();
        }
    }
}
