namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            //0 to 9
            int i = 0;
            do
            {
                Console.Write(i + " ");
                i++;
            } while (i < 10);
            Console.WriteLine();

            //9 to 0
            int p = 9;
            do
            {
                Console.Write( p + " ");
                p--;
            }while (p > 0);
            Console.WriteLine();
        }
    }
}