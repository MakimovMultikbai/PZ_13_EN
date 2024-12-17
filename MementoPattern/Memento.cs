using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Memento
    {
        private string _savedLogin;
        private string _savedEmail;
        private Theme _savedTheme;

        public Memento(string savedLogin, string savedEmail, Theme savedTheme)
        {
            _savedLogin = savedLogin;
            _savedEmail = savedEmail;
            _savedTheme = savedTheme;   
        }

        public Theme GetSavedState(out string login, out string email)
        {
            login = _savedLogin;
            email = _savedEmail;
            return _savedTheme;
        }
    }
}
