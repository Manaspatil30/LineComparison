using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparision
{
    class UC1_CalculateLength
    {
        public static void CalculateLength()
        {
          
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());



            double length = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            Console.WriteLine("length of line is:" + length);
            Console.ReadKey(); 
        }
    }
}
