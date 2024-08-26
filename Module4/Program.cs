using System.Drawing;
using System.Net.Security;

namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, double Age, string[] favcolors) User;
            
            Console.Write("Enter your name: ");
            User.Name = Console.ReadLine();
            
            Console.Write("Enter yoyr LastName: ");
            User.LastName = Console.ReadLine();
            
            Console.Write("Enter your Login: ");
            User.Login = Console.ReadLine();
            User.LoginLength = User.Login.Length;

            Console.Write("Do you have a pet? Y or N: ");
            User.HasPet = Console.ReadLine() == "Y" ? true : false;

            Console.Write("Enter your age: ");
            User.Age = double.Parse(Console.ReadLine());

            Console.WriteLine("Now enter your three favourite colours");
            User.favcolors = new string[3];
            string[] colrs = { "first", "second", "third" };
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter {colrs[i]} favourite colour: ");
                User.favcolors[i] = Console.ReadLine();
            }

            Console.WriteLine(User.Name);
            Console.WriteLine(User.LastName);
            Console.WriteLine(User.Login);
            Console.WriteLine(User.LoginLength);
            Console.WriteLine(User.HasPet);
            Console.WriteLine(User.Age);

            Console.ReadKey();
        }
    }
}
