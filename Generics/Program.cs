namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max Number");

            int output = FindMaxNumber.MaxIntegerNumber(10, 3, 5);
            Console.WriteLine(output);
        }
    }
}