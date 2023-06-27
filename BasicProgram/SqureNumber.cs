using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class SqureNumber
    {
        public void Numbers()
        {
            int Sum = 0;
            Console.WriteLine("Enter A Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= Number; i++)
            {
                Sum += (i * i);
            }
            Console.WriteLine(Sum);
        }
    }
}
