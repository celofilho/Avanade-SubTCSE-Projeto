using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Agreggates.EmployeeRole.Interfaces.Services
{
    public interface IEmployeeRoleService
    {
       Task<Entities.EmployeeRole> AddEmployeeRoleAsync(Entities.EmployeeRole employeeRole);

        Task<List<Entities.EmployeeRole>> GetAllAsync();

        Task<Entities.EmployeeRole> GetById(string Id);

        Task<bool> DeleteById(string Id);

    }
}
