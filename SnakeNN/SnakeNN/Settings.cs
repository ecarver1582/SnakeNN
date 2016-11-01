using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNN
{
    class Settings
    {
        public int score { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int speed { get; set; }
        public bool gameOver { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            width = 32;
            height = 32;
            speed = 4;
            score = 0;
            direction = Direction.Down;
        }

    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };
}
