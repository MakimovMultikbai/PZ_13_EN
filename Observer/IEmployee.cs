using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal interface IEmployee
    {
        void RegisterObserver(IManagerObserver observer);
        void DeleteObserver(IManagerObserver observer);
        void NotifyObserver();
    }
}
