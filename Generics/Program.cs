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
                Console.WriteLine("\nSelect option \n1.Find Integer Max \n2.Find Float Max \n3.Find String Max " +
                    "\n4.Generics Maximum \n5.Extend Generic Maximum \n6.Exit");
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
                    case 4:
                        GenericsMaximum<int> obj = new GenericsMaximum<int>(23, 50, 5);
                        int result3 = obj.FindMaxUsingGenerics(23, 50, 5);
                        Console.WriteLine(result3);
                        GenericsMaximum<float> obj1 = new GenericsMaximum<float>(23.25f, 50.25f, 50.3f);
                        float result4 = obj1.FindMaxUsingGenerics(23.25f, 50.25f, 50.3f);
                        Console.WriteLine(result4);
                        break;
                    case 5:
                        GenericMaximum<string> max = new GenericMaximum<string>("Apple", "Peach", "Banana", "Grapes");
                        string maxString = max.GetMax();
                        Console.WriteLine(maxString);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}