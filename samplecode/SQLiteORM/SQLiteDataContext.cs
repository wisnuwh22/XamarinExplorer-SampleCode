using System;
using System.Collections.Generic;
using System.Linq;
using SQLiteNetExtensions.Extensions;
using Xamarin.Forms;

namespace samplecode.SQLiteORM
{
    public class SQLiteDataContext
    {
        private static SQLiteDataContext instance;

        public static SQLiteDataContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SQLiteDataContext();
                }
                return instance;
            }
        }

        private SQLite.SQLiteConnection connection;

        private SQLiteDataContext()
        {
            connection = DependencyService.Get<ISQLite>().GetSQLiteConnection();
            CreateTableIfNotExist();
        }

        private void CreateTableIfNotExist()
        {


            bool isTableNotExist = false;

            try
            {
                var test = connection.Table<Department>().FirstOrDefault();
            }
            catch
            {
                isTableNotExist = true;
            }

            if (isTableNotExist)
            {
                connection.CreateTable<Department>();
            }

            isTableNotExist = false;


            try
            {
                var test = connection.Table<Employee>().FirstOrDefault();
            }
            catch
            {
                isTableNotExist = true;
            }

            if (isTableNotExist)
            {
                connection.CreateTable<Employee>();
            }


            isTableNotExist = false;

            try
            {
                var test = connection.Table<EmployeeFamily>().FirstOrDefault();
            }
            catch
            {
                isTableNotExist = true;
            }

            if (isTableNotExist)
            {
                connection.CreateTable<EmployeeFamily>();
            }

            isTableNotExist = false;

            try
            {
                var test = connection.Table<EmployeeBenefit>().FirstOrDefault();
            }
            catch
            {
                isTableNotExist = true;
            }

            if (isTableNotExist)
            {
                connection.CreateTable<EmployeeBenefit>();
            }


        }

        public List<Department> GetAllDepartment()
        {

            return ReadOperations.GetAllWithChildren<Department>(connection, recursive: true).ToList();
        }

        public void RefreshDepartment(IList<Department> listDepartment)
        {
            WriteOperations.DeleteAll(connection, GetAllDepartment(), true);
            WriteOperations.InsertOrReplaceAllWithChildren(connection, listDepartment, true);
        }

        public void DeleteAllDepartment()
        {
            WriteOperations.DeleteAll(connection, GetAllDepartment(), true);
        }

        public void UpdateDepartment(Department department)
        {
            WriteOperations.UpdateWithChildren(connection, department);
        }

        public void UpdateEmployee(Employee employee)
        {
            WriteOperations.UpdateWithChildren(connection, employee);
        }
    }
}
