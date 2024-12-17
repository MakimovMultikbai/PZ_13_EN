using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfCommand
{
    internal class PhoneTransaction : ITransaction
    {
        public ITransaction? _nextTransaction { get; set; }
        public void SetNext(ITransaction transaction)
        {
            _nextTransaction = transaction;
        }
        public bool Execute(Payment payment)
        {
            if (payment.Direction.Length == 11)
            {
                Console.WriteLine($"Перевод по номеру: {payment.Direction} \nНа сумму: {payment.Summ} выполнен успешно");
                return true;
            }
            return _nextTransaction ? .Execute(payment) ?? false;
        }
    }
}
