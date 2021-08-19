﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace RotateObject
{
    class Spaceship
    {

        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image spaceship;//variable for the planet&#39;s image
        public Rectangle spaceRec;//variable for a rectangle to place our image in
                                  //Create a constructor (initialises the values of the fields)

        public int rotationAngle;
        public Matrix matrix; 
        Point centre;




        public Spaceship()
        {
            x = 210;
            y = 220;
            width = 25;
            height = 25;
            rotationAngle = 0;
            spaceship = Properties.Resources.alien1;
            spaceRec = new Rectangle(x, y, width, height);
        }
        //methods
        public void drawSpaceship(Graphics g)
        {
            //find the centre point of spaceRec
            centre = new Point(spaceRec.X + width / 2, spaceRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the spaceship

            g.DrawImage(spaceship, spaceRec);
        }

        public void MoveSpaceship(string move)
        {
            if (move == "right")
            {

                x -= 3;
                spaceRec.Location = new Point(x, y);
            }

            if (move == "left")
            {

                x += 3;
                spaceRec.Location = new Point(x, y);
            }

            if (move == "up")
            {

                y -= 3;
                spaceRec.Location = new Point(x, y);
            }

            if (move == "down")
            {

                y += 3;
                spaceRec.Location = new Point(x, y);
            }

        }


    }
}
