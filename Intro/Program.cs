namespace Intro
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, L8!");
            int number = Simple(4);
            Console.Write(number);
        }

        static int Simple(int number)
        {
            return number * 2;
        }
    }
}