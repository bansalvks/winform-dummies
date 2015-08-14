using System;
using System.Drawing;
using System.Windows.Forms;

namespace WebCamDummy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // initialize the web cam with picture box
            web.InitializeWebCam(ref Photo_frame);
        }

        Webcam web = new Webcam();

        private void ClickPic_Click(object sender, EventArgs e)
        {            
            if (ClickPic.Text == "Start")
            {
                web.Start();
                web.Continue();

                ClickPic.Text = "Stop";
            }
            else
            {
                web.Stop();
                ClickPic.Text = "Start";

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (ClickPic.Text == "Start")
            {
                MessageBox.Show("Please stop the cam first then save the picture.");
                return;
            }

            SaveFileDialog saveD = new SaveFileDialog();
            if (saveD.ShowDialog() == DialogResult.OK)
            {
                Photo_frame.Image.Save(saveD.FileName + ".jpg");
            }





        }
    }
}
