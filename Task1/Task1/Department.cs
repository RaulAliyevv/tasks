using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Department
    {
        public string Name { get; }
        public int EmployeeLimit { get; }
        public double Budget { get; }
        public int RequiredExperience { get; }
        public bool IsBachelorDegreeRequired { get; }
        public List<Employee> Employees { get; } = new List<Employee>();

        public Department(string name, int employeeLimit, int budget, int requiredExperience, bool isBachelorDegreeRequired)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
            Budget = budget;
            RequiredExperience = requiredExperience;
            IsBachelorDegreeRequired = isBachelorDegreeRequired;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Employee Limit: {EmployeeLimit}, Budget: {Budget}, Required Experience: {RequiredExperience}, Bachelor's Degree Required: {(IsBachelorDegreeRequired ? "Yes" : "No")}";
        }
    }
}
