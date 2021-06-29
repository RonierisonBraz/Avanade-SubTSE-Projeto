using Avanade.SubTCSE.Projeto.Api.Domain.Aggregates.Employee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Api.Domain.Aggregates.EmployeeRole.Entities
{

    public record EmployeeRole : BaseEntity<string>
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public EmployeeRole(string roleName)
        {
            RoleName = roleName;
        }
        
        public string RoleName { get; init; }

    }

}
