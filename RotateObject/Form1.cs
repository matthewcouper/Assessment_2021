﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;



namespace RotateObject
{
    public partial class Form1 : Form
    {



        Graphics g; //declare a graphics object called g so we can draw on the Form
        Spaceship spaceship = new Spaceship(); //create an instance of the Spaceship Class called spaceship

        bool turnLeft, turnRight, moveUp, moveLeft, moveRight, moveDown;

        string move;

        int score, lives;

        //declare a list  missiles from the Missile class
        List<Missile> missiles = new List<Missile>();
        List<Planet> planets = new List<Planet>();
        List<PlanetDown> planets2 = new List<PlanetDown>();
        List<PlanetRight> planets3 = new List<PlanetRight>();
        List<PlanetUp> planets4 = new List<PlanetUp>();



        public Form1()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
           
            for (int i = 0; i < 7; i++)
            {
                int displacement = 10 + (i * 70);
                planets.Add(new Planet(displacement));
                planets2.Add(new PlanetDown(displacement));
                planets3.Add(new PlanetRight(displacement));
                planets4.Add(new PlanetUp(displacement));

            }
        }




        private void tmrSpaceship_Tick(object sender, EventArgs e)
        {

 

                if (turnRight)
            {
                spaceship.rotationAngle += 5;
            }
            if (turnLeft)
                spaceship.rotationAngle -= 5;

            if (moveRight) // if right arrow key pressed
            {
                move = "right";
                spaceship.MoveSpaceship(move);
            }
            if (moveLeft) // if left arrow key pressed
            {
                move = "left";
                spaceship.MoveSpaceship(move);
            }

            if (moveUp) // if right arrow key pressed
            {
                move = "up";
                spaceship.MoveSpaceship(move);
            }
            if (moveDown) // if left arrow key pressed
            {
                move = "down";
                spaceship.MoveSpaceship(move);
            }

            PnlGame.Invalidate();

        }

      




      
        private void PnlGame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                missiles.Add(new Missile(spaceship.spaceRec, spaceship.rotationAngle));
            }
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the Form control
            g = e.Graphics;

            foreach (PlanetRight p in planets3)
            {
                p.draw(g);//Draw the planet
                p.movePlanet(g);//move the planet

                //if the planet reaches the bottom of the form relocate it back to the top
                if (p.x <= -30)
                {
                    p.x = 600;
                }

            }


            foreach (Planet p in planets)
            {
                p.draw(g);//Draw the planet
                p.movePlanet(g);//move the planet

                //if the planet reaches the bottom of the form relocate it back to the top
                if (p.x >= ClientSize.Width)
                {
                    p.x = -30;
                }

            }

            
            foreach (PlanetDown p in planets2)
            {
                p.draw(g);//Draw the planet
                p.movePlanet(g);//move the planet

                //if the planet reaches the bottom of the form relocate it back to the top
                if (p.y >= ClientSize.Height)
                {
                    p.y = -20;
                }

            }


            foreach (PlanetUp p in planets4)
            {
                p.draw(g);//Draw the planet
                p.movePlanet(g);//move the planet

                //if the planet reaches the bottom of the form relocate it back to the top
                if (p.y <= -15)
                {
                    p.y = 500;
                }

            }


            //Draw the spaceship
            spaceship.drawSpaceship(g);

            foreach (Missile m in missiles)
            {
                m.drawMissile(g);
                m.moveMissile(g);

            }
        }

        private void tmrPlanet_Tick(object sender, EventArgs e)
        {
            if (p.planetRec.IntersectsWith(spaceRec)) ;
        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {

            foreach (Planet p in planets)
            {

                foreach (Missile m in missiles)
                {
                    if (p.planetRec.IntersectsWith(m.missileRec))
                    {

                        score += 1;//update the score
                        lblScore.Text = score.ToString();// display score

                        p.x = -30;
                        missiles.Remove(m);
                        break;



                    }
                }

            }

            foreach (PlanetDown p in planets2)
            {

                foreach (Missile m in missiles)
                {
                    if (p.planetRec.IntersectsWith(m.missileRec))
                    {

                        score += 1;//update the score
                        lblScore.Text = score.ToString();// display score

                        p.y = -20;
                        missiles.Remove(m);
                        break;

                      
                    }
                }

            }

            foreach(PlanetRight p in planets3)
            {

                foreach (Missile m in missiles)
                {
                    if (p.planetRec.IntersectsWith(m.missileRec))
                    {

                        score += 1;//update the score
                        lblScore.Text = score.ToString();// display score

                        p.x = 600;
                        missiles.Remove(m);
                        break;

                        
                    }
                }

            }

            foreach (PlanetUp p in planets4)
            {

                foreach (Missile m in missiles)
                {
                    if (p.planetRec.IntersectsWith(m.missileRec))
                    {

                        score += 1;//update the score
                        lblScore.Text = score.ToString();// display score

                        p.y = 500;
                        missiles.Remove(m);
                        break;

                        
                    }
                }

            }



        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }
            if (e.KeyData == Keys.W) { moveUp = false; }
            if (e.KeyData == Keys.A) { moveRight = false; }
            if (e.KeyData == Keys.S) { moveDown = false; }
            if (e.KeyData == Keys.D) { moveLeft = false; }
        }

        private void MnuStart_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            tmrSpaceship.Enabled = true;
        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            tmrSpaceship.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("dont think. just shoot.", "the rules are simple:");
            txtName.Focus();


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = true; }
            if (e.KeyData == Keys.Right) { turnRight = true; }
            if (e.KeyData == Keys.W) { moveUp = true; }
            if (e.KeyData == Keys.A) { moveRight = true; }
            if (e.KeyData == Keys.S) { moveDown = true; }
            if (e.KeyData == Keys.D) { moveLeft = true; }
            if (e.KeyData == Keys.E) { missiles.Add(new Missile(spaceship.spaceRec, spaceship.rotationAngle)); }
        }

    }
}
