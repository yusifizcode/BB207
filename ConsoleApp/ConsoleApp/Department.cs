namespace ConsoleApp
{
    internal class Department
    {
        public Employee[] Employees = { }; // 0 -> 1

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }

        public Employee[] GetAllEmployees()
        {
            return Employees;
        }

        public Employee[] GetAllEmployeesBySalary(int minSalary, int maxSalary)
        {
            Employee[] employees = { };
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Salary >= minSalary && Employees[i].Salary <= maxSalary)
                {
                    Array.Resize(ref employees, employees.Length + 1);
                    employees[employees.Length - 1] = Employees[i];
                }
            }

            return employees;
        }

    }
}
