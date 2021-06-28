namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole: BaseEntity<string>
    {
        public string RoleName { get; init; }

        public EmployeeRole(string roleName)
        {
            RoleName = roleName;
        }

        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }
    }
}
