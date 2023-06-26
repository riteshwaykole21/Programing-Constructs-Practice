using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class AgeProblem
    {
        public void Numbers()
        {
            Console.WriteLine("Enter Your Age");
            int Age = Convert.ToInt32(Console.ReadLine());
            if(Age >= 18)
            {
                Console.WriteLine("you are Eligible For vote");
            }
            else
            {
                Console.WriteLine("you are not Eligible For Vote");
            }
        }
    }
}
