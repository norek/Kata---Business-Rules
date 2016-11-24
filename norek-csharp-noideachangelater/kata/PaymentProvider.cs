using System;
using System.Collections.Generic;
using System.Linq;
using kata.Model;
using kata.PaymentResponse;

namespace kata
{
    internal class PaymentProvider
    {
        readonly IPaymentResponse[] _responseContainer;

        public PaymentProvider(params IPaymentResponse[] response)
        {
            _responseContainer = response;
        }

        internal IPaymentResponse[] CreatePaymentResponseFor(IPayable payable)
        {
            return _responseContainer.Where(d => d.CanBeReposneOf(payable.Type)).ToArray();
        }
    }
}