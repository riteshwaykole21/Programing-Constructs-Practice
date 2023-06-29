using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class ReverseWord
    {
        public void Numbers()
        {
            Console.WriteLine("Enter A Words");
            string str = Console.ReadLine();
            char[] Name = str.ToCharArray();
            int i = Name.Length - 1;
            while(i >= 0)
            {
                Console.Write(Name[i]);
                i--;
            }
        }
    }
}
