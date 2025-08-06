using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment4
{
    internal class Duration
    {

        #region attributes 
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region methods 
        public Duration(int hours,int minutes ,int seconds)

        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            
        }



        //over ride on +
        public static Duration operator +(Duration d1, Duration d2 )
        {
            return new Duration
            {
                Hours = d1.Hours + d2.Hours,
                Minutes = d1.Minutes + d2.Minutes,
                Seconds = d1.Seconds + d2.Seconds,


            };
            
           
            //over ride on -
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration
            {
                Hours = d1.Hours - d2.Hours,
                Minutes = d1.Minutes - d2.Minutes,
                Seconds = d1.Seconds - d2.Seconds,


            };



        public override string ToString()
        {
            return $"hours:{Hours}minutes:{Minutes}seconds:{Seconds}";
        }
        #endregion 
    }
}
