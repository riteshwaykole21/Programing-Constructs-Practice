using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class NumberSum
    {
        public void Number()
        {
            int Num = 5;
            int sum = 0;
            int i = 1;  
            while(i <= Num)
            {
                sum += i;
                i++;
            }
            Console.WriteLine($"Sum Of 5 Natural Number Is {sum}");
        }
    }
}
