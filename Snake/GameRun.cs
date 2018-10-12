using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Snake;
using System.Threading;

namespace Snake
{

    public partial class GameRun : Form
    {
        //int maxXPos;//;33;// (int)((width - 1) / Settings.Width);
        //int maxYPos;// 33;// (int)(height / Settings.Height);

        private Game Game { get; set; }
        public int poz;
        public bool snakevisible = true;
        public Bitmap wallcolour = (Bitmap)Bitmap.FromFile("wall_red.png");
        Menu MenuForm;

        public GameRun(Menu incomingForm)
        {
            InitializeComponent();
            MenuForm = incomingForm;

            //FormBorderStyle.Sizable;

            Level_lbl.BringToFront();

            new Settings();

            //double x = (pbCanvas.Size.Width / Settings.Width);
            //double y = (pbCanvas.Size.Height / Settings.Height);
            //maxXPos = (int)x;
            //maxYPos = (int)y;
            
            gameTimer.Interval = 1000 / Settings.Speed; //set game speed
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            StartGame();
        }
        
        //private Menu mainForm ;
        //public GameRun(Form callingForm)
        //{
        //    mainForm = callingForm as Menu; 
        //    InitializeComponent();
        //}

        private void StartGame()
        {
            gameOver_lbl.Visible = false;
            Level_lbl.Text = "0";
            new Settings();
            gameTimer.Interval = 1000 / Settings.Speed;

            Game = new Game();

            NewSnake();

            Life_lbl.Text = Game.Life.ToString();
            foodremaining_lbl.Text = Game.FoodRemaining.ToString();

            Pause_lbl.Visible = true;
            //Speed_txt.Text = Settings.Speed.ToString();

            

            Score_lbl.Text = Settings.Score.ToString();
            Game.GenerateFood(pbCanvas.Size.Width, pbCanvas.Size.Height);
        }

