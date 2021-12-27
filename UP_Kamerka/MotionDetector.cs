using AForge.Vision.Motion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Threading;
using System.Windows.Forms;

namespace UP_Kamerka
{
    class MotionDetectorController
    {

        public static bool motionDetection(Bitmap bitmap) //wykrywanie ruchu
        {
            MotionDetector motionDetector = new MotionDetector(new SimpleBackgroundModelingDetector(), new MotionAreaHighlighting());
            if (motionDetector.ProcessFrame(bitmap) > 0.02)
            {
                //bool result = true; ;
                //Dispatcher.BeginInvoke(new ThreadStart(delegate { result = true; }));   //problem z statycznoscia
                //motionLabel.Text = "Jest ruch";
                return true;
            }
            else
            {
                return false;
                //Dispatcher.BeginInvoke(new ThreadStart(delegate { motionLabel.Text = "Nie ma ruchu"; }));
                
            }
        }
    }
}
