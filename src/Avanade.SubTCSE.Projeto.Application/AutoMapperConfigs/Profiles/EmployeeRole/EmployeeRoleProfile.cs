using AutoMapper;
using Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole
{
    public class EmployeeRoleProfile : Profile
    {
        public EmployeeRoleProfile()
        {
            CreateMap<EmployeeRoleDto, Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
                .ForCtorParam("roleName", opt => opt.MapFrom(src => src.Cargo));

            CreateMap<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, EmployeeRoleDto>()
                .ForMember(dest => dest.Identificador, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => src.RoleName))
                .ForAllOtherMembers(i => i.Ignore());
        }
    }
}
