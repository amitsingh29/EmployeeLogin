//-----------------------------------------------------------------------
// <copyright file="EmployeeRepository.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace Repository
{
    using Model;
    using Repository.Context;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly UserDatabaseContext userDbContext;

        public EmployeeRepository(UserDatabaseContext userDbContext)
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
