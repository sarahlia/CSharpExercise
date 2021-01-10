using System;
using System.Linq;

namespace Ref
{
    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"{Name} is a {Type} and weighs {Weight}";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            #region Value types
            var x = 5;
            var y = x;

            y += 10;
            ChangeNum(x);

            Console.WriteLine($"x is: {x}");
            Console.WriteLine($"y is: {y}");
            
            #endregion
            
            #region Reference types
            var pet1 = new Pet
            {
                Name = "Fluffy",
                Type = "Dog",
                Weight = 20
            };

            var pet2 = pet1;

            var pet3 = new Pet
            {
                Name = pet1.Name,
                Type = pet1.Type,
                Weight = pet1.Weight
            };
            
            // ChangePetType(pet1);

            pet2.Name = "Fido";

            ChangePetType(pet1);

            Console.WriteLine($"pet1 is {pet1}");
            Console.WriteLine($"pet2 is {pet2}");
            Console.WriteLine($"pet3 is {pet3}");
            
            #endregion
            
            #region Strings
            Console.WriteLine("Strings are immutable.");
            var a = "cheese";
            var b = a;
            b += " pizza";

            Console.WriteLine($"a is: {a}");
            Console.WriteLine($"b is: {b}");
            
            #endregion
            
            #region Nullable types
            int? someNumber = default;
            someNumber = 7;
            Console.WriteLine(someNumber);

            string? someWord = default;
            someWord = "Hi there";
            Console.WriteLine(someWord);

            #endregion
            
            #region Others(LINQ)
            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            // Console.WriteLine(string.Join(" ", squaredNumbers));
            foreach (var numb in squaredNumbers)
            {
                Console.WriteLine(numb.ToString());
            }
            
            #endregion
        }

        public static void ChangeNum(int num)
        {
            num += 7;
            Console.WriteLine($"num is: {num}");
        }

        public static void ChangePetType(Pet aPet)
        {
            aPet.Type = "Cat";
            aPet = new Pet
            {
                Name = "Spiro",
                Type = "Dragon",
                Weight = 40
            };
            Console.WriteLine($"aPet is: {aPet}");
        }
    }
}