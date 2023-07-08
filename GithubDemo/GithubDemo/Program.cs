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

            if (inputNumber >= 0)
            {
                Console.WriteLine("Positive!");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
    }
}