using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace image_processing
{
    public partial class Form1 : Form
    {
        Bitmap image1 = null;
        Bitmap image2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                image1 = new Bitmap(openDialog.FileName);
                pictureBox1.Image = image1;
                // Display its Height and Width
                label1.Text = "Width: " + image1.Width + "   Height: " + image1.Height + "    Pixels: " + image1.PixelFormat;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                image2 = new Bitmap(openDialog.FileName);
                pictureBox2.Image = image2;
                label2.Text = "Width: " + image2.Width + "   Height: " + image2.Height + "     Pixels:  " + image2.PixelFormat;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (compare(image1, image2))
            {
                MessageBox.Show("Same Image.");
                
            }

            else
            {
                MessageBox.Show("Different Image.");
            }
        }
        private bool compare(Bitmap bmp1, Bitmap bmp2)
        {
            bool equals = true;
            bool flag = true;  //Inner loop isn't broken

            //Test to see if we have the same size of image
            if (bmp1.Size == bmp2.Size)
            {
                for (int x = 0; x < bmp1.Width; ++x)
                {
                    for (int y = 0; y < bmp1.Height; ++y)
                    {
                        if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        {
                            equals = false;
                            flag = false;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        break;
                    }
                }
            }
            else
            {
                equals = false;
            }
            return equals;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                
            

        }
    }
}
