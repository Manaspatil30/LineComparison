using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparision
{
    class UC3_CompareLines
    {
        public static void CompareLines()
        {
            //Line1
            Console.WriteLine("Enter values for line 1 :");
            int line1x1 = Convert.ToInt32(Console.ReadLine());
            int line1x2 = Convert.ToInt32(Console.ReadLine());
            int line1y1 = Convert.ToInt32(Console.ReadLine());
            int line1y2 = Convert.ToInt32(Console.ReadLine());



            double length1 = Math.Sqrt((Math.Pow((line1x2 - line1x1), 2) + Math.Pow((line1y2 - line1y1), 2)));
            string len1 = Convert.ToString(length1);

            //Line2
            Console.WriteLine("Enter values for line 2 :");
            int line2x1 = Convert.ToInt32(Console.ReadLine());
            int line2x2 = Convert.ToInt32(Console.ReadLine());
            int line2y1 = Convert.ToInt32(Console.ReadLine());
            int line2y2 = Convert.ToInt32(Console.ReadLine());


            
            double length2 = Math.Sqrt((Math.Pow((line2x2 - line2x1), 2) + Math.Pow((line2y2 - line2y1), 2)));
            string len2 = Convert.ToString(length2);


            //Comparing both lines
            int comp = len1.CompareTo(len2);

            if (comp > 0)
                Console.WriteLine("Line 1 is greater than Line 2");
            else if (comp < 0)
                Console.WriteLine("Line 2 is greater than Line 1");
            else
                Console.WriteLine("Both are equal ");


        }

    }
}
