namespace AdapterDP
{
    public class PayoneerAdapter : IPayPalPayment
    {
        public Payoneer Payoneer { get; private set; }
        public PayoneerAdapter(Payoneer payoneer)
        {
            Payoneer = payoneer;
            Console.WriteLine("Realizando adaptação de payoneer para paypal");
        }
        public Token Authtoken()
        {
            return Payoneer.AuthToken();
        }

        public void PayPalPayment()
        {
            Payoneer.AuthToken();
            Payoneer.SendPayment();
        }

        public void PayPalReceive()
        {
            Payoneer.AuthToken();
            Payoneer.ReceivePayment();
        }
    }
}
