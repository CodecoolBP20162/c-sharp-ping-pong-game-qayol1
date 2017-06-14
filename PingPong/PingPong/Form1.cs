using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {

        public int Bar1YPosition;
        public int Bar2YPosition;
        public int BallXPosition;
        public int BallYPosition;
        public int Player1Points;
        public int Player2Points;
        Boolean fromLeftToRight;
        Boolean fromUpToDown;
        Boolean paused;
        Timer t;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bar1YPosition = 100;
            Bar2YPosition = 100;
            ShowPoints();
            StartBall();
        }

        private void StartBall()
        {
            t = new Timer();
            t.Interval = 20;
            t.Tick += new EventHandler(MoveBall);
            initDirection();
            t.Start();
        }

        void initDirection()
        {
            BallXPosition = 400;
            BallYPosition = 100;

        Random rnd = new Random();
            int rightLeft = rnd.Next(0, 2);

            if (rightLeft == 0)
            {
                fromLeftToRight = true;
            }
            else
            {
                fromLeftToRight = false;
            }

            int upDown = rnd.Next(0, 2);

            if (upDown == 0)
            {
                fromUpToDown = true;
            }
            else
            {
                fromUpToDown = false;
            }
        }


        void MoveBall(object sender, EventArgs e)
        {
            if (fromLeftToRight)
            {
                if(BallXPosition<790)
                {
                    if (fromUpToDown)
                    {
                        if (BallYPosition < 290)
                        {
                            BallXPosition += 4;
                            BallYPosition += 4;
                            ball.Location = new Point(BallXPosition, BallYPosition);
                        }
                        else
                        {
                            fromUpToDown = false;
                        }

                    }
                    else
                    {
                        if (BallYPosition > 4)
                        {
                            BallXPosition += 4;
                            BallYPosition -= 4;
                            ball.Location = new Point(BallXPosition, BallYPosition);
                        }
                        else
                        {
                            fromUpToDown = true;
                        }

                    }
                }
                if(BallXPosition>730 && (Bar2YPosition + bar2.Height > BallYPosition && BallYPosition > (Bar2YPosition-15)))
                {
                    fromLeftToRight = false;
                    
                }

                if(BallXPosition>780)
                {
                    t.Stop();
                    Player1Points += 1;
                    ShowPoints();
                    StartBall();
                    
                }
                
            }
            else
            {
                if (BallXPosition > 4)
                {
                    if (fromUpToDown)
                    {
                        if (BallYPosition < 290)
                        {
                            BallXPosition -= 4;
                            BallYPosition += 4;
                            ball.Location = new Point(BallXPosition, BallYPosition);
                        }
                        else
                        {
                            fromUpToDown = false;
                        }
                    }
                    else
                    {
                        if (BallYPosition > 4)
                        {
                            BallXPosition -= 4;
                            BallYPosition -= 4;
                            ball.Location = new Point(BallXPosition, BallYPosition);
                        }
                        else
                        {
                            fromUpToDown = true;
                        }
                    }
                }
                if (BallXPosition <70 && (Bar1YPosition + bar1.Height> BallYPosition && BallYPosition > (Bar1YPosition -15)))
                {
                    fromLeftToRight = true;
                    
                }
                if (BallXPosition < 10)
                {
                    t.Stop();
                    Player2Points += 1;
                    ShowPoints();
                    StartBall();
                }
            }                  
        }

        void ShowPoints()
        {
            label1.Text = Player1Points.ToString();
            label2.Text = Player2Points.ToString();
        }

        void StopBall()
        {
            t.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 81)
            {
                // Q key pressed
                if (Bar1YPosition > 4)
                {
                    Bar1YPosition -= 4;
                    bar1.Location = new Point(50, Bar1YPosition);
                }
            }

            if (e.KeyValue == 65)
            {
                // A key pressed
                if (Bar1YPosition < 185)
                {
                    Bar1YPosition += 4;
                    bar1.Location = new Point(50, Bar1YPosition);
                }
            }

            if (e.KeyValue == 80)
            {
                // P key pressed
                if (Bar2YPosition > 4)
                {
                    Bar2YPosition -= 4;
                    bar2.Location = new Point(750, Bar2YPosition);
                }
            }
            
            if (e.KeyValue == 76)
            {
                // L key pressed
                if (Bar2YPosition < 185)
                {
                    Bar2YPosition += 4;
                    bar2.Location = new Point(750, Bar2YPosition);
                }
            }

            if (e.KeyValue == 27)
            {
                // ESC key pressed
                StopBall();
                Application.Exit();
            }

            if (e.KeyValue == 32)
            {
                // SPACE key pressed
                if(paused)
                {
                    t.Start();
                    paused = false;
                } else
                {
                    t.Stop();
                    paused = true;
                }              
            }
        }
    }
}
