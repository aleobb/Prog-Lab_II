using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_IComparable
{

    /// https://www.dotnetperls.com/icomparable
    /// https://support.microsoft.com/es-es/help/320727/how-to-use-the-icomparable-and-icomparer-interfaces-in-visual-c


    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Name = "Steve", Salary = 10000 });
            list.Add(new Employee() { Name = "Janet", Salary = 10000 });
            list.Add(new Employee() { Name = "Andrew", Salary = 10000 });
            list.Add(new Employee() { Name = "Bill", Salary = 500000 });
            list.Add(new Employee() { Name = "Lucy", Salary = 8000 });
            list.Add(new Employee() { Name = "Lucy", Salary = 8001 });
            list.Add(new Employee() { Name = "Lucy", Salary = 7999 });

            // Uses IComparable.CompareTo()
            list.Sort();

            // Uses Employee.ToString
            foreach (Employee element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("--Fin--");
            Console.ReadKey();

        }
    }
}
