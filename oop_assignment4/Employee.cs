using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment4
{
    internal class Employee
    {
        public virtual void  Work()
        {
            Console.WriteLine("Employee is  working");
        }
        //public override string ToString()
        //{
        //    return $"{Work}";
        //}
    }
}
