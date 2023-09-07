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

        static void Q1()
        {
            Console.WriteLine(@"*******");
            Console.WriteLine(@"*     *");
            Console.WriteLine(@"*  0  *");
            Console.WriteLine(@"* /|\ *");
            Console.WriteLine(@"* / \ *");
            Console.WriteLine(@"*******");
        }

        static int Simple(int number)
        {
            return number * 2;
        }
    }
}