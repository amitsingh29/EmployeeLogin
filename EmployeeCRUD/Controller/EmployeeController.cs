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

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeManager manager;
        public EmployeeController(IEmployeeManager manager)
        {
            this.manager = manager;
        }

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

        [Route("GetEmployee")]
        [HttpGet]
        public Employee GetEmployee(int id)
        {
            return this.manager.GetEmployee(id);
        }

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

        [HttpDelete]
        [Route("DeleteEmployee")]
        public Employee DeleteEmployee(int id)
        {
            return this.manager.DeleteEmployee(id);
        }

        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.manager.GetAllEmployees();
        }
    }
}
