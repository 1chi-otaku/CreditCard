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
                CreditCard a = new CreditCard("Karasik","12/52","1234567890123456","021");
            }
            catch(Exception e)
            {
                Console.WriteLine("Excpetion - " + e.Message);
            }
          
        }
    }
}
