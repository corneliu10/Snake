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
   
    public class Level
    {
        public Level(List<Circle> wall, List<Circle> portal)
        {
            this.Wall = wall;
            this.Portal = portal;
        }

        private List<Circle> wall = new List<Circle>();
        private List<Circle> portal = new List<Circle>();

        public List<Circle> Wall
        {
            get { return wall; }
            set { wall = value; }
        }

        public List<Circle> Portal
        {
            get { return portal; }
            set { portal = value; }
        }
    }
}
