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
                Console.WriteLine("\nSelect option \n1.Find Integer Max \n2.Find Float Max \n3.Find String Max \n4.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        int result = FindMaximum.FindMax(23, 25, 27);
                        Console.WriteLine("Max Integer is: " + result);
                        break;
                    case 2:
                        float result1 = FindMaximum.FindMaxFloat(22.4f, 23.4f, 21.5F);
                        Console.WriteLine("Max Float is: " + result1);
                        break;
                    case 3:
                        string result2 = FindMaximum.FindMaxString("Apple","Banana","Peach");
                        Console.WriteLine("Max String is: " + result2);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}