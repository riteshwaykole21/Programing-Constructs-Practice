using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class FacrorialNumber
    {
        public void Numbers()
        {
            int Fact = 1;
            Console.WriteLine("Enter A Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= Number; i++)
            {
                Fact = Fact * i;
            }
            Console.WriteLine(Fact);
        }
    }
}
