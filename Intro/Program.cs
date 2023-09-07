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

        static double CtoF(double tempC)
        {
            double tempF = (tempC * 1.8) + 32;
            return tempF;
        }

        static double FtoC(double tempF)
        {
            double tempC = (tempF / 1.8) - 32;
            return tempC;
        }

        static int Simple(int number)
        {
            return number * 2;
        }
    }
}