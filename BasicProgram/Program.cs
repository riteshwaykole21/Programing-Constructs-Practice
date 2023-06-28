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
            Console.WriteLine("4 : Largest Number Among Three Number");
            Console.WriteLine("5 : Addmission Process Criteria");
            Console.WriteLine("6 : Aretmatic Opration");
            Console.WriteLine("7 : Table");
            Console.WriteLine("8 : Sum Of Squre Upto The Number");
            Console.WriteLine("9 : Factorial Numbers");
            Console.WriteLine("10 :Calculate Year");
            Console.WriteLine("11 : Number Of Days In Months");
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
                case 4:
                    LargestNumber Large = new LargestNumber();
                    Large.Number(); 
                    break;
                case 5:
                    AddmissionPrcess Add = new AddmissionPrcess();
                    Add.Numbers();  
                    break;
                case 6:
                    AreOprations add = new AreOprations();  
                    add.Numbers();
                    break;
                case 7:
                    Table obj = new Table();
                    obj.Number();
                    break;
                case 8:
                    SqureNumber squreNumber = new SqureNumber();
                    squreNumber.Numbers();
                    break;
                case 9:
                    FacrorialNumber facrorialNumber = new FacrorialNumber();
                    facrorialNumber.Numbers();
                    break;
                case 10:
                    Demo demo = new Demo();
                    demo.Numbers();
                    break;
                case 11:
                    NumberOfDays numberOfDays = new NumberOfDays();
                    numberOfDays.Number();
                    break;
            }
            Console.ReadLine();
        }
    }
}
