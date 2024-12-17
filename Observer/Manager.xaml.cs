using System.Windows;

namespace Observer
{
    /// <summary>
    /// Логика взаимодействия для Manager.xaml
    /// </summary>
    public partial class Manager : Window, IManagerObserver
    {
        private new string Name {  get; set; }
        readonly Employee EmployeeWindow = null!;
        public Manager(string name, Employee employee)
        {
            InitializeComponent();
            Name = name;
            EmployeeWindow = employee;
            Employee.Text = EmployeeWindow.ToString();
            ManagerName.Text = $"Менеджер: {Name}";
        }
        void IManagerObserver.Update(StateEmployee state)
        {
            Employee.Text = EmployeeWindow.ToString();
        }
    }
}
