namespace Intro
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, L8!");
            int number = Simple(4);
            Console.WriteLine(number);
            printStickMan();
            Console.WriteLine("Enter area width:");
            string? widthStr = Console.ReadLine();
            double width = double.Parse(widthStr);
            Console.WriteLine("Enter area length:");
            string? lengthStr = Console.ReadLine(); 
            double length = double.Parse(lengthStr);
            Console.WriteLine("Enter price:");
            string? priceStr = Console.ReadLine();
            double price = double.Parse(priceStr);
            double cost = carpetCost(width, length, price);
            Console.WriteLine(cost);
            Console.WriteLine("Enter temperature in Celsius:");
            string? CStr = Console.ReadLine();
            double C = double.Parse(CStr);
            double F = CtoF(C);
            Console.WriteLine(F);
            Console.WriteLine("Enter temperature in Fahrenheit:");
            string? FStr = Console.ReadLine();
            double F2 = double.Parse(FStr);
            double C2 = FtoC(F2);
            Console.WriteLine(C2);
            Console.WriteLine("Enter pit height:");
            string? pitHeightStr = Console.ReadLine();
            double pitHeight = double.Parse(pitHeightStr);
            Console.WriteLine("Enter pit radius:");
            string? pitRadiusStr = Console.ReadLine();
            double pitRadius = double.Parse(pitRadiusStr);
            Console.WriteLine("Enter ball radius:");
            string? ballRadiusStr = Console.ReadLine();
            double ballRadius = double.Parse(ballRadiusStr);
            int balls = BallPitCalc(pitHeight, pitRadius, ballRadius);
            Console.WriteLine(balls);
        }

        static void printStickMan()
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
            double tempC = (tempF - 32) / 1.8;
            return tempC;
        }

        static double carpetCost(double width, double length, double price)
        {
            double cost = 50;   //Installation fee
            double area = width * length;
            cost += 3 * area;   //Underlay cost
            cost += price * area;   //Carpet cost
            cost += width * 2 + length * 2;  //Grippers 
            return cost;
        }

        static int Simple(int number)
        {
            return number * 2;
        }

        static int BallPitCalc(double pitHeight, double pitRadius, double ballRadius)
        {
            double packingDensity = 0.75;
            pitRadius = Math.Pow(pitRadius, 2);
            double pitVol = pitHeight * pitRadius * Math.PI;
            ballRadius = Math.Pow(ballRadius, 3);
            double ballVol = (4d/3d) * ballRadius * Math.PI;
            double balls = (pitVol / ballVol) * packingDensity;
            balls = Math.Ceiling(balls);
            int ballsInt = Convert.ToInt32(balls);
            return ballsInt;
        }
    }
}