using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Api.Domain.Aggregates.EmployeeRole.Interfaces.Services
{
    public interface IEmployeeRoleService
    {
        Task<Entities.EmployeeRole> AddEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
