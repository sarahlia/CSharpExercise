using System;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Scott"},
                new Employee {Id = 2, Name = "Chris"}
            };

            var sales = new List<Employee>
            {
                new Employee {Id = 3, Name = "Alex"}
            };

            foreach (var person in developers)
            {
                Console.WriteLine(person.Name);
            }
            
            // foreach statement the hard way:
            // IEnumerator<Employee> enumerator = developers.GetEnumerator();
            // while (enumerator.MoveNext())
            // {
            //     Console.WriteLine(enumerator.Current.Name);
            // }
            
        }
    }
}