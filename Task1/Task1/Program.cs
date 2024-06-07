namespace Task1
{
    internal class Program
    {

        static List<Employee> employees = new List<Employee>();
        static List<Department> departments = new List<Department>();

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Add Department");
                Console.WriteLine("3. Delete Department");
                Console.WriteLine("4. Add Employee to Department");
                Console.WriteLine("5. Show All Employees Info");
                Console.WriteLine("6. Show All Departments Info");
                Console.WriteLine("7. Quit");

                Console.Write("Choose:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        AddDepartment();
                        break;
                    case "3":
                        DeleteDepartment();
                        break;
                    case "4":
                        AddEmployeeToDepartment();
                        break;
                    case "5":
                        ShowAllEmployeesInfo();
                        break;
                    case "6":
                        ShowAllDepartmentsInfo();
                        break;
                    case "7":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Secim sehvdir.");
                        break;
                }
            }
        }

        private static void AddEmployee()
        {
            AddEmployee(employees);
        }

        static void AddEmployee(List<Employee> employees)
        {
            Console.Write("Iscinin name: ");
            string name = Console.ReadLine();

            Console.Write("Iscinin Surname: ");
            string surname = Console.ReadLine();

            int salary = GetIntegerInput("Iscinin Salary: ");
            if (salary == -1)
                return;

            int experience = GetIntegerInput("Iscinin Experience: ");
            if (experience == -1)
                return;

            bool hasBachelorDegree = ((bool)GetYesNoInput("Does the Employee have a Bachelor's Degree (yes/no): "));
            if (hasBachelorDegree == null)
                return;

            Employee newEmployee = new(name, surname, salary, experience, hasBachelorDegree);
            employees.Add(newEmployee);
            Console.WriteLine("Employee added successfully!");
        }

        static void AddDepartment()
        {
            Console.Write("Enter Department Name: ");
            string name = Console.ReadLine();

            if (departments.Exists(d => d.Name == name))
            {
                Console.WriteLine("Department with the same name already exists!");
                return;
            }

            int employeeLimit = GetIntegerInput("Enter Department Employee Limit: ");
            if (employeeLimit == -1)
                return;

            int budget = GetIntegerInput("Enter Department Budget: ");
            if (budget == -1)
                return;

            int requiredExperience = GetIntegerInput("Enter Required Experience for the Department: ");
            if (requiredExperience == -1)
                return;

            if ((bool)GetYesNoInput("Is Bachelor's Degree Required for the Department (yes/no): ") != null)
            {
                Department newDepartment = new(name, employeeLimit, budget, requiredExperience, ((bool)GetYesNoInput("Is Bachelor's Degree Required for the Department (yes/no): ")));
                departments.Add(newDepartment);
                Console.WriteLine("Department added successfully!");
            }
        }

        static void DeleteDepartment()
        {
            Console.Write("Enter Department Name to delete: ");
            string name = Console.ReadLine();

            Department department = departments.Find(d => d.Name == name);
            if (department == null)
            {
                Console.WriteLine("Department not found!");
                return;
            }

            departments.Remove(department);
            Console.WriteLine("Department deleted successfully!");
        }

        static void AddEmployeeToDepartment()
        {
            Console.Write("Enter Department Name: ");
            string departmentName = Console.ReadLine();

            Department department = departments.Find(d => d.Name == departmentName);
            if (department == null)
            {
                Console.WriteLine("Department not found!");
                return;
            }

            Console.Write("Enter Employee Name to add to the department: ");
            string employeeName = Console.ReadLine();

            Employee employee = employees.Find(e => e.Name == employeeName);
            if (employee == null)
            {
                Console.WriteLine("Employee not found!");
                return;
            }

            if (department.Employees.Count >= department.EmployeeLimit)
            {
                Console.WriteLine("Department has reached its employee limit!");
                return;
            }

            department.Employees.Add(employee);
            Console.WriteLine("Employee added to department successfully!");
        }

        static void ShowAllEmployeesInfo()
        {
            Console.WriteLine("All Employees:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }

        static void ShowAllDepartmentsInfo()
        {
            Console.WriteLine("All Departments:");
            foreach (var department in departments)
            {
                Console.WriteLine(department.ToString());
            }
        }


        static int GetIntegerInput(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (!int.TryParse(Console.ReadLine(), out int result))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
                else
                {
                    return result;
                }
            }
        }

        static bool? GetYesNoInput(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "yes")
                {
                    return true;
                }
                else if (input == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter 'yes' or 'no'.");
                }
            }
        }
    }

}