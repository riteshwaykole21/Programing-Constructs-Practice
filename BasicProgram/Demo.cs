using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Demo
    {
        public void Numbers()
        {
            int Year = 0;
            int Week = 0;   
            int days = 0;
            Console.WriteLine("Enter Number Of Days");
            int Num = Convert.ToInt32(Console.ReadLine());
            Year = Num / 365;
            Week = (Num % 365) / 7;
            days = (Num % 365) % 7;
            Console.WriteLine($"Year : {Year}");
            Console.WriteLine($"Weeks : {Week}");
            Console.WriteLine($"days : {days}");

        }
    }
}
