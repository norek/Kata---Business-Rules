using System;
using System.Collections.Generic;
using System.Linq;

namespace kata.PaymentResponse
{

    abstract class PaymentResponse : IPaymentResponse
    {
        private readonly List<int> _types = new List<int>();

        public void RegisterType(int vrpType)
        {
            if (_types.Contains(vrpType)) throw new ArgumentException();

            _types.Add(vrpType);
        }

        public abstract void Execute();

        public bool CanBeReposneOf(int type)
        {
            return _types.Any(d => d == type);
        }
    }
}
