using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparision
{
    class UC2_CheckEqaulity
    {
        public static void CheckEquality()
        {
            //Line1
            Console.WriteLine("Enter values for line 1 :");
            int line1x1 = Convert.ToInt32(Console.ReadLine());
            int line1x2 = Convert.ToInt32(Console.ReadLine());
            int line1y1 = Convert.ToInt32(Console.ReadLine());
            int line1y2 = Convert.ToInt32(Console.ReadLine());



            double length1 = Math.Sqrt((Math.Pow((line1x2 - line1x1), 2) + Math.Pow((line1y2 - line1y1), 2)));
            Console.WriteLine("length of line 1 is:" + length1);

            //Line2
            Console.WriteLine("Enter values for line 2 :");
            int line2x1 = Convert.ToInt32(Console.ReadLine());
            int line2x2 = Convert.ToInt32(Console.ReadLine());
            int line2y1 = Convert.ToInt32(Console.ReadLine());
            int line2y2 = Convert.ToInt32(Console.ReadLine());



            double length2 = Math.Sqrt((Math.Pow((line2x2 - line2x1), 2) + Math.Pow((line2y2 - line2y1), 2)));
            Console.WriteLine("length of line 2 is:" + length2);

            //Checking Equality
            if (length1.Equals(length2))
                Console.WriteLine("Line1 is eqaul to Line2");
            else
                Console.WriteLine("Line1 is not equal to Line2");
        }
    }
}
