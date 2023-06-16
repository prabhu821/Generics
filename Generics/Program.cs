namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics!");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect option \n1.Find Integer Max \n2.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        int result = FindMaximum.FindMax(23, 25, 27);
                        Console.WriteLine("Max Integer is: " + result);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}