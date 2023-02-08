using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                CreditCard a = new CreditCard("Karasik","1234567890123456","013",12,99);
                a.PrintCardDetails();
            }
            catch(Exception e)
            {
                Console.WriteLine("Excpetion - " + e.Message);
            }

            

          
        }
    }
}
