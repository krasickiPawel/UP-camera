using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AForge.Vision.Motion;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using Accord.Video.FFMPEG;
using System.Drawing;
using System.Windows.Forms;

namespace UP_Kamerka
{
    class CameraController
    {
        FilterInfoCollection camList;
        VideoCaptureDevice camera;
        VideoFileWriter writer;
        Bitmap bitmap;
        Form1 window;
        MotionDetector motionDetector;
        bool isRecording = false;
        int brightness = 0;
        int contrast = 0;
        int saturation = 0;


        public CameraController(Form1 window)
        {
            this.window = window;
            motionDetector = new MotionDetector(new SimpleBackgroundModelingDetector(), new MotionAreaHighlighting());
        }

        public void setSaturation(int value)
        {
            saturation = value;
        }

        public void setContrast(int value)
        {
            contrast = value;
        }

        public void setBrightness(int value)
        {
            brightness = value;
        }


        public void StopCamera()
        {
            if (camera != null && camera.IsRunning)
            {
                camera.SignalToStop();
                camera.NewFrame -= new NewFrameEventHandler(CameraFrame);   //usuniecie obrazu do wyswietlenia
            }
        }

        public void SearchCams(ComboBox comboBox1)
        {
            camList = new FilterInfoCollection(FilterCategory.VideoInputDevice);    //wyszukanie dostepnych kamer usb
            foreach (FilterInfo cam in camList)
            {
                comboBox1.Items.Add(cam.Name);  //wpisanie dostepnych kamer do comboBoxa (listy wyboru)
            }
            comboBox1.SelectedItem = comboBox1.Items[0];    //ustawienie domyslnie pierwszej kamery z listy jako wybrana
        }

        public void SetCamera(int index)
        {
            camera = new VideoCaptureDevice(camList[index].MonikerString);    //przypisanie nowej kamery
        }

        public void FillResolutionBox(ComboBox resolutionBox)
        {
            for (int i = 0; i < camera.VideoCapabilities.Length; i++)   //wypisanie mozliwych rozdzielczosci kamery do listy wyboru
            {
                resolutionBox.Items.Add(camera.VideoCapabilities[i].FrameSize);
            }
            resolutionBox.SelectedItem = resolutionBox.Items[0];
        }

        public void StartCamera()
        {
            camera.NewFrame += new NewFrameEventHandler(CameraFrame);   //faktyczne "dodanie" obrazu do wyswietlenia
            camera.Start(); //uruchomienie kamery
        }

        private void CameraFrame(object sender, NewFrameEventArgs eventArgs)    //obsluga obrazu
        {
            bitmap = (Bitmap)eventArgs.Frame.Clone();
            bitmap = new BrightnessCorrection(brightness).Apply(bitmap);
            bitmap =  new ContrastCorrection(contrast).Apply(bitmap);
            bitmap = new SaturationCorrection(saturation).Apply(bitmap);
            //pictureBoxBitmap.LockBits(new Rectangle(new Point(pictureBoxBitmap.Size), pictureBoxBitmap.Size), System.Drawing.Imaging.ImageLockMode.ReadWrite, pictureBoxBitmap.PixelFormat);    //1 - readOnly, 3 - read/write
            /*
            bitmap = (Bitmap)eventArgs.Frame.Clone();  //stworzenie bitmapy bedacej obrazem z kamery

            BrightnessCorrection brightnessCorrector = new BrightnessCorrection(brightness);
            bitmap = brightnessCorrector.Apply(bitmap); //wprowadzenie zmian z suwaka jasnosci

            ContrastCorrection contrastCorrector = new ContrastCorrection(contrast);
            bitmap = contrastCorrector.Apply(bitmap);   //wprowadzenie zmian z suwaka kontrastu

            SaturationCorrection saturationCorrector = new SaturationCorrection(saturation / 10);
            bitmap = saturationCorrector.Apply(bitmap); //wprowadzenie zmian z suwaka nasycenia
            */
            if (isRecording)    //sprawdzenie czy nagrywanie jest wlaczone i jesli tak to zapis kolejnych klatek do pliku
            {
                writer.WriteVideoFrame(bitmap); //nagrywanie obrazu do pliku
            }

            window.setPictureBoxImage(bitmap);        //wypisanie obrazu na odpowiednim panelu w naszym programie

            /*
            if (motionDetector.ProcessFrame(bitmap) > 0.02) window.setMotionLabelText("Jest ruch");
            else window.setMotionLabelText("Nie ma ruchu");
            */
        }



        public void SavePicture()
        {
            if (camera.IsRunning)   //sprawdzenie czy kamera jest w uzyciu
            {
                Image photo = window.getPictureBoxImage();    //stworzenie obrazu bedacego zrzutem z panelu wyswietlajacego obraz
                var saveFileDialog = new SaveFileDialog();  //okno zapisu
                saveFileDialog.FileName = DateTime.Now.ToString().Replace(' ', '_').Replace('.', ' ').Replace(':', ' ').Replace(' ', '-');
                saveFileDialog.DefaultExt = ".jpg";
                saveFileDialog.Filter = "JPeg Image|*.jpg";
                saveFileDialog.Title = "Save Image";
                var userAnswer = saveFileDialog.ShowDialog();
                if (userAnswer == DialogResult.OK && saveFileDialog.FileName != "") //nie zapisujemy jesli uzytkownik sie rozmysli
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                    photo.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);    //zapis zdjecia do pliku
                }
            }
        }


        public void StartRecording()
        {
            if (camera.IsRunning)   //sprawdzenie czy kamera jest w uzyciu
            {
                var saveFileDialog = new SaveFileDialog();  //okno zapisu
                saveFileDialog.FileName = DateTime.Now.ToString().Replace(' ', '_').Replace('.', ' ').Replace(':', ' ').Replace(' ', '-');
                saveFileDialog.DefaultExt = ".avi";
                saveFileDialog.AddExtension = true;
                saveFileDialog.Title = "Save Video";
                var userAnswer = saveFileDialog.ShowDialog();

                if (userAnswer == DialogResult.OK && saveFileDialog.FileName != "") //nie nagrywamy jesli uzytkownik sie rozmysli
                {
                    writer = new VideoFileWriter(); //obiekt obslugujacy zapisywanie obrazu do pliku
                    writer.Open(saveFileDialog.FileName, bitmap.Width, bitmap.Height, 30, VideoCodec.MPEG4);    //parametry
                    isRecording = true; //ustawienie flagi ze trwa teraz nagrywanie
                }

            }
        }

        public void SetResolution(int index)
        {
            camera.VideoResolution = camera.VideoCapabilities.ElementAt(index);
        }

        public void StopRecording()
        {
            if (isRecording)    //sprawdzenie czy trwa nagrywanie
            {
                writer.Close(); //zamkniecie pliku do ktorego bylo nagrywane
                writer.Dispose();
                isRecording = false;    //ustawienie flagi ze nie trwa nagrywanie
            }
        }
    }
}
