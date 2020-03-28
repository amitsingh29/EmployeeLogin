//-----------------------------------------------------------------------
// <copyright file="IEmployeeRepository.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace Repository
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        ///  Adds the specified employee
        /// </summary>
        /// <param name="employee">The employee</param>
        /// <returns>employee id</returns>
        Task<int> AddEmployee(Employee employee);

        /// <summary>
        ///  Getss the specified employee
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>employee id</returns>
        Employee GetEmployee(int id);

        /// <summary>
        ///  Updates the specified employee
        /// </summary>
        /// <param name="employeeChanges">The employeeChanges</param>
        /// <returns>updated employee</returns>
        Task<int> UpdateEmployee(Employee employeeChanges);

        /// <summary>
        ///  Deletes the specified employee
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>employee id</returns>
        Employee DeleteEmployee(int id);

        /// <summary>
        ///  Gets all employees
        /// </summary>
        /// <returns>list of all employees</returns>
        IEnumerable<Employee> GetAllEmployees();
    }
}
