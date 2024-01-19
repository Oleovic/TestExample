namespace TestExample
{
    public class Program
    {
        public static int Sum(int x , int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int x = Sum(1, 3);
            Console.WriteLine(x);
        }
    }
}