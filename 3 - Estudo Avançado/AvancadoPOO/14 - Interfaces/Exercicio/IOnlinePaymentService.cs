
namespace Interfaces.Exercicio
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int mes);
    }
}
