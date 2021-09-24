using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Agreggates.Employee.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<Employee.Entities.Employee> AddEmployeeAsync(Entities.Employee employee);
    }
}
