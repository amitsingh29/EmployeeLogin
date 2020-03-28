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

    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepository repository;

        public EmployeeManager(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        public Task<int> AddEmployee(Employee employee)
        {
            return this.repository.AddEmployee(employee);
        }

        public Employee GetEmployee(int id)
        {
            return this.repository.GetEmployee(id);
        }

        public Task<int> UpdateEmployee(Employee employeeChanges)
        {
            return this.repository.UpdateEmployee(employeeChanges);
        }

        public Employee DeleteEmployee(int id)
        {
            return this.repository.DeleteEmployee(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.repository.GetAllEmployees();
        }
    }
}
