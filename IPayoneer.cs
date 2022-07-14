namespace AdapterDP
{
    public interface IPayoneer
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();
    }
}
