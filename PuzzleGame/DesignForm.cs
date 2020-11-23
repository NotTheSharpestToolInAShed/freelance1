using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class DesignForm : Form
    {
        public DesignForm()
        {
            InitializeComponent();
        }

        private Image cardImage;
        int[,] grid = new int[20, 20];
        private void generateBtn_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (rows_txt.Text == "" || cols_txt.Text == "")
                        throw new Exception("You should fill rows and columns to generate a grid.");
                    int noRows = int.Parse(rows_txt.Text);
                    int noCols = int.Parse(cols_txt.Text);


                    //private PictureBox[][] pArr = new PictureBox[int.Parse(rows_txt.Text)][int.Parse(cols_txt.Text)];
                    int locY = 100;
                    for (int i = 1; i <= noRows; i++)
                    {

                        for (int j = 1; j <= noCols; j++)
                        {
                            int locX = (j * 70) + 205;
                            PictureBox pBox = new PictureBox()
                            {
                                Size = new Size(70, 70),
                                Location = new Point(locX, locY),
                                BorderStyle = BorderStyle.Fixed3D,

                            };
                            pBox.Click += this.PictureClick;
                            this.Controls.Add(pBox);
                        }
                        locY = (locY + (140 / 2));

                    }
                }
                catch(Exception ex)
                {

                    MessageBox.Show("Exception thrown: "+ex.Message);
                }

            }
               
        }

        // compare two images. 
        private bool compare_size(Bitmap bmp1, Bitmap bmp2)
        {
            bool equals = true;
            bool innerloop_err = true;  //Inner loop isn't broken

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
                            innerloop_err = false;
                            break;
                        }
                    }
                    if (!innerloop_err)
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

        private void PictureClick(object sender, EventArgs e)
        {
            PictureBox oPictureBox = (PictureBox)sender;
            int xx = 275;
            int yy = 100;
            // add border, do whatever else you want.
            oPictureBox.Image = cardImage;
            grid[(oPictureBox.Location.Y - yy) / 70, (oPictureBox.Location.X - xx) / 70] = 0;
            //MessageBox.Show(compare((Bitmap)oPictureBox.Image, new Bitmap("Wall.PNG")) +"");
            if (compare_size((Bitmap)oPictureBox.Image, new Bitmap("Wall.PNG")))
            {
                grid[(oPictureBox.Location.Y - yy) / 70, (oPictureBox.Location.X - xx) / 70] = 1;
            }
            
            
            if (compare_size((Bitmap)oPictureBox.Image, new Bitmap("RedDoor.PNG")))
            {
                grid[(oPictureBox.Location.Y - yy) / 70, (oPictureBox.Location.X - xx) / 70] = 2;
            }
            if(compare_size((Bitmap)oPictureBox.Image, new Bitmap("GreenDoor.PNG")))
            {
                grid[(oPictureBox.Location.Y - yy) / 70, (oPictureBox.Location.X - xx) / 70] = 3;
            }
            if(compare_size((Bitmap)oPictureBox.Image, new Bitmap("RedBox.PNG")))
            {
                grid[(oPictureBox.Location.Y - yy) / 70, (oPictureBox.Location.X - xx) / 70] = 4;
            }
            if(compare_size((Bitmap)oPictureBox.Image, new Bitmap("GreenBox.PNG")))
            {
                grid[(oPictureBox.Location.Y - yy) / 70, (oPictureBox.Location.X - xx) / 70] = 5;
            }
            MessageBox.Show(((oPictureBox.Location.X - xx) / 70).ToString()+" "+ ((oPictureBox.Location.Y - yy) / 70).ToString());
        }
        #region objectClick
        private void wallBtn_Click(object sender, EventArgs e)
        {
            cardImage = new Bitmap("Wall.PNG");
        }

        private void redDoorBtn_Click(object sender, EventArgs e)
        {
            cardImage = new Bitmap("RedDoor.PNG");
        }

        private void greenDoorBtn_Click(object sender, EventArgs e)
        {
            cardImage = new Bitmap("GreenDoor.PNG");
        }

        private void redBoxBtn_Click(object sender, EventArgs e)
        {
            cardImage = new Bitmap("RedBox.PNG");
        }

        private void greenBoxBtn_Click(object sender, EventArgs e)
        {
            cardImage = new Bitmap("GreenBox.PNG");
        }

        private void noneBtn_Click(object sender, EventArgs e)
        {
            cardImage = new Bitmap("None.JPG"); ;
        }
        #endregion
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("grid.txt");
            string gridStr = rows_txt.Text + "\n" + cols_txt.Text+"\n";
            int Rows = int.Parse(rows_txt.Text);
            int Cols = int.Parse(cols_txt.Text);
            for (int i=0; i<Rows; i++)
            {
                for(int j=0; j<Cols; j++)
                {
                    gridStr += grid[i, j].ToString() + "\n";
                }
            }
            
            txt.Write(gridStr);
            txt.Close();

            MessageBox.Show("Grid Saved");
        }
    }
}
