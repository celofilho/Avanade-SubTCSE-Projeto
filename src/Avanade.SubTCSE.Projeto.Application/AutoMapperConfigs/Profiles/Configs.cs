using Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.Employee;
using Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles
{
    public static class Configs
    {
        public static AutoMapper.MapperConfiguration RegisterMappings() =>
            new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true;
                
                cfg.AddProfile<EmployeeRoleProfile>();

                cfg.AddProfile<EmployeeProfile>();
            });
    }
}
