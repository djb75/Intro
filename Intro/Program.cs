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
            double cost = carpetCost(7, 6, 17);
            Console.WriteLine(cost);
            Console.WriteLine("30C to F");
            double F = CtoF(30);
            Console.WriteLine(F);
            Console.WriteLine("100F to C");
            double C = FtoC(100);
            Console.WriteLine(C);
            Console.WriteLine("Ballpit calculations");
            double balls = BallPitCalc(0.5, 1, 0.075);
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

        static double BallPitCalc(double pitHeight, double pitRadius, double ballRadius)
        {
            double packingDensity = 0.75;
            pitRadius = Math.Pow(pitRadius, 2);
            Console.WriteLine("Pit radius^2:");
            Console.WriteLine(pitRadius);
            double pitVol = pitHeight * pitRadius * Math.PI;
            Console.WriteLine("Pit volume:");
            Console.WriteLine(pitVol);
            ballRadius = Math.Pow(ballRadius, 3);
            Console.WriteLine("Ball radius^3:");
            Console.WriteLine(ballRadius);
            const double fourThirds = 4d / 3d;
            Console.WriteLine("Four thirds:");
            Console.WriteLine(fourThirds);
            double ballVol = fourThirds * ballRadius * Math.PI;
            Console.WriteLine("Ball volume: ");
            Console.WriteLine(ballVol); 
            double balls = (pitVol / ballVol) * packingDensity;
            Console.WriteLine("Balls: ");
            Console.WriteLine(balls);
            balls = Math.Ceiling(balls);
            Console.WriteLine(balls);
            //balls = Convert.ToInt32(balls);
            return balls;
        }

    }
}