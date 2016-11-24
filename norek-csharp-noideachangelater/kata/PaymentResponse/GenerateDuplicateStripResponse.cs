using System;

namespace kata.PaymentResponse
{

    class GenerateDuplicateStripResponse : PaymentResponse
    {
        public override void Execute()
        {
            Console.WriteLine("duplicate packing slip for the royalty department");
        }
    }
}
