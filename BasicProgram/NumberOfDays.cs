using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class NumberOfDays
    {
        public void Number()
        {
            Console.WriteLine("Enter The Months Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            switch(Number)
            {
                case 1:
                    Console.WriteLine("January in Months 31 Days");
                    break;
                case 2:
                    Console.WriteLine("February in Months 28/29 Days");
                    break;
                case 3:
                    Console.WriteLine("March in Months 31 Days");
                    break;
                case 4:
                    Console.WriteLine("April in Months 30 Days");
                    break;
                case 5:
                    Console.WriteLine("May in Months 31 Days");
                    break;
                case 6:
                    Console.WriteLine("June In Months 30 Days");
                    break;
                case 7:
                    Console.WriteLine("July in Months 31 Days");
                    break;
                case 8:
                    Console.WriteLine("August in Months 31 Days");
                    break;
                case 9:
                    Console.WriteLine("September in Months 30 Days");
                    break;
                case 10:
                    Console.WriteLine("October in Months 31 Days");
                    break;
                case 11:
                    Console.WriteLine("November In Months 30 Days");
                    break;
                case 12:
                    Console.WriteLine("December in Months 31 Days");
                    break;

            }
        }
    }
}
