using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardInterfaceConcept
{
    interface IDebitCard
    {
        void CardNumber();
    }

    interface ICreditCard
    {
        void CardNumber();
    }

    class Customer: IDebitCard, ICreditCard
    {
        void IDebitCard.CardNumber()
        {
            Console.WriteLine("Debit Card Number: My Card Number is 12345XXXXX");
        }

        void ICreditCard.CardNumber()
        {
            Console.WriteLine("Credit Card Number: My Card Number is 98999XXXXX");
        }

        public void CardNumber()
        {
            Console.WriteLine("Customer ID Number: My ID Number is 54545XXXXX");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("////////////////////- Implicit and Expliction Implementation -//////////////////// \n\n");
            Customer customer = new Customer();
            IDebitCard DebitCard = new Customer();
            ICreditCard CreditCard = new Customer();

            customer.CardNumber();
            DebitCard.CardNumber();
            CreditCard.CardNumber();

            Console.ReadKey();

        }
    }
}
