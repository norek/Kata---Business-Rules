namespace kata.PaymentResponse
{
    internal interface IPaymentResponse
    {
        bool CanBeReposneOf(int type);
        void Execute();
    }
}