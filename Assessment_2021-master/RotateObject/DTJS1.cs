using System;
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
    public partial class DTJS1 : Form
    {



        Graphics g; //declare a graphics object called g so we can draw on the Form
        Spaceship spaceship = new Spaceship(); //create an instance of the Spaceship Class called spaceship
        LifeSprite lifesprite = new LifeSprite(); //create an instance of the LifeSprite Class called spaceship

        bool turnLeft, turnRight, moveUp, moveLeft, moveRight, moveDown;

        string move;

        int score, lives;

        Random yspeed = new Random();
        Random xspeed = new Random();

        //declare a random variable so the lifesprite graphic is drawn at random on the panel when game starts/when collided
        Random rand = new Random();


        //declare a list  missiles from the Missile class
        List<Missile> missiles = new List<Missile>();
        List<Planet> planets = new List<Planet>();
        List<PlanetDown> planets2 = new List<PlanetDown>();
        List<PlanetRight> planets3 = new List<PlanetRight>();
        List<PlanetUp> planets4 = new List<PlanetUp>();

       



        public DTJS1()
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

                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = xspeed.Next(1, 4);
                p.x -= rndmspeed;



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

                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = xspeed.Next(1, 4);
                p.x += rndmspeed;

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

                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(1, 4);
                p.y += rndmspeed;

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

                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(1, 4);
                p.y -= rndmspeed;

                p.draw(g);//Draw the planet
                p.movePlanet(g);//move the planet

                //if the planet reaches the bottom of the form relocate it back to the top
                if (p.y <= -15)
                {
                    p.y = 500;
                }

            }
            //Draw the lifesprite
            lifesprite.drawLifeSprite(g);

            //Draw the spaceship
            spaceship.drawSpaceship(g);

            foreach (Missile m in missiles)
            {
                m.drawMissile(g);
                m.moveMissile(g);

            }
        }

        private void CheckLives()
        {
            if (lives == 0)
            {
                tmrPlanet.Enabled = false;
                tmrSpaceship.Enabled = false;
                tmrTime.Enabled = false;
                MessageBox.Show("think less next time.", " game over :(");
            }
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

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            int timeLeft = int.Parse(lblTime.Text);  //getting the last value (the one from the label)
            timeLeft -= 1; //subtracting 1
            lblTime.Text = timeLeft.ToString();  //adding it back to the label. 

            if (int.Parse(lblTime.Text) == 0)  //if the countdown reaches '0', we stop it
            {
                tmrTime.Stop();
                tmrPlanet.Enabled = false;
                tmrSpaceship.Enabled = false;
                MessageBox.Show("think less next time.", " game over :(");
            }

            if (spaceship.spaceRec.IntersectsWith(lifesprite.lifespriteRec))
            {


                lifesprite.x = rand.Next(450);
                lifesprite.y = rand.Next(350);

                
                timeLeft += 5; //adding 5
                lblTime.Text = timeLeft.ToString();  //adding it back to the label. 
            }


        }

        private void tmrPlanet_Tick(object sender, EventArgs e)
        {

         foreach (Planet p in planets)

            if (spaceship.spaceRec.IntersectsWith(p.planetRec))
            {
                //reset back to top of panels
                p.x = -30; // set y value of planetRec
                lives -= 1;// lose a life
                txtLives.Text = lives.ToString();// display number of lives
                CheckLives();
            }

            foreach (PlanetDown p in planets2)

                if (spaceship.spaceRec.IntersectsWith(p.planetRec))
                {
                    //reset back to top of panels
                    p.y = -20; // set y value of planetRec
                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }

            foreach (PlanetRight p in planets3)

                if (spaceship.spaceRec.IntersectsWith(p.planetRec))
                {
                    //reset back to top of panels
                    p.x = 600; // set y value of planetRec
                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }

            foreach (PlanetUp p in planets4)

                if (spaceship.spaceRec.IntersectsWith(p.planetRec))
                {
                    //reset back to top of panels
                    p.y = 500; // set y value of planetRec
                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    CheckLives();
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
            
            tmrSpaceship.Enabled = true;
            label1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            tmrTime.Enabled = true;

        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            tmrSpaceship.Enabled = false;
            tmrTime.Enabled = false;
            tmrPlanet.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("dont think. just shoot. \n \n (wasd to move, arrows to rotate, e to shoot, obtain life sprites, to keep alive)", "the rules are simple:");
           

            lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable

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
