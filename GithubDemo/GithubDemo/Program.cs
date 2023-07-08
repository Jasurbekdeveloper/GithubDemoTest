namespace GithubDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                break;
            }

            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("Even!");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
