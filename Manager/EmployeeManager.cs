//-----------------------------------------------------------------------
// <copyright file="EmployeeManager.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace Manager
{
    using Model;
    using Repository;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// EmployeeManager class
    /// </summary>
    public class EmployeeManager : IEmployeeManager
    {
        /// <summary>
        /// The repository
        /// </summary>
        private readonly IEmployeeRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeManager"/> class.
        /// </summary>
        /// <param name="repository">The repository</param>
        public EmployeeManager(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Adds the specified employee
        /// </summary>
        /// <param name="employee">The employee</param>
        /// <returns></returns>
        public Task<int> AddEmployee(Employee employee)
        {
            return this.repository.AddEmployee(employee);
        }

        /// <summary>
        /// Gets the specified employee
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns></returns>
        public Employee GetEmployee(int id)
        {
            return this.repository.GetEmployee(id);
        }

        /// <summary>
        /// Updates the specified employee
        /// </summary>
        /// <param name="employeeChanges">The employeeChanges</param>
        /// <returns></returns>
        public Task<int> UpdateEmployee(Employee employeeChanges)
        {
            return this.repository.UpdateEmployee(employeeChanges);
        }

        /// <summary>
        /// Deletes the specified employee
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns></returns>
        public Employee DeleteEmployee(int id)
        {
            return this.repository.DeleteEmployee(id);
        }

        /// <summary>
        /// The list of all employees
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.repository.GetAllEmployees();
        }
    }
}
