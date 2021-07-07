using Avanade.SubTCSE.Projeto.Data.Repositorys.Base;
using Avanade.SubTCSE.Projeto.Domain.Agreggates.Employee.Interfaces.Repository;

namespace Avanade.SubTCSE.Projeto.Data.Repositorys.Employee
{
    public class EmployeeRepository
        : BaseRepository<Domain.Agreggates.Employee.Entities.Employee, string>
        , IEmployeeRepository
    {

    }
}
