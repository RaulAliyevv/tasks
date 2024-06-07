using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Employee
    {
        public string Name { get; }
        public string Surname { get; }
        public int Salary { get; }
        public int Experience { get; }
        public bool HasBachelorDegree { get; }

        public Employee(string name, string surname, int salary, int experience, bool hasBachelorDegree)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            Experience = experience;
            HasBachelorDegree = hasBachelorDegree;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Salary: {Salary}, Experience: {Experience}, Bachelor's Degree: {(HasBachelorDegree ? "Yes" : "No")}";
        }
    }
}
