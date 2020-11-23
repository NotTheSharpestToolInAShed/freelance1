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
    public partial class playForm : Form
    {
        public playForm()
        {
            InitializeComponent();
        }
        int count = 0;
        private PictureBox selectedPBox = new PictureBox();
        private void loadGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filelines = File.ReadAllLines(theDialog.FileName);
                MessageBox.Show(filelines.Length.ToString());

                int rows = int.Parse(filelines[0]);
                int cols = int.Parse(filelines[1]);

                MessageBox.Show(rows.ToString() + ", " + cols.ToString());
                int locY = 50;
                int[,] grid = new int[rows, cols];

                int i = 0, j=0 ;
                for(int k = 2; k < filelines.Length; k++)
                {
                    grid[i, j] = int.Parse(filelines[k]);
                    j++;
                    if (j > (cols - 1))
                    {
                        j = 0;
                        i++;
                    }
                }

                for (i = 1; i <= rows; i++)
                {

                    for (j = 1; j <= cols; j++)
                    {
                        int locX = (j * 70);

                        PictureBox pBox = new PictureBox()
                        {
                            Size = new Size(70, 70),
                            Location = new Point(locX, locY),
                            BorderStyle = BorderStyle.Fixed3D,

                        };
                        pBox.Click += this.PictureClick;
                        if(grid[i-1, j-1] == 1)
                        {
                            pBox.Image = new Bitmap("Wall.PNG");
                        }else if(grid[i-1, j-1] == 2)
                        {
                            pBox.Image = new Bitmap("RedDoor.PNG");
                        }else if(grid[i-1, j-1] == 3)
                        {
                            //GreenDoor.PNG
                            pBox.Image = new Bitmap("GreenDoor.PNG");
                        }
                        else if(grid[i-1, j-1] == 4)
                        {
                            //RedBox.PNG
                            pBox.Image = new Bitmap("RedBox.PNG");
                        }
                        else if(grid[i-1, j-1] == 5)
                        {
                            //GreenBox.PNG
                            pBox.Image = new Bitmap("GreenBox.PNG");
                        }
                        this.Controls.Add(pBox);
                    }
                    locY = (locY + (140 / 2));

                }

                upBtn.Enabled = true;
                leftBtn.Enabled = true;
                downBtn.Enabled = true;
                rightBtn.Enabled = true;
            }
        }

        private void PictureClick(object sender, EventArgs e)
        {
            PictureBox oPictureBox = (PictureBox)sender;
            selectedBox.Image = oPictureBox.Image;
            selectedPBox = oPictureBox;
            MessageBox.Show(oPictureBox.Location + "");
            
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            int currX = selectedPBox.Location.X;
            int currY = selectedPBox.Location.Y;
            currY -= 70;
            MessageBox.Show(currX + "," + currY);
            selectedBox.Location = new Point(currX, currY);
            count++;

            textBox1.Text = count.ToString();

        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            int currX = selectedPBox.Location.X;
            int currY = selectedPBox.Location.Y;
            currX -= 70;
            MessageBox.Show(currX + "," + currY);
            selectedBox.Location = new Point(currX, currY);
            count++;
            textBox1.Text = count.ToString();

        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            int currX = selectedPBox.Location.X;
            int currY = selectedPBox.Location.Y;
            currY += 70;
            MessageBox.Show(currX + "," + currY);
            selectedBox.Location = new Point(currX, currY);
            count++;
            textBox1.Text = count.ToString();

        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            int currX = selectedPBox.Location.X;
            int currY = selectedPBox.Location.Y;
            currX += 70;
            MessageBox.Show(currX + "," + currY);
            selectedBox.Location = new Point(currX, currY);
            count++;
            textBox1.Text = count.ToString();

        }
    }
}
