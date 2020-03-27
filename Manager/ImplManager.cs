using Model;
using Repository.Repo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class ImplManager : IManager
    {
        private readonly IRepo repository;

        public ImplManager(IRepo repository)
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
