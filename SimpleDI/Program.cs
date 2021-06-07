using System;

namespace SimpleDI
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User("Tim");
            user1.ChangeUserName("Robert");

            Console.ReadKey();
        }
    }
}