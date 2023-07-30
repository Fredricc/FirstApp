namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! For Loop");

            //0 to 9
            ;
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < i; j++)
                { Console.Write(j+" "); }
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            //9 to 0
           for (int p = 9; p > 0; p--)
            {
                Console.Write(p + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
            //Console.ReadKey();
        }
    }
}