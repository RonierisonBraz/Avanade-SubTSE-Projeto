using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Api.Domain.Aggregates.Employee.Interfaces.services
{
    interface IEmployeeService
    {
       Task<Entities.Employee> AddEmployee(Entities.Employee employee);
    }
}
