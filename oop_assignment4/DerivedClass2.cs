using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment4
{
    internal class DerivedClass2 : BaseClass
    {
        public new void display()
        {
            base.display();
            Console.WriteLine("DerivedClass2");
        }
        
    }
}
