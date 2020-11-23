using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void designBtn_Click(object sender, EventArgs e)
        {
            DesignForm designForm = new DesignForm();
            designForm.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            playForm playForm = new playForm();
            playForm.Show();
        }
    }
}
