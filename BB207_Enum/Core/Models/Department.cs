using Core.Enums;

namespace Core.Models
{
    public class Department
    {
        private static int _id;
        public int Id { get; set; }

        public string Name { get; set; }

        public Department()
        {
            _id++;
            Id = _id;
            _employees = new Employee[] { };
        }

        private Employee[] _employees;


        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref _employees, _employees.Length + 1);
            _employees[_employees.Length - 1] = employee;
        }

        public Employee[] GetAllEmployees()
        {
            return _employees;
        }

        public Employee GetEmployee(int id)
        {
            foreach (Employee emp in _employees)
            {
                if (emp.Id == id)
                {
                    return emp;
                }
            }

            return null;
        }


        public void RemoveEmployee(int id)
        {
            Employee[] newEmployees = { };
            foreach (Employee emp in _employees)
            {
                if (emp.Id != id)
                {
                    Array.Resize(ref newEmployees, newEmployees.Length + 1);
                    newEmployees[newEmployees.Length - 1] = emp;
                }
            }

            _employees = newEmployees;
        }


        public void UpdateEmployee(int id, Employee employee)
        {
            foreach (Employee emp in _employees)
            {
                if (emp.Id == id)
                {
                    emp.Name = employee.Name;
                    emp.Surname = employee.Surname;
                    emp.Position = employee.Position;
                }
            }
        }


        public Employee[] GetEmployeesByPosition(Position position)
        {
            Employee[] filteredEmployees = { };

            foreach (Employee employee in _employees)
            {
                if (employee.Position.ToLower() == position.ToString().ToLower())
                {
                    Array.Resize(ref filteredEmployees, filteredEmployees.Length + 1);
                    filteredEmployees[filteredEmployees.Length - 1] = employee;
                }
            }

            return filteredEmployees;
        }

    }
}
