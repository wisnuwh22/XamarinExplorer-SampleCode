using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace samplecode.SQLiteORM
{
    public partial class EmployeeDetailPage : ContentPage
    {
        public string WifeName { get; set; }
        public string FirstChildName { get; set; }
        public string SecondChildName { get; set; }
        public List<EmployeeBenefit> Benefits { get; set; }

        public EmployeeDetailPage(Employee employee)
        {
            InitializeComponent();
            InitialiazeData(employee);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void InitialiazeData(Employee employee)
        {
            WifeName = $"Wife Name : {employee.Family.WifeName}";
            FirstChildName = $"First Child Name : {employee.Family.FirstChildName}";
            SecondChildName = $"Second Child Name : {employee.Family.SecondChildName}";

            Benefits = employee.Benefits;

            BindingContext = this;
        }
    }
}
