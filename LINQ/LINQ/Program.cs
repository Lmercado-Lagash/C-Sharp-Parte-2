using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //var primes = new List<int> { 1, 2, 3, 5, 7, 11, 13, 17, 19, 23 };
            //var query = from valor in primes
            //            where valor < 13
            //            select valor;
            //foreach (var valor in query)
            //    Console.WriteLine(valor);

            //var methodQuery = primes.Where(x => x < 13);

            //foreach (var valor2 in methodQuery)
            //    Console.WriteLine(valor2);

            var query2 = from method in typeof(double).GetMethods()
                         orderby method.Name
                         group method by method.Name into groups
                         select new { MethodName = groups.Key, NumberOfOverloads = groups.Count() };
            foreach (var item in query2)
                Console.WriteLine(item);

            var listOne = Enumerable.Empty<int>();
            var listTwo = Enumerable.Range(1, 20);

            bool listOneEmpty = listOne.Any();
            bool listTwoEmpty = listTwo.Any();

            Console.WriteLine("Lista uno tiene miembros? " + listOneEmpty + "lista dos tiene miembros? " + listTwoEmpty);

            Console.WriteLine("Lista dos tiene el 12? " + listTwo.Contains(12) + "Lista dos tiene el 30? " + listTwo.Contains(30));

            var bigList = Enumerable.Range(1, 20);
            var littleList = bigList.Take(5).Select(x => x * 10);

            foreach (var i in littleList)
                Console.WriteLine(i);

            string[] postalCodes = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL" };

            string[] states = { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Deleware", "Florida" };

            var statesWithCodes = postalCodes.Zip(states, (code, state) => code + ": " + state);

            foreach (var stateWithCode in statesWithCodes)
            {
                Console.WriteLine(stateWithCode);
            }

        }


    }
}
