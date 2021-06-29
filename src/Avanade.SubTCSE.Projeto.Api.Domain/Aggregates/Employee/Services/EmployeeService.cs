using Avanade.SubTCSE.Projeto.Api.Domain.Aggregates.Employee.Interfaces.services;
using System;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Api.Domain.Aggregates.Employee.Services
{
    public class EmployeeService : IEmployeeService
    {
        public async Task<Entities.Employee> AddEmployee(Entities.Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
