using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    enum Theme { Dark, Light }
    internal class User
    {
        private string _login;
        private string _email;
        private Theme _theme;
        private CareTacker _careTacker = new CareTacker();

        public string Login { get => _login; set => _login = value; }

        public string Email { get => _email; set => _email = value; }

        public Theme Theme { get => _theme; set => _theme = value; }

        public User(string login, string email)
        {
            _login = login;
            _email = email;
            Theme = Theme.Light;
            this.SaveState();
        }

        public void ChangeTheme(Theme theme)
        {
            Theme = theme;
        }

        public void SaveState()
        {
            _careTacker.Memento = new Memento(this._login, this._email, this._theme);
        }
        public void LoadState()
        {
            _theme = _careTacker.Memento.GetSavedState(out _login, out _email);
        }
    }
}
