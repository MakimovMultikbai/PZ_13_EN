using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Observer
{
    /// <summary>
    /// Логика взаимодействия для EmployeeWindow.xaml
    /// </summary>
    public enum StateEmployee { Start, Pause, Resume, End }
    public partial class Employee : Window
    {
        public string EmployeeName { get; set; }
        public StateEmployee EmployeeState {  get; set; }
        readonly List<IManagerObserver> Observers = [];

        public Employee(string name)
        {
            InitializeComponent();
            EmployeeName = name;
            EmpName.Text = EmployeeName;
            this.SetState(StateEmployee.Start);
        }

        public void RegisterObserver(IManagerObserver observer)
        {
            if (!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }
        }

        public void DeleteObserver(IManagerObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (var observer in Observers)
            {
                observer.Update(EmployeeState);
            }
        }

        public void SetState(StateEmployee state)
        {
            EmployeeState = state;
            NotifyObserver();
        }

        public override string ToString()
        {
            return $"Работник: {EmployeeName} состояние: {EmployeeState}";
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            this.SetState(StateEmployee.Start);
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            this.SetState(StateEmployee.Pause);
        }

        private void Resume_Click(object sender, RoutedEventArgs e)
        {
            this.SetState(StateEmployee.Resume);
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            this.SetState(StateEmployee.End);
        }

        private void AddManager_Click(object sender, RoutedEventArgs e)
        {
            Manager newManager = new Manager(ManagerName.Text, this);
            this.RegisterObserver(newManager);
            
            newManager.Show();
        }
    }
}
