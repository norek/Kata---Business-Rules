using System;

namespace kata.PaymentResponse
{

    class GenerateStripResponse : PaymentResponse
    {
        public override void Execute()
        {
            Console.WriteLine("Generate slip");
        }
    }
    
}
