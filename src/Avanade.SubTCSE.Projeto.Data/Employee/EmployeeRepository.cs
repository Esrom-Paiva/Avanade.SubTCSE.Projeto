using Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Repositories;
using Avanade.SubTCSE.Projeto.Data.Base;

namespace Avanade.SubTCSE.Projeto.Data
{
    public class EmployeeRepository 
        : BaseRepository<Domain.Aggregates.Employee.Entities.Employee, string>
        , IEmployeeRepository
    {

    }
}
