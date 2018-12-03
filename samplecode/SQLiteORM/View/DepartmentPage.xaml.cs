using System;
using System.Collections.Generic;
using samplecode.Interfaces;
using Xamarin.Forms;

namespace samplecode.SQLiteORM
{
    public partial class DepartmentPage : ContentPage
    {
        List<Department> Departments = new List<Department>();
        public DepartmentPage()
        {
            InitializeComponent();
            InitializeData();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void InitializeData()
        {
            Departments = SQLiteDataContext.Instance.GetAllDepartment();

            if(Departments.Count == 0)
            {
                List<Department> departments = new List<Department>() 
                {
                    new Department()
                    {
                        DepartmentName = "Department 1",
                        Employees = new List<Employee>()
                        {
                            new Employee()
                            {
                                EmployeeName = "Employee 1",
                                Family = new EmployeeFamily()
                                {
                                    WifeName = "Wife 1",
                                    FirstChildName = "First Child 1",
                                    SecondChildName =  "Second Child 2"
                                },
                                Benefits =  new List<EmployeeBenefit>()
                                {
                                    new EmployeeBenefit ()
                                    {
                                        BenefitName = "Benefit 1",
                                        BenefitValue = 1000
                                    },
                                    new EmployeeBenefit ()
                                    {
                                        BenefitName = "Benefit 2",
                                        BenefitValue = 2000
                                    }
                                }
                            },
                            new Employee()
                            {
                                EmployeeName = "Employee 2",
                                Family = new EmployeeFamily()
                                {
                                    WifeName = "Wife 2",
                                    FirstChildName = "First Child 2",
                                    SecondChildName =  "Second Child 2"
                                },
                                Benefits =  new List<EmployeeBenefit>()
                                {
                                    new EmployeeBenefit ()
                                    {
                                        BenefitName = "Benefit 1",
                                        BenefitValue = 1000
                                    },
                                    new EmployeeBenefit ()
                                    {
                                        BenefitName = "Benefit 2",
                                        BenefitValue = 2000
                                    }
                                }
                            },
                        }
                    },

                    new Department()
                    {
                        DepartmentName = "Department 2",
                        Employees = new List<Employee>()
                        {
                            new Employee()
                            {
                                EmployeeName = "Employee 3",
                                Family = new EmployeeFamily()
                                {
                                    WifeName = "Wife 3",
                                    FirstChildName = "First Child 3",
                                    SecondChildName =  "Second Child 3"
                                },
                                Benefits =  new List<EmployeeBenefit>()
                                {
                                    new EmployeeBenefit ()
                                    {
                                        BenefitName = "Benefit 3",
                                        BenefitValue = 3000
                                    },
                                    new EmployeeBenefit ()
                                    {
                                        BenefitName = "Benefit 4",
                                        BenefitValue = 4000
                                    }
                                }
                            },
                            new Employee()
                            {
                                EmployeeName = "Employee 4",
                                Family = new EmployeeFamily()
                                {
                                    WifeName = "Wife 4",
                                    FirstChildName = "First Child 4",
                                    SecondChildName =  "Second Child 4"
                                },
                                Benefits =  new List<EmployeeBenefit>()
                                {
                                    new EmployeeBenefit ()
                                    {
                                        BenefitName = "Benefit 3",
                                        BenefitValue = 3000
                                    },
                                    new EmployeeBenefit ()
                                    {
                                        BenefitName = "Benefit 4",
                                        BenefitValue = 4000
                                    }
                                }
                            },
                        }
                    }
                };
                SQLiteDataContext.Instance.RefreshDepartment(departments);
                Departments = SQLiteDataContext.Instance.GetAllDepartment();
            }

            this.BindingContext = Departments;

        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var department = e.Item as Department;
            if (department == null)
                return;

            await Navigation.PushAsync(new EmployeePage(department));
        }
    }
}
