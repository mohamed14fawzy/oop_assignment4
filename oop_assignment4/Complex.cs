using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment4
{
    internal class Complex
    {
        #region properties
        public int real { get; set; }
        public int imaginary { get; set; }
        #endregion

        #region methods

        public Complex(int x , int y)

        {
            real = x;
            imaginary = y;
            
        }

        public Complex()
        {
            real = 0;
            imaginary = 0;
        }


        //override on +
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex
            {
                real = left.real + right.real,
                imaginary = right.imaginary + left.imaginary,
               
            }
            ;
        }

        //ovverride on -
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex
            {
                real = left.real - right.real,
                imaginary = right.imaginary - left.imaginary,

            }
            ;
        }

        public override string ToString()
        {
            return$"{real} + {imaginary}i ";
        }
        #endregion


    }
}
