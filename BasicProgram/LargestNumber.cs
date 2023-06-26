using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class LargestNumber
    {
        public void Number()
        {
            Console.WriteLine("Enter A First Number");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int Z = Convert.ToInt32(Console.ReadLine());    
            if(X > Y)
            {
                if(X > Z)
                {
                    Console.WriteLine($"Number is Largest {X}");
                }
                else
                {
                    Console.WriteLine($"Number Is Largest {Z}");
                }
            }
            else if (Y > Z)
            {
                Console.WriteLine($"Number Is Largest {Y}");
            }
            else
            {
                Console.WriteLine($"Number Is Largest {Z}");
            }
        }
    }
}
