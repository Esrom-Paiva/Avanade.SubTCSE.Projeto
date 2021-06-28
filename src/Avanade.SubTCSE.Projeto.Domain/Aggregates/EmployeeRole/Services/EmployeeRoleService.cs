using System;
using System.Threading.Tasks;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Services;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Services
{
    public class EmployeeRoleService : IEmployeeRoleService
    {
        public Task<EmployeeRole.Entities.EmployeeRole> AddEmployeeRole(EmployeeRole.Entities.EmployeeRole employeeRole)
        {
            throw new NotImplementedException();
        }
    }
}
