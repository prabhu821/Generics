namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Find Max Number");
                Console.WriteLine("\nEnter your choice \n1.Max Integer  \n2.Max Float \n3.Max String \n4.Array Max \n5.Exit");
                Console.WriteLine("\nEnter option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        int output = FindMaxNumber.MaxIntegerNumber(10, 3, 5);
                        Console.WriteLine(output);
                        break;
                    case 2:
                        double output1 = FindMaxNumber.MaxFloatNumber(10.2, 3.3, 5.4);
                        Console.WriteLine(output1);
                        break;
                    case 3:
                        string stringoutput = FindMaxNumber.MaxString("Strawberry", "Apple", "Banana");
                        Console.WriteLine(stringoutput);
                        break;
                    case 4:
                        int[] intArray = { 112, 244, 534, 453 };
                        GenericMaximum<int> genric = new GenericMaximum<int>(intArray);
                        genric.PrintMaxValue();

                        double[] doubleArray = { 11.2, 24.4, 5.34, 45.3 };
                        GenericMaximum<double> genricDouble = new GenericMaximum<double>(doubleArray);
                        genricDouble.PrintMaxValue();

                        string[] stringArray = { "112", "244", "534", "453" };
                        GenericMaximum<string> genricString = new GenericMaximum<string>(stringArray);
                        genricString.PrintMaxValue();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}