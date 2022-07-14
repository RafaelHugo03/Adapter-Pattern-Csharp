namespace AdapterDP
{
    public interface IPayPalPayment
    {
        Token Authtoken();
        void PayPalPayment();
        void PayPalReceive();
    }
}
