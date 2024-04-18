using Reflection.Models;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Employee employee = new Employee();

            foreach (Type type in assembly.GetTypes())
            {
                if (type.Name == "Employee")
                {
                    Console.WriteLine("Employee: ");
                    Console.WriteLine("Properties :");

                    foreach (PropertyInfo propertyInfo in type.GetProperties())
                    {
                        Console.WriteLine("\t" + propertyInfo.Name);
                    }


                    Console.WriteLine("Fields :");
                    foreach (FieldInfo fieldInfo in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static))
                    {
                        if (fieldInfo.Name == "_id")
                        {
                            fieldInfo.SetValue(employee, 99);
                        }

                        Console.WriteLine("\t" + fieldInfo.Name + " - " + fieldInfo.GetValue(employee));
                    }


                    Console.WriteLine("Methods :");
                    foreach (MethodInfo methodInfo in type.GetMethods())
                    {
                        Console.WriteLine("\t" + methodInfo.Name);
                    }
                }
            }
        }
    }
}