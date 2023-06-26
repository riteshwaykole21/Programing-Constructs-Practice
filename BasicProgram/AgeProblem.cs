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
            if(Age <= 18)
            {
                Console.WriteLine("He/She Eligible For Own vote");
            }
            else
            {
                Console.WriteLine("He/she DoesNot Eligible For Vote");
            }
        }
    }
}
