namespace GithubDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

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