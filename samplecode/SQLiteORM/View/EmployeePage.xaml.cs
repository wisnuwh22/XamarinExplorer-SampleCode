using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace samplecode.SQLiteORM
{
    public partial class EmployeePage : ContentPage
    {
        public EmployeePage(Department department)
        {
            InitializeComponent();
            InitialiazeData(department);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void InitialiazeData(Department department)
        {
            if (department.Employees == null)
                return;

            this.BindingContext = department.Employees;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var employee = e.Item as Employee;
            if (employee == null)
                return;

            await Navigation.PushAsync(new EmployeeDetailPage(employee));
        }
    }
}
