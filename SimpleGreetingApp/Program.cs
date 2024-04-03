
namespace SimpleGreetingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Print(name);
        }

        private static void Print(string? name)
        {
            Console.WriteLine("Hello {0}", name);
        }
    }
}
