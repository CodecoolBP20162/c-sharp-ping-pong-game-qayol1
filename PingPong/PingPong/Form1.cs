using System;
using System.Drawing;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {

        public int Bar1YPosition;
        public int Bar2YPosition;
        public int Bar1Speed;
        public int Bar2Speed;
        public int Bar1Height;
        public int Bar2Height;

        public int BallXPosition;
        public int BallYPosition;
        public int BallXSpeed;
        public int BallYSpeed;

        public int Player1Points;
        public int Player2Points;

        public int hits;

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
            SetPlay();
            ShowPoints();
            StartBall();
        }

        private void SetPlay()
        {
            Bar1YPosition = 100;
            Bar2YPosition = 100;
            Bar1Height = 120;
            Bar2Height = 120;
            Bar1Speed = 4;
            Bar2Speed = 4;
            BallXSpeed = 4;
            BallYSpeed = 4;
    }

        private void StartBall()
        {
            bar1.Height = Bar1Height;
            bar2.Height = Bar2Height;
            hits = 0;
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
                        if (BallYPosition < 340)
                        {
                            BallXPosition += BallXSpeed;
                            BallYPosition += BallYSpeed;
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
                            BallXPosition += BallXSpeed;
                            BallYPosition -= BallYSpeed;
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
                    HandleHit(bar2);
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
                        if (BallYPosition < 340)
                        {
                            BallXPosition -= BallXSpeed;
                            BallYPosition += BallYSpeed;
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
                            BallXPosition -= BallXSpeed;
                            BallYPosition -= BallYSpeed;
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
                    HandleHit(bar1);

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

        void HandleHit(Panel bar)
        {
            hits += 1;
            if (bar.Height >= 20)
            {
                bar.Height -= 10;
            }
            HitCounterLabel.Text = hits.ToString();
        }
        

        void ShowPoints()
        {
            Player1PointCounterLabel.Text = Player1Points.ToString();
            Player2PointCounterLabel.Text = Player2Points.ToString();
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
                    Bar1YPosition -= Bar1Speed;
                    bar1.Location = new Point(50, Bar1YPosition);
                }
            }

            if (e.KeyValue == 65)
            {
                // A key pressed
                if (Bar1YPosition < 355 - bar1.Height)
                {
                    Bar1YPosition += Bar1Speed;
                    bar1.Location = new Point(50, Bar1YPosition);
                }
            }

            if (e.KeyValue == 80)
            {
                // P key pressed
                if (Bar2YPosition > 4)
                {
                    Bar2YPosition -= Bar2Speed;
                    bar2.Location = new Point(750, Bar2YPosition);
                }
            }
            
            if (e.KeyValue == 76)
            {
                // L key pressed
                if (Bar2YPosition < 355 - bar2.Height)
                {
                    Bar2YPosition += Bar2Speed;
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
