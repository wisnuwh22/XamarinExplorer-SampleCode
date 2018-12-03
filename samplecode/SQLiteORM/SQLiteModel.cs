using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace samplecode.SQLiteORM
{
    public class Department
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string DepartmentName { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Employee> Employees { get; set; }

    }

    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string IDCardNumber { get; set; }
        public string EmployeeName { get; set; }

        [ForeignKey(typeof(Department))]
        public int DepartmentID { get; set; }

        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public Department Deparment { get; set; }

        [ForeignKey(typeof(EmployeeFamily))]
        public int FamilyID { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public EmployeeFamily Family { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<EmployeeBenefit> Benefits { get; set; }

    }

    public class EmployeeFamily
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string WifeName { get; set; }
        public string FirstChildName { get; set; }
        public string SecondChildName { get; set; }

        [ForeignKey(typeof(Employee))]
        public int EmployeeID { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Employee Employee { get; set; }
    }

    public class EmployeeBenefit
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Employee))]
        public int EmployeeID { get; set; }

        public string BenefitName { get; set; }
        public double BenefitValue { get; set; }

        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public Employee Employee { get; set; }
    }

}
