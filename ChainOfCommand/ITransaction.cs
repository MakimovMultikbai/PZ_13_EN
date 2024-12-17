using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfCommand
{
    internal interface ITransaction
    {
        ITransaction? _nextTransaction { get; set; }
        void SetNext(ITransaction transaction);
        bool Execute(Payment payment);
    }
}
