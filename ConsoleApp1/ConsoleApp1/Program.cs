namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int x = int.Parse(Console.ReadLine());
            int y = fibonacci(x - 1);

            if (y < 0)
            {
                Console.WriteLine("Error!");
            }
            else
                Console.WriteLine(y);

            Console.ReadKey();
        }
        static int fibonacci(int x)
        {
            if (x <= 1)
                return x;
            else if (x > 1)
                return fibonacci(x - 1) + fibonacci(x - 2);
            else
                return -1;
        }
    }
}
