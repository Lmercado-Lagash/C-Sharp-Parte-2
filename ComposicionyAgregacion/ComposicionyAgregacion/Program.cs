using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionyAgregacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee joe = new Employee("Joe Smith", "100 Main Street", "Boston", "MA", "01010");
            Console.WriteLine(joe.ToString());
            joe.Insurance = new InsuranceInfo() { PolicyName = "Vida",PolicyId = "123"};
            Console.WriteLine(joe);

            Manager dave = new Manager("Luis", "La Concepcion 537", "Biobio", "VIII", "430000");
            Console.WriteLine(dave);

            Employee steve = new Manager("Steve", "La Concepcion 537", "Biobio", "VIII", "430000");
            Console.WriteLine(steve);

            Console.WriteLine(joe.DoWork());
            Console.WriteLine("{0} {1}",dave.DoWork(), dave.DoWork("Programming"));



            Console.WriteLine("Steve do work: " + steve.DoWork("Programming"));

            Console.WriteLine("===============================");

            List<Employee> employees = new List<Employee>();
            employees.Add(joe);
            employees.Add(dave);
            employees.Add(steve);

            foreach (Employee e in employees)
            {
                Console.WriteLine(e.DoWork());
            }

        }
    }
}
