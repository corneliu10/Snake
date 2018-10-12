using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{

    public enum Direction { Up,Down,Left,Right,None };

    class Settings
    {
        public static float Width { get; set; }
        public static float Height { get; set; }
        public static int Score { get; set; }
        public static int Speed { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static bool LevelUp { get; set; }
        public static Direction direction { get; set; }
        public static Direction LastDirection { get; set; }
        public static bool LoseLife { get; set; }
        public static bool Win { get; set; }

        public Settings()
        {
            Width = 16;
            Height = 16;
            Score = 0;
            Speed = 10;
            Points = 100;
            GameOver = false;
            LevelUp = false;
            direction = Direction.None;
            LastDirection = Direction.None;
            LoseLife = false;
            Win = false;
        }
    }
}
