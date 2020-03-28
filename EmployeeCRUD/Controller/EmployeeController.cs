//-----------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace EmployeeCRUD.Controller
{
    using Manager;
    using Microsoft.AspNetCore.Mvc;
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// EmployeeController class
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeManager manager;
        public EmployeeController(IEmployeeManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        ///  Adds the employee
        /// </summary>
        /// <param name="employee">The model class employee</param>
        /// <returns>The async result</returns>
        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Model.Employee employee)
        {
            var result = await this.manager.AddEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        ///  Gets the employee
        /// </summary>
        /// <param name="id">The model class employee id</param>
        /// <returns>The employee id</returns>
        [Route("GetEmployee")]
        [HttpGet]
        public Employee GetEmployee(int id)
        {
            return this.manager.GetEmployee(id);
        }

        /// <summary>
        /// Updates the employee
        /// </summary>
        /// <param name="employeeChanges">The model class employeeChanges</param>
        /// <returns>Th async result</returns>
        [Route("UpdateEmployee")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Employee employeeChanges)
        {
            var result = await this.manager.UpdateEmployee(employeeChanges);
            if (result == 1)
            {
                return this.Ok(employeeChanges);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Deletes the particular employee
        /// </summary>
        /// <param name="id">The model class employee id</param>
        /// <returns>The id</returns>
        [HttpDelete]
        [Route("DeleteEmployee")]
        public Employee DeleteEmployee(int id)
        {
            return this.manager.DeleteEmployee(id);
        }

        /// <summary>
        /// Gets all the employees
        /// </summary>
        /// <returns>List </returns>
        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.manager.GetAllEmployees();
        }
    }
}
