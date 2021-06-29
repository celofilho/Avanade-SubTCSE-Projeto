using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.Employee
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Dtos.Employee.EmployeeDto, Domain.Agreggates.Employee.Entities.Employee>()
               .ConstructUsing((ctor,res) => {
                   return new Domain.Agreggates.Employee.Entities.Employee(
                       firstName: ctor.PrimeiroNome,
                       surName: ctor.SobreNome,
                       birthDay: ctor.Aniversario,
                       active: ctor.Ativo,
                       salary: ctor.Salario,
                       employeeRole: res.Mapper.Map<Domain.Agreggates.EmployeeRole.Entities.EmployeeRole>(ctor.Cargo));
            })
            .ForAllOtherMembers(i => i.Ignore());

            CreateMap<Domain.Agreggates.Employee.Entities.Employee, Dtos.Employee.EmployeeDto>()
                .ForMember(dest => dest.Identificador, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PrimeiroNome, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.SobreNome, opt => opt.MapFrom(src => src.SurName))
                .ForMember(dest => dest.Aniversario, opt => opt.MapFrom(src => src.BirthDay))
                .ForMember(dest => dest.Ativo, opt => opt.MapFrom(src => src.Active))
                .ForMember(dest => dest.Salario, opt => opt.MapFrom(src => src.Salary))
                .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => src.EmployeeRole))
                .ForAllOtherMembers(i => i.Ignore());





        }
    }
}
