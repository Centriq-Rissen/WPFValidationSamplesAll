using BusinessObjects.BusinessEntities;
using BusinessObjects.Validators;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConstructorDependencyInjectionSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //  Here we INJECT the validator we want to use
            //  when the employee is created, he's also handed
            //  his validator to use
            var emp = new Employee(new EmployeeValidator1())
            {
                LastName = "Flinstone",
                FirstName = "Fred",
                ID = 0
            };

            grdMain.DataContext = emp;
        }
    }
}
