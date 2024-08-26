namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();

            Console.WriteLine("Your name contains next letters in reversed order:");
            //foreach (var lt in name)
            //{
            //    Console.Write(lt + " ");
            //}

            for (int i = name.Length; i > 0; i--)
            {
                Console.Write(name[i - 1] + " ");
            }
            
            Console.WriteLine($"The last one letter in your name is {name[name.Length - 1]}");

            Console.ReadKey();
        }
    }
}
