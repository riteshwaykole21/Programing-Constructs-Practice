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
            Console.WriteLine("2 : Vote Eligibility Criteria");
            Console.WriteLine("3 : Check Number Even Or Odd");
            Console.WriteLine("Enter A Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    CheckEqual check = new CheckEqual();
                    check.Numbers();
                    break;
                case 2:
                    AgeProblem ageProblem = new AgeProblem();
                    ageProblem.Numbers();
                    break;
                case 3:
                    EvenOrOdd Even = new EvenOrOdd();
                    Even.Numbers();
                    break;
            }
            Console.ReadLine();
        }
    }
}
