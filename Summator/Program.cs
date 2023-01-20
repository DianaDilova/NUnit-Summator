namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum is equal to " + Summator.Sum(new int[] { 1, 2, 3 }));
            Console.WriteLine("The average numbers is: " + Summator.Average(new int[] { 5, 6, 7 }));

        }
    }
}