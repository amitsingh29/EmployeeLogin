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

    /// <summary>
    /// EmployeeRepository class
    /// </summary>
    public class EmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// The userDbContext
        /// </summary>
        private readonly UserDatabaseContext userDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeRepository"/> class.
        /// </summary>
        /// <param name="userDbContext">The userDbContext</param>
        public EmployeeRepository(UserDatabaseContext userDbContext)
        {
            this.userDbContext = userDbContext;
        }

        /// <summary>
        /// Adds the specified employee
        /// </summary>
        /// <param name="employee">The employee</param>
        /// <returns></returns>
        public Task<int> AddEmployee(Employee employee)
        {

            userDbContext.Employee.Add(employee);
            var result = userDbContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// Gets the specified employee
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns></returns>
        public Employee GetEmployee(int id)
        {
            return userDbContext.Employee.Find(id);
        }

        /// <summary>
        /// Updates the specified employee
        /// </summary>
        /// <param name="employeeChanges">The employeeChanges</param>
        /// <returns></returns>
        public Task<int> UpdateEmployee(Employee employeeChanges)
        {
            var employee = userDbContext.Employee.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = userDbContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// Deletes the specified employee
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets all employees
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetAllEmployees()
        {
            return userDbContext.Employee;
        }
    }
}
