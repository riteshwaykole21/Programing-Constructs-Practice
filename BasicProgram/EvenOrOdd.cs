using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class EvenOrOdd
    {
        public void Numbers()
        {
            Console.WriteLine("Enter A Numbers");
            int Num = Convert.ToInt32(Console.ReadLine());
            if(Num % 2 == 0)
            {
                Console.WriteLine("The Number Is Even");
            }
            else
            {
                Console.WriteLine("The Number Is Odd");
            }
        }
    }
}
