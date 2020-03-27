using Model;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repo
{
    public class IRepoImpl : IRepo
    {
        private readonly UserDatabaseContext userDbContext;

        public IRepoImpl(UserDatabaseContext userDbContext)
        {
            this.userDbContext = userDbContext;
        }

        public Task<int> AddEmployee(Employee employee)
        {

            userDbContext.Employee.Add(employee);
            var result = userDbContext.SaveChangesAsync();
            return result;

        }

        public Employee GetEmployee(int id)
        {
            return userDbContext.Employee.Find(id);
        }

        public Task<int> UpdateEmployee(Employee employeeChanges)
        {
            var employee = userDbContext.Employee.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = userDbContext.SaveChangesAsync();
            return result;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee = userDbContext.Employee.Find(id);
            if (employee != null)
            {
                userDbContext.Employee.Remove(employee);
                userDbContext.SaveChanges();
            }
            return employee;

        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return userDbContext.Employee;
        }
    }
}
