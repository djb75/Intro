﻿namespace Intro
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, L8!");
            int number = Simple(4);
            Console.Write(number);
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
            double tempC = (tempF / 1.8) - 32;
            return tempC;
        }

        static double carpetCost(int width, int length, int price)
        {
            int cost = 50;   //Installation fee
            int area = width * length;
            cost += 3 * area;   //Underlay cost
            cost += price * area;   //Carpet cost
            cost += width * 2 + length * 2;  //Grippers 
            return cost;
        }

        static int Simple(int number)
        {
            return number * 2;
        }
    }
}