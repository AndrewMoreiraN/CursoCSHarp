using System;

namespace Exercicio8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Room[] rooms = new Room[10];

            Console.Write("How many rooms will be rented? ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Rent #{i + 1}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Student novo = new Student(name, email);
                rooms[room] = new Room(novo, room);
            }

            Console.WriteLine("Busy rooms:");
            foreach (Room item in rooms)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
}