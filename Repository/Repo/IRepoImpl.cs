using Model;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repo
{
    public class IRepoImpl : IRepo
    {
        private readonly UserDatabaseContext userDBContext;

        public IRepoImpl(UserDatabaseContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }

        public Employee AddEmployee(Employee employee)
        {
            userDBContext.Employee.Add(employee);
            userDBContext.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee = userDBContext.Employee.Find(id);
            if (employee != null)
            {
                userDBContext.Employee.Remove(employee);
                userDBContext.SaveChanges();
            }
            return employee;

        }
      
        public Employee UpdateEmployee(Employee employeeChanges)
        {
            var employee = userDBContext.Employee.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            userDBContext.SaveChanges();
            return employeeChanges;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return userDBContext.Employee;
        }
    }
}
