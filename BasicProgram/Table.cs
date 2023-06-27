using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Table
    {
        public void Number()
        {
            Console.WriteLine("Enter a Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {n} = {i*n}");
            }
        }
    }
}
