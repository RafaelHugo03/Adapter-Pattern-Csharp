// See https://aka.ms/new-console-template for more information


using AdapterDP;

//PayPal paypal = new PayPal();
//paypal.PayPalPayment();
//paypal.PayPalReceive();
//Console.WriteLine();

//Payoneer payoneer = new Payoneer();
//payoneer.SendPayment();
//payoneer.ReceivePayment();
//Console.WriteLine();


IPayPalPayment payment = new PayoneerAdapter(new Payoneer());

payment.PayPalPayment();
payment.PayPalReceive();