namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mathHelper = new MathHelper();
            int res = mathHelper.PrintValue(true);
            Console.WriteLine(res);

        }
    }

    public class MathHelper
    {
        public int PrintValue(int a, int b)
        { return a + b; }

        public int PrintValue(bool a)
        {
            if (a == true) { return 1; }
            else { return 0; }
        }

        public void PrintValue(string a, string b)
        { Console.WriteLine(a + b); }

        public int PrintValue(int a, int b, int c)
        { return a * b * c; }
    }

}