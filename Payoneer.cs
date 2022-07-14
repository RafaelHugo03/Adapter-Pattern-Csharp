namespace AdapterDP
{
    public class Payoneer : IPayoneer
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamentos com payoneer");
        }

        public void SendPayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamentos com payoneer");
        }
    }
}
