namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Entitites
{
    public record EmployeeRole
    {

        public string Id { get; private set; }

        public string RoleName { get; init; }

        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }
    }
}
