using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : check Number Are Equal Or Not");
            Console.WriteLine("Enter A Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    CheckEqual check = new CheckEqual();
                    check.Numbers();
                    break;
            }
            Console.ReadLine();
        }
    }
}
