using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace UIAssignment.Models
{
    public class Sprite
    {
        public Point Location;

        public string picure;
        public PictureBox Pb;

        public static int SpriteCount;

        public Sprite()
        {
            this.picure = "Airplane.bmp";
            this.Location = new Point(10, 200);
            LoadPicture();
            SpriteCount++;
        }

        public void LoadPicture()
        {
            this.Pb = new PictureBox();
            this.Pb.Location = this.Location;
            this.Pb.Image = Bitmap.FromFile(this.picure);
        }

        public void Move(Point p)
        {
            this.Location = p;
            this.Pb.Location = this.Location; 
        }
    }
}
