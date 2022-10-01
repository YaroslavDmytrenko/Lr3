using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth
{
    public class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        string article;
        int quantity;


        public Invoice(int account, string customer, string provider, string article)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.quantity = quantity;
            this.article = article;
        }

        public void Calc()
        {
            double tax = 0;
            double result = 0;
            Random random = new Random();
            int price = random.Next(100, 1000);
            quantity = account / price;
            switch (article)
            {
                case "+":
                    {
                        tax = 0.15;
                        result = (price * quantity) * tax;
                        break;
                    }
                case "-":
                    {
                        result = price * quantity;
                        break;
                    }
            }
            Console.WriteLine(result);
        }
    }
}
