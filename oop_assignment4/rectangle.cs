using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment4
{
    internal class Rectangle
    {

        public int Height { get; set; }
        public int width { get; set; }

        //A parameterless constructor that sets the width and height to 0.
        public Rectangle()
        {
            Height = 0;
            width = 0;

        }
        //A constructor that accepts width and height as integers.
        public Rectangle(int h, int w)
        {
            Height = h;
            width = w;

        }

        //A constructor that accepts a single integer and sets both width and height to that value.
        public Rectangle(int x)
        {
            Height = x;
            width = x;
        }

        public override string ToString()
        {
            return $"height = {Height}\n width = {width}   ";
        }

    }
}
