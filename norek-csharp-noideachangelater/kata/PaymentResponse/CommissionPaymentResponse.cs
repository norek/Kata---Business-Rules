using System;

namespace kata.PaymentResponse
{
    class CommissionPaymentResponse : PaymentResponse
    {
        public override void Execute()
        {
            Console.WriteLine("commission payment to the agent");
        }
    }
}