using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public class Game
    {
        //public Bitmap head { get; set; }
        public Bitmap Snakehead { get; set; }
        public Bitmap Snakebody { get; set; }
        public Bitmap Snaketail { get; set; }

	    public Level Level { get; set; }

        public List<Circle> Snake { get; set; }
        public Circle Food { get; set; }

        public int Life { get; set; }
        public int FoodRemaining { get; set; }

        public Game()
        {
            //head = (Bitmap)Bitmap.FromFile("snakehead.png");
            Snakehead = (Bitmap)Bitmap.FromFile("snakehead.png");
            Snakebody = (Bitmap)Bitmap.FromFile("body2.png");
            Snaketail = (Bitmap)Bitmap.FromFile("snaketail.png");

            var portal = new List<Circle>();
            var wall = new List<Circle>();
            Level = new Level(wall,portal);
            Snake = new List<Circle>();
            Food = new Circle(0,0);
            Life = 4;
            FoodRemaining = 7;
        }
        
        public void GenerateFood(int width, int height)
        {
            double x = (width / Settings.Width);
            double y = (height / Settings.Height);
            int maxXPos = (int) x;//;33;// (int)((width - 1) / Settings.Width);
            int maxYPos = (int) y;// 33;// (int)(height / Settings.Height);

            Random random = new Random();
            Food = new Circle(0,0);
            Food.X = random.Next(0, maxXPos);
            Food.Y = random.Next(0, maxYPos);

            for (int i = 0; i < Snake.Count; i++)
            {
                if (Food.X == Snake[i].X && Food.Y == Snake[i].Y)
                {
                    GenerateFood(width, height);
                    break;
                }
            }

            for (int i = 0; i < this.Level.Wall.Count; i++)
            {
                if (Food.X == this.Level.Wall[i].X && Food.Y == this.Level.Wall[i].Y)
                {
                    GenerateFood(width, height);
                    break;
                }
            }

            for (int i = 0; i < this.Level.Portal.Count; i++)
            {
                if (Food.X == this.Level.Portal[i].X && Food.Y == this.Level.Portal[i].Y)
                {
                    GenerateFood(width, height);
                    break;
                }
            }
        }

        public void initSnake()
        {
            int maxXPos = 33;
            int maxYPos = 33;

            Random random = new Random();

            this.Snake[0].X = random.Next(0,maxXPos - 1);
            this.Snake[0].Y = random.Next(0,maxYPos - 1);
            this.Snake.Remove(this.Snake[this.Snake.Count - 1]);

            for (int i = 1; i < this.Snake.Count; i++)
            {
                this.Snake[i].X = this.Snake[0].X;
                this.Snake[i].Y = this.Snake[0].Y + i;
            }

            this.Snake.Add(new Circle(this.Snake[this.Snake.Count - 1].X, this.Snake[this.Snake.Count - 1].Y + 1));
            //this.Snake[this.Snake.Count - 1].X = this.Snake[this.Snake.Count - 2].X;
            //this.Snake[this.Snake.Count - 1].Y = this.Snake[this.Snake.Count - 2].Y ;

            for (int j = 0; j < this.Snake.Count; j++)
            {
                for (int i = 0; i < this.Level.Wall.Count; i++)
                {
                    if (this.Snake[j].X == this.Level.Wall[i].X && this.Snake[j].Y == this.Level.Wall[i].Y)
                    {
                        initSnake();
                        return;
                    }
                }

                for (int i = 0; i < this.Level.Portal.Count; i++)
                {
                    if (this.Snake[j].X == this.Level.Portal[i].X && this.Snake[j].Y == this.Level.Portal[i].Y)
                    {
                        initSnake();
                        return;
                    }
                }
            }

            this.Snakehead = (Bitmap)Bitmap.FromFile("snakeheadup.png");
            
        }
    }
}
