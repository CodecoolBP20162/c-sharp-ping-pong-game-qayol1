using System;
using System.Drawing;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public int Bar1Speed;
        public int Bar2Speed;
     
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
            StartGame();
        }

        private void SetPlay()
        {
            bar1.Location = new Point(50, 100);
            bar2.Location = new Point(750, 100);
            bar1.Height = 120;
            bar2.Height = 120;
            Bar1Speed = 8;
            Bar2Speed = 8;
            BallXSpeed = 4;
            BallYSpeed = 4;
            hits = 0;
            HitCounterLabel.Text = hits.ToString();
        }

        private void StartGame()
        {
            SetPlay();
            InitDirection();
            StartBall();
        }

        void StartBall()
        {
            t = new Timer();
            t.Interval = 16;
            t.Tick += new EventHandler(MoveBall);
            t.Start();
        }

        void InitDirection()
        {
            ball.Location = new Point(400, 100);
            
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
                if (ball.Location.X < 790)
                {
                    if (fromUpToDown)
                    {
                        if (ball.Location.Y < 340)
                        {
                            ball.Location = new Point(ball.Location.X + BallXSpeed, ball.Location.Y + BallYSpeed);
                        }
                        else
                        {
                            fromUpToDown = false;
                        }
                    }
                    else
                    {
                        if (ball.Location.Y > 4)
                        {
                            ball.Location = new Point(ball.Location.X + BallXSpeed, ball.Location.Y - BallYSpeed);
                        }
                        else
                        {
                            fromUpToDown = true;
                        }

                    }
                }
                if (ball.Location.X > 730 && (bar2.Location.Y + bar2.Height > ball.Location.Y && ball.Location.Y > (bar2.Location.Y - 15)))
                {
                    fromLeftToRight = false;
                    HandleHit(bar2);
                    Shrink(bar2);
                }

                if (ball.Location.X > 780)
                {
                    HandleScore("Player1");
                }

            }
            else
            {
                if (ball.Location.X > 4)
                {
                    if (fromUpToDown)
                    {
                        if (ball.Location.Y < 340)
                        {
                            ball.Location = new Point(ball.Location.X - BallXSpeed, ball.Location.Y + BallYSpeed);
                        }
                        else
                        {
                            fromUpToDown = false;
                        }
                    }
                    else
                    {
                        if (ball.Location.Y > 4)
                        {
                            ball.Location = new Point(ball.Location.X - BallXSpeed, ball.Location.Y - BallYSpeed);
                        }
                        else
                        {
                            fromUpToDown = true;
                        }
                    }
                }
                if (ball.Location.X < 70 && (bar1.Location.Y + bar1.Height > ball.Location.Y && ball.Location.Y > (bar1.Location.Y - 15)))
                {
                    fromLeftToRight = true;
                    HandleHit(bar1);
                    Shrink(bar1);
                }
                if (ball.Location.X < 10)
                {
                    HandleScore("Player2");
                }
            }
        }

        void HandleHit(Panel bar)
        {
            int fifth = (int)(bar.Height + 15) / 5;
            int ballPositionInBar = bar.Location.Y + bar.Height - ball.Location.Y -15;
            
            if (ballPositionInBar <= fifth || ballPositionInBar > fifth * 4)
            {
                BallYSpeed = 9;
            }
            if ((ballPositionInBar <= fifth * 2 && ballPositionInBar > fifth) || (ballPositionInBar <= fifth * 4 && ballPositionInBar > fifth * 3))
            {
                BallYSpeed = 6;
            }
            if (ballPositionInBar <= fifth * 3 && ballPositionInBar > fifth * 2)
            {
                BallYSpeed = 3;
            } 
        }

        void Shrink(Panel bar)
        {
            hits += 1;
            if (bar.Height >= 20)
            {
                bar.Height -= 10;
            }
            bar.Refresh();
            HitCounterLabel.Text = hits.ToString();
        }

        void HandleScore(String player)
        {
            t.Stop();
            if (player.Equals("Player1"))
            {
                Player1Points += 1;
            }
            else
            {
                Player2Points += 1;
            }
            ShowPoints();
            StartGame();
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
                if (bar1.Location.Y > 4)
                {
                    bar1.Location = new Point(50, bar1.Location.Y - Bar1Speed);
                }
            }

            if (e.KeyValue == 65)
            {
                // A key pressed
                if (bar1.Location.Y < 355 - bar1.Height)
                {
                    bar1.Location = new Point(50, bar1.Location.Y + Bar1Speed);
                }
            }

            if (e.KeyValue == 80)
            {
                // P key pressed
                if (bar2.Location.Y > 4)
                {
                    bar2.Location = new Point(750, bar2.Location.Y - Bar2Speed);
                }
            }

            if (e.KeyValue == 76)
            {
                // L key pressed
                if (bar2.Location.Y < 355 - bar2.Height)
                {
                    bar2.Location = new Point(750, bar2.Location.Y + Bar2Speed);
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
                if (paused)
                {
                    t.Start();
                    paused = false;
                }
                else
                {
                    t.Stop();
                    paused = true;
                }
            }
        }
    }
}
