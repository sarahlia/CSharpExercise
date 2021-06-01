using System;
using System.IO;
using System.Linq;

namespace Ref
{
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
            
            #region LINQ

            // string path = @"developer/projects/CSharpExercise";
            // ShowLargeFilesWithoutLinq();


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
            
            #region Questions
            
            //Q1
            String first = "TechBeamers";
            String second = "TECHBEAMERS";
            int third;
            third = first.CompareTo(second);
            Console.WriteLine(third); //output: -1
            
            //Q2 -- output: Method 1 \n Method 2
            static bool SomeMethod1()
            {
                Console.WriteLine("Method 1");
                return false;
            }

            static bool SomeMethod2()
            {
                Console.WriteLine("Method 2");
                return true;
            }
            
            if (SomeMethod1() & SomeMethod2())
            {
                Console.WriteLine("the if block has was executed");
            }
            
            #endregion
        }

        private static void ShowLargeFilesWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
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