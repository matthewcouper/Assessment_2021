using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace RotateObject
{
    class LifeSprite
    {
        public int x, y, width, height;//variables for the rectangle
        public Image lifespriteImage;//variable for the planet's image

        public Rectangle lifespriteRec;//variable for a rectangle to place our image in

        //declare a random variable so the lifesprite graphic is drawn at random on the panel when game starts/when collided
        Random rand = new Random();

        public LifeSprite()
        {

            x = rand.Next(450);
            y = rand.Next(473);
            width = 20;
            height = 20;
            lifespriteImage = Properties.Resources.dot1;
            lifespriteRec = new Rectangle(x, y, width, height);

        }

        public void drawLifeSprite(Graphics g)
        {
            lifespriteRec = new Rectangle(x, y, width, height);

            g.DrawImage(lifespriteImage, lifespriteRec);
        }

    }
}
