//-----------------------------------------------------------------------
// <copyright file="IEmployeeManager.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace Manager
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// IEmployeeManager interface
    /// </summary>
    public interface IEmployeeManager
    {
        /// <summary>
        /// Adds the specified employee
        /// </summary>
        /// <param name="employee">The employee</param>
        /// <returns>The employee</returns>
        Task<int> AddEmployee(Employee employee);

        /// <summary>
        /// Gets the specified employee
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>The employee id</returns>
        Employee GetEmployee(int id);

        /// <summary>
        /// Updates the specified employee
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns>The employee</returns>
        Task<int> UpdateEmployee(Employee employeeChanges);

        /// <summary>
        /// Deletes the specified employee
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>The employee id</returns>
        Employee DeleteEmployee(int id);

        /// <summary>
        ///  Gets all employees
        /// </summary>
        /// <returns>List of all employees</returns>
        IEnumerable<Employee> GetAllEmployees();
    }
}
