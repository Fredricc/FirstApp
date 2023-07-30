namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name");
            //string? input1 = Console.ReadLine();
            //Console.WriteLine($"Hello {input1},");

            //Console.ReadKey();
            //Console.Clear();
            //Console.WriteLine( $"Enjoy your day Mr. {input1}" );

            //Variable to store the grade letter of a student.
            char gradeLetter = 'A';

            //find out description based on gradeLetter.
            string gradeDescription;
            switch (gradeLetter)
            {
                case 'O': gradeDescription = "Outstanding"; break;
                case 'A': gradeDescription = "Excellent"; break;
                case 'B': gradeDescription = "Good"; break;
                case 'C': gradeDescription = "Average"; break;
                case 'F': gradeDescription = "Fail"; break;
                default: gradeDescription = "None"; break;
            }
            Console.WriteLine(gradeDescription);
            Console.ReadKey();

        }
    }
}