using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB_3._3
{
    class Point
    {
        protected int radius;
        protected int sides;
        protected string polygon;
        public Point (int radius, int sides, string polygon)
        {
            this.radius = radius;
            this.sides = sides;
            this.polygon = polygon;
        }
    }
}