        public void NewSnake()
        {
            Game.Snake.Clear();
            Game.Snake.Add(new Circle(6,5));
            Game.Snake.Add(new Circle(7,5));
            Game.Snake.Add(new Circle(8,5));

            Game.Snakehead = (Bitmap)Bitmap.FromFile("snakeheadleft.png");
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            foodremaining_lbl.Text = Game.FoodRemaining.ToString();

            if (Settings.LoseLife == true)
            {
                Life_lbl.Text = Game.Life.ToString();
                gameOver_lbl.Visible = true;

                Lose_life();
                Pause();

                if (Inputs.KeyPressed(Keys.Enter))
                {
                    Settings.LoseLife = false;
                    gameOver_lbl.Visible = false;
                }
                else return;
            }
            else
            if(Settings.LevelUp == true)
            {
                if (Inputs.KeyPressed(Keys.Enter))
                {
                    Settings.LevelUp = false;
                    Level_lbl_pb.Visible = false;
                }
                else return;
            }
            else
            if (Settings.Win == true)
            {
                //f2.ShowDialog();
                gameOver_lbl.Visible = true;
                if (Settings.GameOver == false)
                {
                    if (MenuForm.RelaxMode == false)
                        gameOver_lbl.Text = "Felicitari!Ai terminat jocul\nSPACE pentru Meniu\nENTER ca sa joci din nou";
                    else
                        gameOver_lbl.Text = "Ai pierdut!\nScorul tau final:" + Settings.Score + "\nSPACE pentru Meniu\nENTER ca sa joci din nou";
                }
                else
                {
                    string gameOver = "Ai pierdut!\nScorul tau final :" + Settings.Score + "\nENTER ca sa incerci din nou!\nSPACE pentru meniu";
                    gameOver_lbl.Text = gameOver;
                    //Settings.GameOver = false;
                }

                if (Inputs.KeyPressed(Keys.Enter))
                {
                    StartGame();
                    Game.Level.Wall.Clear();
                }
                    if (Inputs.KeyPressed(Keys.Space))
                    {
                        Menu f2 = new Menu();
                        Settings.Win = false;
                        gameTimer.Stop();
                        this.Hide();
                        f2.ShowDialog();// = true;
                        this.Close();
                        return;
                        //this.Hide();
                        //MenuForm.Show();
                        //this.Close();
                    }
                return;
            }
            else
            if (Settings.GameOver == true)
            {
                if (Inputs.KeyPressed(Keys.Enter))
                {
                    StartGame();
                    Game.Level.Wall.Clear();
                }
                else return;
            }
            else
            {
                if(Inputs.KeyPressed(Keys.P) && Pause_lbl.Visible == true)
                {
                    Settings.direction = Settings.LastDirection;
                    Pause_lbl.Visible = false;
                }
                else
                if (Inputs.KeyPressed(Keys.P))
                {
                    Pause();
                    return;
                }
                //if (Pause_lbl.Visible == true) return;
                if (Inputs.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                {
                    Game.Snakehead = (Bitmap)Bitmap.FromFile("snakeheadright.png");
                    //Game.Snaketail = (Bitmap)Bitmap.FromFile("snaketailright.png");
                    //switch (Settings.LastDirection)
                    //{
                    //    case Direction.Up:
                    //        Game.Snakehead.RotateFlip(RotateFlipType.Rotate90FlipX);
                    //        break;
                    //    case Direction.Down:
                    //        Game.Snakehead.RotateFlip(RotateFlipType.Rotate90FlipY);
                    //        break;
                    //    case Direction.None:
                    //        Game.Snakehead.RotateFlip(RotateFlipType.Rotate180FlipX);
                    //        break;
                    //}
                    //Game.Snakehead = Game.head;
                    Settings.direction = Direction.Right;
                    Settings.LastDirection = Settings.direction;
                    Pause_lbl.Visible = false;
                }
                else if (Inputs.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                {
                    Game.Snakehead = (Bitmap)Bitmap.FromFile("snakeheadleft.png");
                   // Game.Snaketail = (Bitmap)Bitmap.FromFile("snaketailleft.png");
                    //switch (Settings.LastDirection)
                    //{
                    //    case Direction.Up:
                    //        Game.Snakehead.RotateFlip(RotateFlipType.Rotate90FlipY);
                    //        break;
                    //    case Direction.Down:
                    //        Game.Snakehead.RotateFlip(RotateFlipType.Rotate90FlipY);
                    //        break;
                    //    case Direction.None:
                    //        //Game.Snakehead.RotateFlip(RotateFlipType.Rotate180FlipX);
                    //        break;
                    //}
                    //Game.Snakehead = Game.head;
                    
                    Settings.direction = Direction.Left;
                    Settings.LastDirection = Settings.direction;
                    Pause_lbl.Visible = false;
                }
                else if (Inputs.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                {
                    Game.Snakehead = (Bitmap)Bitmap.FromFile("snakeheadup.png");
                    //Game.Snaketail = (Bitmap)Bitmap.FromFile("snaketailup.png");
                    //switch (Settings.LastDirection)
                    //{
                    //    case Direction.Left:
                    //        Game.Snakehead.RotateFlip(RotateFlipType.Rotate90FlipY);
                    //        break;
                    //    case Direction.Right:
                    //        Game.Snakehead.RotateFlip(RotateFlipType.Rotate90FlipX);
                    //        break;
                    //    case Direction.None:
                    //        Game.Snakehead.RotateFlip(RotateFlipType.Rotate90FlipX);
                    //        break;
                    //}

                    //Game.Snakehead = Game.head;
                    Settings.direction = Direction.Up;
                    Pause_lbl.Visible = false;
                }
                else if (Inputs.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                {
                    Game.Snakehead = (Bitmap)Bitmap.FromFile("snakeheaddown.png");
                    //Game.Snaketail = (Bitmap)Bitmap.FromFile("snaketaildown.png");
                    //Game.Snakehead = Game.head;
                    Settings.direction = Direction.Down;
                    Pause_lbl.Visible = false;
                }

                MovePlayer();
            }

            pbCanvas.Invalidate();
        }

        void Lose_life()
        {
            gameOver_lbl.Text = "Ai pierdut 1 viata \nApasa ENTER ca sa continui";
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (Settings.GameOver == false)
            {
                //Colour the snake
                Bitmap snakecolour,RandomFood;
                Bitmap[] food = new Bitmap[3];

                food[0] = (Bitmap)Bitmap.FromFile("bananas.png");
                food[1] = (Bitmap)Bitmap.FromFile("strawberry.png");
                food[2] = (Bitmap)Bitmap.FromFile("orange.png");

                //int poz = rnd.Next(0,2);
                RandomFood = food[poz];

                for (int i = 0; i < Game.Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        snakecolour = Game.Snakehead;
                    }
                    else
                    {
                        snakecolour = Game.Snakebody;
                    }
                    if (snakevisible == true)
                    {
                        canvas.DrawImage(snakecolour,
                                         Game.Snake[i].X * Settings.Width,
                                         Game.Snake[i].Y * Settings.Height,
                                         Settings.Width, Settings.Height);
                    }

                    //Draw snake
                    //canvas.FillEllipse(snakecolour,
                    //    new Rectangle(Game.Snake[i].X * Settings.Width,
                    //                  Game.Snake[i].Y * Settings.Height,
                    //                  Settings.Width, Settings.Height));

                    //Draw food
                    canvas.DrawImage(RandomFood,
                                Game.Food.X * Settings.Width,
                                Game.Food.Y * Settings.Height,
                                Settings.Width + 3, Settings.Height + 3);

                    //canvas.FillEllipse(Brushes.Red,
                    //    new Rectangle(Game.Food.X * Settings.Width,
                    //                  Game.Food.Y * Settings.Height,
                    //                  Settings.Width, Settings.Height));
                }

                for (int i = 0; i < Game.Level.Wall.Count ;i++)
                {
                    //canvas.FillEllipse(Brushes.BlueViolet,
                    //    new Rectangle(Game.Level.Wall[i].X * Settings.Width,
                    //                  Game.Level.Wall[i].Y * Settings.Height,
                    //                  Settings.Width, Settings.Height));

                    canvas.DrawImage(wallcolour,
                                Game.Level.Wall[i].X * Settings.Width,
                                Game.Level.Wall[i].Y * Settings.Height,
                                Settings.Width + 2, Settings.Height + 2);
                }

                for (int i = 0; i < Game.Level.Portal.Count; i++)
                {
                    canvas.DrawImage(Bitmap.FromFile("blackhole.png"),
                                Game.Level.Portal[i].X * Settings.Width,
                                Game.Level.Portal[i].Y * Settings.Height,
                                Settings.Width + 4, Settings.Height + 4);
                }
            }
            else
            {
                gameOver_lbl.Visible = true;
                Settings.Win = true;
            }
        }
        
        private void MovePlayer()
        {
            for (int i = Game.Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Up:
                            
                            Game.Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Game.Snake[i].Y++;
                            break;
                        case Direction.Left:
                            Game.Snake[i].X--;
                            break;
                        case Direction.Right:
                            Game.Snake[i].X++;
                            break;
  
                    }

                    if (Settings.direction == Direction.None)
                        break;

                    //Detect collission with game borders
                    double x = (pbCanvas.Size.Width / Settings.Width);
                    double y = (pbCanvas.Size.Height / Settings.Height);
                    int maxXPos = (int)x;//;33;// (int)((width - 1) / Settings.Width);
                    int maxYPos = (int)y;// 33;// (int)(height / Settings.Height);

                    //if (Game.Snake[i].X < 0 || Game.Snake[i].X >= maxXPos
                    //    || Game.Snake[i].Y < 0 || Game.Snake[i].Y >= maxYPos)
                    //{
                    //    Die();
                    //}

                    if (Game.Snake[i].X < 0) Game.Snake[i].X = maxXPos - 1;
                    if (Game.Snake[i].Y < 0) Game.Snake[i].Y = maxYPos - 1;
                    if (Game.Snake[i].X > maxXPos - 1) Game.Snake[i].X = 0;
                    if (Game.Snake[i].Y > maxYPos - 1) Game.Snake[i].Y = 0;

                    //Detect collission with body
                    for (int j = 1; j < Game.Snake.Count; j++)
                    {
                        if (Game.Snake[i].X == Game.Snake[j].X
                            && Game.Snake[i].Y == Game.Snake[j].Y)
                        {
                            Die();
                        }
                    }

                    //Detect collission with food
                    if (Game.Snake[i].X == Game.Food.X && Game.Snake[i].Y == Game.Food.Y)
                    {
                        Eat();
                    }

                    //Detect collission with walls
                    for (int j = 0; j < Game.Level.Wall.Count; j++)
                    {
                        if (Game.Snake[i].X == Game.Level.Wall[j].X
                            && Game.Snake[i].Y == Game.Level.Wall[j].Y)
                        {
                            Die();
                        }
                    }

                    //Detect collission with portals
                    for (int j = 0; j < Game.Level.Portal.Count; j++)
                    {
                        if (Game.Snake[i].X == Game.Level.Portal[j].X
                            && Game.Snake[i].Y == Game.Level.Portal[j].Y)
                        {
                            Game.Snake[i].X = Game.Level.Portal[(j + 1) % Game.Level.Portal.Count].X;
                            Game.Snake[i].Y = Game.Level.Portal[(j + 1) % Game.Level.Portal.Count].Y;
                            j++;
                        }
                    }
                }
                else
                {
                    if (Settings.direction == Direction.None)
                        break;

                    //Move Body
                    Game.Snake[i].X = Game.Snake[i - 1].X;
                    Game.Snake[i].Y = Game.Snake[i - 1].Y;
                }

            }
        }
        
        private void Die()
        {
            if (Game.Life == 1)
            {
                Game.Life--;
                if(MenuForm.RelaxMode == true)
                {
                    Settings.Win = true;
                }

                Settings.GameOver = true;
            }
            else
            {
                Thread.Sleep(500);

                Game.initSnake();
                Settings.LoseLife = true;
                Game.Life--;
            }
        }

        private void Eat()
        {
            Game.FoodRemaining--;

            //Add food to body
            Circle food = new Circle(0,0);
            food.X = Game.Snake[Game.Snake.Count - 1].X;
            food.Y = Game.Snake[Game.Snake.Count - 1].Y;
            Game.Snake.Add(food);

            Random rnd = new Random();
            poz = rnd.Next(0, 3);
            //Update Score
            Settings.Score += Settings.Points;
            Score_lbl.Text = Settings.Score.ToString();

            food.X = -1;
            food.Y = -1;

            if (MenuForm.RelaxMode == false)
            {
                if (Settings.Score == 700)
                {
                    Level1();
                    NewSnake();
                }

                if (Settings.Score == 1400)
                {
                    Level2();
                    NewSnake();
                }

                if (Settings.Score == 2100)
                {
                    Level3();
                    NewSnake();
                }

                if (Settings.Score == 2900)
                {
                    Level4();
                    NewSnake();
                }

                if (Settings.Score == 3700)
                {
                    Level5();
                    NewSnake();
                }

                if (Settings.Score == 4600)
                {
                    Level6();
                    NewSnake();
                }

                if (Settings.Score == 5600)
                {
                    Level7();
                    NewSnake();
                }
                if (Settings.Score == 6600)
                {
                    Settings.Win = true;
                }
            }
            Game.GenerateFood(pbCanvas.Size.Width, pbCanvas.Size.Height);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Inputs.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Inputs.ChangeState(e.KeyCode, false);
        }

        private void Speed_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Settings.Speed = Convert.ToInt32(Speed_txt.Text.ToString());
                //if(Inputs.KeyPressed(Keys.Enter))
                //{
                //    Pause_lbl.Visible = false;
                //    Settings.direction = Direction.Down;
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        void Pause()
        {
            Pause_lbl.Visible = true;
            Settings.LastDirection = Settings.direction;
            Settings.direction = Direction.None;
        }

        void LevelUp()
        {
            string level = "Felicitari ai ajuns la nivelul " + Level_lbl.Text + "\nApasa ENTER pentru a incepe!";
            Level_lbl_pb.Text = level;
            Level_lbl_pb.Visible = true;

            Game.Level.Wall.Clear();
            Game.Level.Portal.Clear();
            NewSnake();
        }

        void Level1()
        {
            Game.FoodRemaining = 7;
            Level_lbl.Text = "1";

            Settings.LevelUp = true;
            LevelUp();

            //Game.initSnake();

            Pause();

            double x = (pbCanvas.Size.Width / Settings.Width);
            double y = (pbCanvas.Size.Height / Settings.Height);
            int maxXPos = (int)x;//;33;// (int)((width - 1) / Settings.Width);
            int maxYPos = (int)y;// 33;// (int)(height / Settings.Height);

            for (int i = 0; i < 7; i++)
            {
                //Circle zid = new Circle();
                //zid.X = i;
                //zid.Y = 0;

                Game.Level.Wall.Add(new Circle(i,0));
                Game.Level.Wall.Add(new Circle(maxXPos - 7 + i, 0));
                Game.Level.Wall.Add(new Circle(i, maxYPos - 1));
                Game.Level.Wall.Add(new Circle(maxXPos - 7 + i, maxYPos - 1));
            }

            for (int i = 0; i < 7; i++)
            {
                //Circle zid = new Circle();
                //zid.X = i;
                //zid.Y = 0;

                Game.Level.Wall.Add(new Circle(0,i));
                Game.Level.Wall.Add(new Circle(0, maxYPos - 7 + i));
                Game.Level.Wall.Add(new Circle(maxXPos - 1, i));
                Game.Level.Wall.Add(new Circle(maxXPos - 1, maxYPos - 7 + i));
            }
        }

        void Level2()
        {
            Game.FoodRemaining = 7;
            Level_lbl.Text = "2";

            Settings.LevelUp = true;
            LevelUp();

            //Game.initSnake();

            Pause();

            double x = (pbCanvas.Size.Width / Settings.Width);
            double y = (pbCanvas.Size.Height / Settings.Height);
            int maxXPos = (int)x;//;33;// (int)((width - 1) / Settings.Width);
            int maxYPos = (int)y;// 33;// (int)(height / Settings.Height);


            for (int i = 0; i < maxXPos; i++)
            {
                //Circle zid = new Circle();
                //zid.X = i;
                //zid.Y = 0;

                Game.Level.Wall.Add(new Circle(i, 0));
                Game.Level.Wall.Add(new Circle(i, maxYPos - 1));
            }

            for (int i = 0; i < maxYPos; i++)
            {
                //Circle zid = new Circle();
                //zid.X = i;
                //zid.Y = 0;

                Game.Level.Wall.Add(new Circle(0, i));
                Game.Level.Wall.Add(new Circle(maxXPos - 1, i));
            }
        }

        void Level3()
        {
            Game.FoodRemaining = 8;
            Level_lbl.Text = "3";

            Settings.LevelUp = true;
            LevelUp();

            //Game.initSnake();

            Pause();

            Settings.Speed = 12;
            gameTimer.Interval = 1000 / Settings.Speed;
            //Speed_txt.Text = "12";

            double x = (pbCanvas.Size.Width / Settings.Width);
            double y = (pbCanvas.Size.Height / Settings.Height);
            int maxXPos = (int)x;//;33;// (int)((width - 1) / Settings.Width);
            int maxYPos = (int)y;// 33;// (int)(height / Settings.Height);

            for (int i = 6; maxYPos - i >= 6; i++)
            {
                //Circle zid = new Circle();
                //zid.X = 20;
                //zid.Y = maxYPos - i;

                Game.Level.Wall.Add(new Circle(27,maxYPos-i));
            }

            for (int i = 6; maxYPos - i >= 6; i++)
            {
                //Circle zid = new Circle();
                //zid.X = 15;
                //zid.Y = maxYPos - i;

                Game.Level.Wall.Add(new Circle(20,maxYPos-i));
            }

            for (int i = 6; maxYPos - i >= 6; i++)
            {
                //Circle zid = new Circle();
                //zid.X = 10;
                //zid.Y = maxYPos - i;

                Game.Level.Wall.Add(new Circle(13,maxYPos-i));
            }

            for (int i = 6; maxYPos - i >= 6; i++)
            {
                //Circle zid = new Circle();
                //zid.X = 5;
                //zid.Y = maxYPos - i;

                Game.Level.Wall.Add(new Circle(6,maxYPos-i));
            }

        }

        void Level4()
        {
            Game.FoodRemaining = 8;
            Level_lbl.Text = "4";

            Settings.LevelUp = true;
            LevelUp();

            //Game.initSnake();

            Pause();

            double x = (pbCanvas.Size.Width / Settings.Width);
            double y = (pbCanvas.Size.Height / Settings.Height);
            int maxXPos = (int)x;//;33;// (int)((width - 1) / Settings.Width);
            int maxYPos = (int)y;// 33;// (int)(height / Settings.Height);


            for (int i = 0; i < maxXPos; i++)
            {
                //Circle zid = new Circle();
                //zid.X = i;
                //zid.Y = 0;

                Game.Level.Wall.Add(new Circle(i, 16));
            }

            for (int i = 0; i < maxYPos; i++)
            {
                //Circle zid = new Circle();
                //zid.X = i;
                //zid.Y = 0;

                Game.Level.Wall.Add(new Circle(16, i));
            }
        }

        void Level5()
        {
            Game.FoodRemaining = 9;
            Level_lbl.Text = "5";

            Settings.LevelUp = true;
            LevelUp();

            //Game.initSnake();

            Pause();

            double x = (pbCanvas.Size.Width / Settings.Width);
            double y = (pbCanvas.Size.Height / Settings.Height);
            int maxXPos = (int)x;//;33;// (int)((width - 1) / Settings.Width);
            int maxYPos = (int)y;// 33;// (int)(height / Settings.Height);


            for (int i = 0; i < maxYPos; i++)
            {
                Game.Level.Wall.Add(new Circle(maxXPos/3, i));
                Game.Level.Wall.Add(new Circle(2 * maxXPos / 3, i));
                Game.Level.Wall.Add(new Circle(0, i));
                Game.Level.Wall.Add(new Circle(maxXPos - 1, i));
            }

            Game.Level.Portal.Add(new Circle(5, 4));
            Game.Level.Portal.Add(new Circle(17, 28));
            Game.Level.Portal.Add(new Circle(17, 4));
            Game.Level.Portal.Add(new Circle(27, 28));

        }

        void Level6()
        {
            Game.FoodRemaining = 10;
            Level_lbl.Text = "6";

            Settings.LevelUp = true;
            LevelUp();

            Settings.Speed = 10;
            gameTimer.Interval = 1000 / Settings.Speed;

            //Game.initSnake();

            Pause();

            double x = (pbCanvas.Size.Width / Settings.Width);
            double y = (pbCanvas.Size.Height / Settings.Height);
            int maxXPos = (int)x;//;33;// (int)((width - 1) / Settings.Width);
            int maxYPos = (int)y;// 33;// (int)(height / Settings.Height);

            for (int i = 1; i < maxYPos - 1; i += 3)
                for (int j = 1; j < maxXPos - 1; j += 3)
                {
                    Game.Level.Wall.Add(new Circle(i, j));
                }
        }

        void Level7()
        {
            Game.FoodRemaining = 10;
            Level_lbl.Text = "7";

            Settings.LevelUp = true;
            LevelUp();

            //Game.initSnake();

            Pause();

            double x = (pbCanvas.Size.Width / Settings.Width);
            double y = (pbCanvas.Size.Height / Settings.Height);
            int maxXPos = (int)x;//;33;// (int)((width - 1) / Settings.Width);
            int maxYPos = (int)y;// 33;// (int)(height / Settings.Height);

            for (int i = 0; i < maxXPos; i++)
            {
                Game.Level.Wall.Add(new Circle(i, maxYPos / 2));
                Game.Level.Wall.Add(new Circle(i, 0));
                Game.Level.Wall.Add(new Circle(i, maxYPos - 1));
            }

            for (int i = 0; i < maxYPos; i++)
            {
                Game.Level.Wall.Add(new Circle(maxYPos / 2, i));
                Game.Level.Wall.Add(new Circle(0, i));
                Game.Level.Wall.Add(new Circle(maxXPos - 1, i));
            }

            Game.Level.Portal.Add(new Circle(maxXPos / 4, maxYPos / 4));
            Game.Level.Portal.Add(new Circle(3 * maxXPos / 4, maxYPos / 4));
            Game.Level.Portal.Add(new Circle(3 * maxXPos / 4, 3 * maxYPos / 4));
            Game.Level.Portal.Add(new Circle(maxXPos / 4,3 * maxYPos / 4));
        }

        private void GameRun_Load(object sender, EventArgs e)
        {

        }

        private void GameRun_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
                MenuForm.Close();
        }

        private void GameRun_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MenuForm.Close();
        }

    }
}
