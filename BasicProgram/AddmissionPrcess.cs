using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class AddmissionPrcess
    {
        public void Numbers()
        {
            Console.WriteLine("Enter Your Math Marks");
            int Math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Physics Marks");
            int Phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Chemistry Mark");
            int Che = Convert.ToInt32(Console.ReadLine());
            int sum = Math + Phy + Che;
            int Sum1 = Math + Phy;
            int Sum2 = Math + Che;
            if(Math >= 65)
            {
                 if(Phy >= 55)
                 {
                      if(Che >= 50)
                      {
                           Console.WriteLine("You are Eligible For Addmission");
                      }
                 }
            }
            if(sum >= 180)
            {
                Console.WriteLine("You are Eligible For Addmission");
            }
            else if(Sum1 >= 140)
            {
                Console.WriteLine("You are Eligible For Addmission");
            }
            else if(Sum2 >= 140)
            {
                Console.WriteLine("You are Eligible For Addmission");
            }
            else
            {
                Console.WriteLine("You Are Not Eligible For Addmision");
            }
        }
    }
}
