
namespace MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers: ");

            Console.WriteLine("First number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Third number: ");
            int c = int.Parse(Console.ReadLine());

            int max = MaxNumber(a, b);
            max = MaxNumber(max, c);

            Console.WriteLine($"the maximal is {max}");
        }

        internal static int MaxNumber(int a, int b)
        {
           return a > b ? a : b;
        }
    }
}
