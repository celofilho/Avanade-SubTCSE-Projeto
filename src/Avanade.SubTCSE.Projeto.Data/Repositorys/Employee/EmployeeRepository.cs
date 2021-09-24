using Avanade.SubTCSE.Projeto.Data.Repositorys.Base;
using Avanade.SubTCSE.Projeto.Domain.Agreggates.Employee.Interfaces.Repository;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;

namespace Avanade.SubTCSE.Projeto.Data.Repositorys.Employee
{
    public class EmployeeRepository
        : BaseRepository<Domain.Agreggates.Employee.Entities.Employee, string>
        , IEmployeeRepository
    {
        public EmployeeRepository(IMongoDBContext mongoDBContext)
           : base(mongoDBContext, "employee")
        {

        }
    }
}
