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
        ushort valid_time_month;
        ushort valid_time_year;
        string card_number;
        string CVC;
        public CreditCard()
        {
            card_number = "1111111111111111";
            CVC = "111";
            user_fullname = "NoName";
            valid_time_month = 12;
            valid_time_year = 99;
        }
        public CreditCard(string user_fullname, string card_number, string CVC, ushort valid_time_month, ushort valid_time_year)
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

            if (valid_time_month > 12 || valid_time_month < 0)
                throw new Exception("Invalid valid time month value");
            else
                this.valid_time_month = valid_time_month;

            if (valid_time_year > 99 || valid_time_year < 0)
                throw new Exception("Invalid valid time year value");
            else
                this.valid_time_year = valid_time_year;



  

        }

        public void  PrintCardDetails()
        {
            Console.WriteLine("Full name - " + user_fullname);
            Console.WriteLine("Card number - " + card_number);
            Console.WriteLine("CVC - " + CVC);
            Console.WriteLine("Valid Time - " + valid_time_month + "/" + valid_time_year);
        }
    }
}
