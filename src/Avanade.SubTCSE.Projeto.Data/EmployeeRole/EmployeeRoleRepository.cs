using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository;
using Avanade.SubTCSE.Projeto.Data.Base;

namespace Avanade.SubTCSE.Projeto.Data.EmployeeRole
{
    public class EmployeeRoleRepository 
        : BaseRepository<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, string>
        , IEmployeeRoleRepository
    {
    }
}
