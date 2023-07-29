namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string? input1 = Console.ReadLine();
            Console.WriteLine($"Hello {input1},");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine( $"Ënjoy your day Mr. {input1}" );
            Console.ReadKey();

        }
    }
}