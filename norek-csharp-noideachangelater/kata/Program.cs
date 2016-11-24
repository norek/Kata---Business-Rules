using System;
using kata.Model;
using kata.PaymentResponse;

namespace kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kata");

            IPayable prod = new Product();

            
            GenerateStripResponse resp = new GenerateStripResponse();
            resp.RegisterType(1);

            GenerateDuplicateStripResponse resp1 = new GenerateDuplicateStripResponse();
            resp1.RegisterType(2);

            CommissionPaymentResponse resp2 = new CommissionPaymentResponse();
            resp2.RegisterType(1);
            resp2.RegisterType(2);

            PaymentProvider payemntProvider = new PaymentProvider(resp, resp1, resp2);
            var respColelction = payemntProvider.CreatePaymentResponseFor(prod);

            foreach (var response in respColelction)
            {
                response.Execute();
            }
            
            Console.ReadLine();
        }
    }

}
