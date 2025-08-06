using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment4
{
    internal class Manager  :Employee
    {

        public override void Work()
        {
            base .Work();
            Console.WriteLine("Manager is managing");
        }

        //public override string ToString()
        //{
        //    return $"{Work}";
        //}
    }
}
