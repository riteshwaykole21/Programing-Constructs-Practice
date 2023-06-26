using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class CheckEqual
    {
        public void Numbers()
        {
            Console.WriteLine("Enter First Number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int second = Convert.ToInt32(Console.ReadLine());   
            if(First == second)
            {
                Console.WriteLine("Both Numbers Are Equal");
            }
            else
            {
                Console.WriteLine("The Numbers Are Not Equal");
            }
        }
    }
}
