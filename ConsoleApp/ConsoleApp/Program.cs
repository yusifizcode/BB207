namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            bool check = true;
            do
            {
                Console.WriteLine("1. Employee əlavə et" +
                                  "\n2. Bütün işçilərə bax" +
                                  "\n3. Maaş aralığına görə işçiləri axtarış et" +
                                  "\n0. Proqramı bitir");

                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":

                        Console.WriteLine("Ishcinin adini daxil et: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ishcinin soyadini daxil et:");
                        string surname = Console.ReadLine();

                        string ageStr;
                        byte age;
                        do
                        {
                            Console.WriteLine("Ishcinin yashini daxil et:");
                            ageStr = Console.ReadLine();
                        } while (!byte.TryParse(ageStr, out age) && age >= 0);

                        Console.WriteLine("Ishcinin departamentini daxil et: ");
                        string departmentName = Console.ReadLine();

                        string salaryStr;
                        double salary;
                        do
                        {
                            Console.WriteLine("Ishcinin maashini daxil et: ");
                            salaryStr = Console.ReadLine();
                        } while (!double.TryParse(salaryStr, out salary) && salary >= 0);

                        Employee employee = new Employee(name, surname, age, departmentName, salary);
                        department.AddEmployee(employee);
                        break;
                    case "2":
                        Employee[] employees = department.GetAllEmployees();

                        for (int i = 0; i < employees.Length; i++)
                        {
                            employees[i].ShowEmployeeInfo();
                        }
                        break;
                    case "3":

                        string minSalaryStr;
                        int minSalary;
                        do
                        {
                            Console.WriteLine("Minimum maash daxil et: ");
                            minSalaryStr = Console.ReadLine();
                        } while (!int.TryParse(minSalaryStr, out minSalary) && minSalary >= 0);

                        string maxSalaryStr;
                        int maxSalary;
                        do
                        {
                            Console.WriteLine("Maximum maash daxil et: ");
                            maxSalaryStr = Console.ReadLine();
                        } while (!int.TryParse(maxSalaryStr, out maxSalary) && maxSalary >= 0);


                        Employee[] filteredEmployees = department.GetAllEmployeesBySalary(minSalary, maxSalary);

                        for (int i = 0; i < filteredEmployees.Length; i++)
                        {
                            filteredEmployees[i].ShowEmployeeInfo();
                        }
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin !!");
                        break;
                }
            } while (check);

        }
    }
}