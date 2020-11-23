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

            BasicGridElementDelta = 70;
            selectedPBox = new GridObject();
        }
        int count = 0;
        private GridObject selectedPBox; //do not set fields in there, set them in the constructor

        GridObject[,] grid;
        int GridRows;
        int GridColumns;
        int BasicGridElementDelta;
        private void loadGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string[] rawGridFile = File.ReadAllLines(theDialog.FileName);
                MessageBox.Show(rawGridFile.Length.ToString());

                GridRows = int.Parse(rawGridFile[0]) + 1;
                GridColumns = int.Parse(rawGridFile[1]) + 1;

                string[] GridContains = new string[rawGridFile.Length - 1];
                for (int i = 2, k = 0; i < rawGridFile.Length; i++, k++)
                    GridContains[k] = rawGridFile[i];                             //remove borders from the file



                List<int[]> CoordinatesAndRates = new List<int[]>();
                int amount_of_params = 3; //x,y,rating
                int GridContains_Length = GridContains.Length - 1;


                for (int i = 0; i < GridContains.Length - 3; i += 3)
                {
                    CoordinatesAndRates.Add(new int[] { Convert.ToInt32(GridContains[i]), Convert.ToInt32(GridContains[i + 1]), Convert.ToInt32(GridContains[i + 2]) });

                    //write coordinates and ratings of each member of grid in one list;

                }


                grid = new GridObject[GridRows - 1, GridColumns - 1];
                const int NumberX = 0, NumberY = 1, Rating = 2;
                int X; int Y;
                int locY = 50, locX = 0;
                int Counter_for_Coordinates = 0;
                for (int i = 0; i < GridRows - 1; i++)          //creating a grid
                {

                    for (int j = 0; j < GridColumns - 1; j++)
                    {
                        X = CoordinatesAndRates[j][NumberX];    //constants for readable use
                        Y = CoordinatesAndRates[j][NumberY];
                        locX = (j * BasicGridElementDelta);
                        switch (CoordinatesAndRates[Counter_for_Coordinates][Rating]) //choosing what type of thing is in a field of box and creating it(now we have a grid full of objects)
                        {
                            case 0:
                                grid[i, j] = new NoneEmpty();
                                break;
                            case 1:
                                grid[i, j] = new Wall();
                                break;
                            case 2:
                                grid[i, j] = new GreenDoor();
                                break;
                            case 3:
                                grid[i, j] = new RedDoor();
                                break;
                            case 4:
                                grid[i, j] = new GreenBox();
                                break;
                            case 5:
                                grid[i, j] = new RedBox();
                                break;

                        }
                        grid[i, j].Location = new Point(locX, locY);
                        grid[i, j].Size = new Size(BasicGridElementDelta, BasicGridElementDelta);
                        grid[i, j].Click += this.PictureClick;
                        grid[i, j].BorderStyle = BorderStyle.Fixed3D;  //because our class hierarchy is a heir of PictureBox all of this works.
                        this.Controls.Add(grid[i, j]);
                        Counter_for_Coordinates++;


                    }
                    locY = (locY + BasicGridElementDelta);

                }






                upBtn.Enabled = true;
                leftBtn.Enabled = true;
                downBtn.Enabled = true;
                rightBtn.Enabled = true;
            }
        }

        private void PictureClick(object sender, EventArgs e)
        {
            bool safecounter = false;
            PictureBox oPictureBox = (PictureBox)sender;
            for (int i = 0; i < GridRows - 1; i++)
            {
                if (safecounter == true) break;
                for (int j = 0; j < GridColumns - 1; j++)
                {
                    if (grid[i, j].Location == oPictureBox.Location)
                    {
                        if(grid[i,j]is RedBox||grid[i,j]is GreenBox)
                        {
                            selectedPBox = grid[i, j];
                            safecounter = true;
                            break;
                        }
                       
                    }
                }
            }

            MessageBox.Show(oPictureBox.Location + "");

        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            try
            {


                int currX = selectedPBox.Location.X;
                int currY = selectedPBox.Location.Y - BasicGridElementDelta;
                bool safecounter = false;//actually there are several more accurate ways to get out of cycle, but this one is the laziest
                for (int i = 0; i < GridRows - 1; i++)
                {
                    if (safecounter) break;
                    for (int j = 0; j < GridColumns - 1; j++)
                    {
                        if (grid[i, j].Location == selectedPBox.Location)
                        {
                            if (((Box)grid[i, j]).isGreen)
                            {

                                if (grid[i, j - 1] is NoneEmpty)
                                {
                                    GridObject a = grid[i, j];
                                    Point Location_Now = grid[i, j].Location;

                                    grid[i, j] = grid[i, j - 1];
                                    grid[i, j].Location = grid[i, j - 1].Location;

                                    grid[i, j - 1] = a;                 //there we swap higher element and element we chose(box) and thee locations
                                    grid[i, j - 1].Location = Location_Now;

                                    selectedPBox = grid[i, j - 1];
                                    selectedPBox.Location = Location_Now;
                                    MessageBox.Show(selectedPBox.Location.X.ToString()+" "+ selectedPBox.Location.Y.ToString());

                                    grid[i, j].Image = new Bitmap("None.JPG");
                                    grid[i, j - 1].Image = new Bitmap("GreenBox.PNG");
                                }
                                else if(grid[i, j - 1] is GreenDoor )
                                    grid[i, j] = (NoneEmpty)grid[i, j];

                            }
                            else if (((Box)grid[i, j]).isRed)
                            {
                                if (grid[i, j - 1] is NoneEmpty)
                                {
                                    GridObject a = grid[i, j];
                                    grid[i, j] = grid[i, j - 1];
                                    grid[i, j - 1] = a;                 //there we swap higher element and element we chose(box)
                                    selectedPBox = grid[i, j - 1];
                                    grid[i, j].Image = new Bitmap("None.JPG");
                                    grid[i, j - 1].Image = new Bitmap("GreenBox.PNG");
                                }
                                else if (grid[i, j - 1] is RedDoor)
                                {
                                    grid[i, j] = (NoneEmpty)grid[i, j];
                                }

                            }

                            safecounter = true;
                            break;
                        }
                    }
                }
                count++;

                textBox1.Text = count.ToString();
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Impossible to move out of grid" + ex.Message);
            }




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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
