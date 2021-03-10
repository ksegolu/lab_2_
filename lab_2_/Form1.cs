using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace lab_2_
{
    public partial class Form1 : Form
    {
        string path = "smth_2.jpg";

        public Form1()
        {
            InitializeComponent();
            string path2 = "result.jpg";
            Bitmap img = new Bitmap(path);
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Image<Bgr, Byte> image = new Image<Bgr, Byte>("smth_2.jpg");
            for (int i = 0; i < image.Rows - 1; i++)
            {
                for (int j = 0; j < image.Cols - 1; j++)
                {
                    image.Data[i, j, 0] = 0;
                    image.Data[i, j, 2] = 0;
                }
            }
            CvInvoke.Imwrite("result.jpg", image);

            Bitmap img_2 = new Bitmap(path2);
            pictureBox2.Image = img_2;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
