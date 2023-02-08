using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class CreditCard
    {
        string user_fullname;
        string valid_time;
        string card_number;
        string CVC;
        public CreditCard()
        {
            card_number = "1111111111111111";
            CVC = "111";
            user_fullname = "NoName";
            valid_time = "11/99";
        }
        public CreditCard(string user_fullname, string valid_time, string card_number, string CVC)
        {
            this.user_fullname = user_fullname;

            if (card_number.All(char.IsDigit) != true)
                throw new Exception("Card number contains non-digit characters.");
            else if (card_number.Length != 16)
                throw new Exception("Wrong card number length.");
            else
                this.card_number = card_number;

            if (CVC.All(char.IsDigit) != true)
                throw new Exception("CVC number contains non-digit characters.");
            else if(CVC.Length != 3)
                throw new Exception("Wrong CVC length.");
            else
                this.CVC = CVC;

            Char[] arr = valid_time.ToCharArray();
            string checkString = valid_time.Remove(2);

            if (valid_time.Length != 5)
                throw new Exception("Wrong valid time length.");
            else if (arr[2] != '/')
                throw new Exception("Wrong valid time format.");
            else if (checkString.All(char.IsDigit) != true)
                throw new Exception("Valid time contains non-digit characters.");
            else
                this.valid_time = valid_time;

        }

        public void  PrintCardDetails()
        {
            Console.WriteLine("Full name - " + user_fullname);
            Console.WriteLine("Card number - " + card_number);
            Console.WriteLine("CVC - " + CVC);
            Console.WriteLine("Valid Time - " + valid_time);
        }
    }
}
