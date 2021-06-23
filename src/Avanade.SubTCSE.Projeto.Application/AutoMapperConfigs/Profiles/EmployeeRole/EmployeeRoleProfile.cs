using AutoMapper;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole
{
    public class EmployeeRoleProfile : Profile
    {
        public EmployeeRoleProfile()
        {
            CreateMap<Dtos.EmployeeRole.EmployeeRoleDto, Domain.Agreggates.EmployeeRole.Entities.EmployeeRole>()
                .ForCtorParam("roleName", opt => opt.MapFrom(src => src.Cargo));

            CreateMap<Domain.Agreggates.EmployeeRole.Entities.EmployeeRole, Dtos.EmployeeRole.EmployeeRoleDto>()
                .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => src.RoleName));
        }
    }
}
