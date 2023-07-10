namespace GithubDemo;
internal class Program
{
    static void Main(string[] args)
    {
        int maxCount = 0, counter = 1, number, oldNumber = 0, findNumber = -1;
        do
        {
            Console.Write("Son kiriting : ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("To'g'ri formatdagi son kiriting : ");
            }
            if (oldNumber == number)
            {
                counter++;
            }
            else
            {
                if (maxCount <= counter)
                {
                    maxCount = counter;
                    findNumber = oldNumber;
                }
                oldNumber = number;
                counter = 1;
            }
        }
        while (number != 0);
        Console.WriteLine("Bu sonlar ichida " + findNumber + " soni " + maxCount + " marta kiritildi.");
    }
}