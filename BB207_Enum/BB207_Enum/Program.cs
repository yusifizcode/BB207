using Core.Enums;
using Core.Models;

namespace BB207_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();

            Employee employee = new Employee();
            employee.Name = "Fatime";
            employee.Surname = "Eliyeva";
            employee.Position = "Dizayner";

            Employee employee1 = new Employee();
            employee1.Name = "Almaz";
            employee1.Surname = "Heyderli";
            employee1.Position = "Backend";

            department.AddEmployee(employee);
            department.AddEmployee(employee1);


            //foreach (var item in department.GetAllEmployees())
            //{
            //    Console.WriteLine(item);
            //}

            Employee newEmployee = new Employee();
            newEmployee.Name = "Fatime";
            newEmployee.Surname = "Eliyeva";
            newEmployee.Position = "Backend";

            department.UpdateEmployee(1, newEmployee);

            //Console.WriteLine(department.GetEmployee(1));

            Employee employee2 = new Employee();
            employee2.Name = "Mine";
            employee2.Surname = "Memmedli";
            employee2.Position = "Ishsiz";

            department.AddEmployee(employee2);


            //department.RemoveEmployee(1);





            Console.WriteLine("1. Ishsiz\n" +
                              "2. Backend\n" +
                              "3. Frontend\n" +
                              "4. Dizayner");

            Console.WriteLine("Choose one: ");
            string answerStr = Console.ReadLine();
            int answerInt = int.Parse(answerStr);
            foreach (var item in department.GetEmployeesByPosition((Position)answerInt)) // Position.Frontend
            {
                Console.WriteLine(item);
            }


        }
    }
}