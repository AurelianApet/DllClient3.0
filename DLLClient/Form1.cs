﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace DLLClient
{
    public partial class Form1 : Form
    {
        private string imagepath; 

        public Form1()
        {
            InitializeComponent();
        }

        //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
        //delegate string ProcessPostData (string data);


        protected static string GetBase64StringForImage(string imgPath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(imgPath);
            string base64String = Convert.ToBase64String(imageBytes);            
            return base64String;
        }


        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        //[DllImport("LOGODETECTOR.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        //private static extern IntPtr fnLogoDetector(StringBuilder imgBase64, StringBuilder googleAPIKey,
        //   [MarshalAs(UnmanagedType.FunctionPtr)] ProcessPostData pPostData, bool getFullJSON = true);




        //_declspec(dllexport) unsigned char* removeBackground(unsigned char* data, int width, int height)

        [DllImport("BGREMOVE.dll", CharSet = CharSet.Ansi, CallingConvention =CallingConvention.Cdecl)]
        private static extern IntPtr fnbgRemove(StringBuilder imgBase64, int iterations, int sample);

        //private static extern void DetectLogo(StringBuilder imgBase64, StringBuilder key, StringBuilder retval, int length);

       

        private void btnRemoveBG_Click(object sender, EventArgs e)
        {
            string img64buff = GetBase64StringForImage(imagepath);

            //prepare strings for passing to the dll function
            StringBuilder key = new StringBuilder("AIzaSyCcUZpErk_6r6IeLCM2dtG4pJbDHgd-yHE");
            StringBuilder img64 = new StringBuilder(img64buff);


            ////create a delegate callback function which dll will call upon receiving data
            //ProcessPostData calllback =
            //(value) =>
            //{
            //        //the output returned by dll is arrived here
            //        //txtOutput.Text = value; 

            //        return "";
            //};

            int percentagerect = (int)numbInsetRect.Value;
            int iterations = (int)numIncrement.Value;
           // int downsample = (int)numbDownsample.Value;
            //extract the return message from the dll normal is "success" others are error message

            int left = ((picSource.Image.Width * percentagerect) / 100) / 2;
            int width = picSource.Image.Width - left;

            int top = ((picSource.Image.Height * percentagerect) / 100) / 2; 
            int height = picSource.Image.Height - top;


            int sampled = 0;
            if (chksample.Checked)
                sampled = 1;



            lbltimer.Text = "waiting..."; 

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            IntPtr retimg = fnbgRemove(img64, iterations,sampled);
            
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            lbltimer.Text = "Time Elapsed: "+ elapsedTime;



            //StringBuilder retimg = fnbgRemove(img64);

            if (retimg.Equals(null))
            {
                MessageBox.Show("UNKWON ERROR TRY ANOTHER IMAGE");
                return;
            }


            StringBuilder img64ret = new StringBuilder(System.Runtime.InteropServices.Marshal.PtrToStringAnsi(retimg));

            //retimg = fnbgRemove(img64ret);

            //byte retbase64img = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(retimg);

            byte[] imageBytes = Convert.FromBase64String(img64ret.ToString());

            picDestination.Image = ByteToImage(imageBytes);
            //string retmsg = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(retcode);

            ////display the error message
            //// MessageBox.Show(version);

        }

        private void chkfittodisplay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfittodisplay.Checked)
            {

                //pnlSource.AutoScroll = false;
                picSource.SizeMode = PictureBoxSizeMode.Zoom;

               // pnlDestination.AutoScroll = false;
                picDestination.SizeMode = PictureBoxSizeMode.Zoom; 
                
            }
            else
            {
                //pnlSource.AutoScroll = true;
                picSource.SizeMode = PictureBoxSizeMode.Normal;

                //pnlDestination.AutoScroll = true;
                picDestination.SizeMode = PictureBoxSizeMode.Normal;
            }

            pnlSource.Refresh();
            picSource.Refresh();
            picDestination.Refresh();
            this.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog adlg = new OpenFileDialog();

            adlg.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";

            adlg.Multiselect = false;
            adlg.Title = "Select Image to remove background";



            if (adlg.ShowDialog() == DialogResult.OK)
            {
                //string imagePath = "1.png";
                imagepath = adlg.FileName;
                picSource.ImageLocation = imagepath;

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
