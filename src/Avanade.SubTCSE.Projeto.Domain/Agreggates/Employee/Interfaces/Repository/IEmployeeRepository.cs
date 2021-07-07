using Avanade.SubTCSE.Projeto.Domain.Base.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Agreggates.Employee.Interfaces.Repository
{
    public interface IEmployeeRepository : IBaseRepository<Domain.Agreggates.Employee.Entities.Employee, string>
    {
       
    }
}
