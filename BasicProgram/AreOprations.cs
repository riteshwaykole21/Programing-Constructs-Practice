using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class AreOprations
    {
        public void Numbers()
        {
            Console.WriteLine("1 : Addition");
            Console.WriteLine("2 : Subtraction");
            Console.WriteLine("3 : Multiplication");
            Console.WriteLine("4 : Division");
            Console.WriteLine("Enter A Option Which Opration is Perform");
            int Check = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A First Number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            switch(Check)
            {
                case 1 :
                    int Sum = First + Second;
                    Console.WriteLine($"Addition is {Sum}");
                    break;
                case 2:
                    int Sub = First - Second;
                    Console.WriteLine($"Subtraction is {Sub}");
                    break;
                case 3:
                    int Mul = First * Second;
                    Console.WriteLine($"Multiplication is {Mul}");
                    break;
                case 4:
                    int Div = First / Second;
                    Console.WriteLine($"Division is {Div}");
                    break;
                default:
                    Console.WriteLine("Give A Proper Msg");
                    break;
            }
        }
    }
}
