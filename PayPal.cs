using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP
{
    public class PayPal : IPayPalPayment
    {
        private Token token;
        public Token Authtoken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            token = Authtoken();
            Console.WriteLine("Enviando pagamentos com paypal");
        }

        public void PayPalReceive()
        {
            token = Authtoken(); 
            Console.WriteLine("Recebendo pagamentos com paypal");
        }
    }
}
