namespace goto_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Hello, 1");
            Console.WriteLine("Hello, 2");
            Console.WriteLine("Hello, 3!");
            Console.WriteLine("Hello, 4!");
            Console.WriteLine("Hello, 5!");
            Console.WriteLine("Hello, 6!");
            mylabel:
            Console.WriteLine("Hello, 7!");
                ++i;
            if ( i <= 3)
            {
                goto mylabel;
            }
            Console.WriteLine("Hello, 8!");
            Console.WriteLine("Hello, 9!");
            Console.WriteLine("Hello, 10!");
            Console.WriteLine("Hello, 11!");
        }
    }
}