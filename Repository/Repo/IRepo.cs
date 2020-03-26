using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repo
{
    interface IRepo
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>Boolean value</returns>
        bool AddEmployee(Employee employee);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean value</returns>
        bool DeleteEmployee(int id);

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns>Get list</returns>
        List<Employee> GetAllEmployee();

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>Boolean value</returns>
        bool UpdateEmployee(Employee employee);
    }
}
