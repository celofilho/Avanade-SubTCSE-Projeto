using System;

namespace Avanade.SubTCSE.Projeto.Domain.Agreggates.Employee.Entities
{
    public record Employee : BaseEntity<string>
    {
        public Employee(string firstName,
            string surName, DateTime birthDay,
            bool active,
            decimal salary,
            EmployeeRole.Entities.EmployeeRole employeeRole)
        {
            FirstName = firstName;
            SurName = surName;
            BirthDay = birthDay;
            Active = active;
            Salary = salary;
            EmployeeRole = employeeRole;
        }

        public string FirstName { get; init; }

        public string SurName { get; init; }

        public DateTime BirthDay { get; init; }

        public bool Active { get; init; }

        public decimal Salary { get; init; }

        public EmployeeRole.Entities.EmployeeRole EmployeeRole { get; init; }

    }
}
