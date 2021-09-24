using Avanade.SubTCSE.Projeto.Data.Repositorys.Base;
using Avanade.SubTCSE.Projeto.Domain.Agreggates.EmployeeRole.Interfaces.Repository;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;

namespace Avanade.SubTCSE.Projeto.Data.Repositorys.EmployeeRole
{
    public class EmployeeRoleRepository
        : BaseRepository<Domain.Agreggates.EmployeeRole.Entities.EmployeeRole, string>
        , IEmployeeRoleRepository
    {
        public EmployeeRoleRepository(IMongoDBContext mongoDBContext)
            :base(mongoDBContext, "employeeRole")
        {

        }
    }
}
