using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IManagerObserver
    {
        void Update(StateEmployee state);
    }
}
