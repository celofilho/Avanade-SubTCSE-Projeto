using Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole;
using Avanade.SubTCSE.Projeto.Application.Services.EmployeeRole;
using Avanade.SubTCSE.Projeto.Data.Repositorys.Base.MongoDB;
using Avanade.SubTCSE.Projeto.Data.Repositorys.EmployeeRole;
using Avanade.SubTCSE.Projeto.Domain.Agreggates.EmployeeRole.Entities;
using Avanade.SubTCSE.Projeto.Domain.Agreggates.EmployeeRole.Interfaces.Repository;
using Avanade.SubTCSE.Projeto.Domain.Agreggates.EmployeeRole.Interfaces.Services;
using Avanade.SubTCSE.Projeto.Domain.Agreggates.EmployeeRole.Services;
using Avanade.SubTCSE.Projeto.Domain.Agreggates.EmployeeRole.Validators;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Avanade.SubTCSE.Projeto.CrossCutting
{
    public static class DependencyInjection
    {
        public static void AddRegisterDependenciesInjections(this IServiceCollection services) 
        {
            services.AddAutoMapper(typeof(Application.AutoMapperConfigs.Profiles.Configs));
            
            services.AddSingleton<IMongoDBContext, MongoDBContext>();

            services.AddScoped<IEmployeeRoleAppService, EmployeeRoleAppService>();

            services.AddScoped<IEmployeeRoleService, EmployeeRoleService>();

            services.AddScoped<IEmployeeRoleRepository, EmployeeRoleRepository>();

            services.AddTransient<IValidator<EmployeeRole>, EmployeeRoleValidator>();
        }
    }
}
