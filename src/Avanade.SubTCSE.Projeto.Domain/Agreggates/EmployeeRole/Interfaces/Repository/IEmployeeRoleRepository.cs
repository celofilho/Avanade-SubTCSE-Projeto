using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Agreggates.EmployeeRole.Interfaces.Repository
{
    public interface IEmployeeRoleRepository
    {
        Task<Entities.EmployeeRole> AddEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
