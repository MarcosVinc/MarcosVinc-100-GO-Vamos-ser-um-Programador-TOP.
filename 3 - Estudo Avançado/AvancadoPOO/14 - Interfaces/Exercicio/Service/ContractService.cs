using Exercicio.Entities;
using Interfaces.Exercicio;
using System;

namespace Exercicio.Service
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int mes) 
        {
            double CotaBasica = contract.totalValue / mes;
            for (int i = 1; i <= mes; i++) 
            {
                DateTime data = contract.dateTime.AddMonths(i); ;
                double updateCota = CotaBasica + _onlinePaymentService.Interest(CotaBasica, i);
                double cotaCheia = updateCota + _onlinePaymentService.PaymentFee(updateCota);
                contract.AddInstallment(new Installment(data, cotaCheia));
            }
         
        }
    }
}
