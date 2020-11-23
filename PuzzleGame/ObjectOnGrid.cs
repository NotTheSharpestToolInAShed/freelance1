using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    class GridObject: PictureBox
    {


        protected int rating;       
        /// <summary>
        /// I use rating to differ wall from a box or green box from red. To be honest, there you better use Enumeration. But I wont;
        /// </summary>
        public int GetRating{ get => rating; }
       
        public GridObject() {   }
        public GridObject(PictureBox a) { }

    }
    class Door : GridObject
    {
        public virtual bool isGreen { get => false; }
        public virtual bool isRed { get => false; }
        public Door( ) { rating = 2;}

    }
    class RedDoor : Door
    {
      
        public override bool isRed { get => true; }
        public override bool isGreen { get => false; }
        public RedDoor()  { Image = new Bitmap("RedDoor.PNG"); }
    }
    class GreenDoor : Door
    {
        public override bool isRed { get => false; }
        public override bool isGreen { get => true; }
        public GreenDoor() { Image = new Bitmap("GreenDoor.PNG"); }
    }
    class Box : GridObject
    {
        public virtual bool isGreen { get => false; }
        public virtual bool isRed { get => false; }
        public Box(){ }
    }
    class RedBox : Box 
    { 

        public override bool isRed { get=> true; }
        public override bool isGreen { get => false; }
        public RedBox() { rating = 3; Image = new Bitmap("RedBox.PNG"); } 
    }
    class GreenBox : Box 
    {
        public override bool isRed { get => false; }
        public override bool isGreen { get=> true; }
        public GreenBox() { rating = 4; Image = new Bitmap("GreenBox.PNG"); } 
    }
    class NoneEmpty : GridObject
    {
        public NoneEmpty() { rating = 0; this.Image = new Bitmap("None.JPG"); }
    }
    class Wall : GridObject
    {
        public Wall() { rating = 1; Image = new Bitmap("Wall.PNG"); }
    }
}
