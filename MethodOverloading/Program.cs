namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b) // method add two integers
        {
            return a + b;
        }
        //overload to add decimals
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        //overload to return a string and accept the parameters, returns sum of integers as string
        public static string Add(int a, int b, bool returnSumAsString)
        {
            int sum = a + b;
            if (returnSumAsString)
            {
                return sum.ToString();
            }
            return "Boolean paramter is false, sum not returned as a string.";
            
        }

        public static void Main()
        {
            Console.WriteLine(Add(5, 33));
            Console.WriteLine(Add(2.5m, 3.7m));
            Console.WriteLine(Add(4, 2, true));
            Console.WriteLine(Add(4, 2, false));
        }
    }
}
