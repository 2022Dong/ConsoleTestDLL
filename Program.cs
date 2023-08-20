using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroMath;

// Dongyun Huang 30042104
namespace ConsoleTestDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Formulas calculate = new Formulas();

            bool isRunning = false;

            while (!isRunning)
            {
                Console.WriteLine("=====================\nWhat would you like to calculate?\n 1. Star Velocity\n 2. Star Distance\n " +
                    "3. Temperature Conversion\n 4. Blackhole Event Horizon\n 5. Exit\n=====================");
                try
                {
                    int option = int.Parse(Console.ReadLine());
                    try
                    {
                        switch (option)
                    {
                        case 1:
                            // Input
                            Console.WriteLine("Observed Wavelength:");
                            double observedWavelength = double.Parse(Console.ReadLine());
                            Console.WriteLine("Rest Wavelength:");
                            double restWavelength = double.Parse(Console.ReadLine());

                            // Output
                            double velocity = calculate.StarVelocity(observedWavelength, restWavelength);
                            Console.WriteLine($"Velocity Value: {velocity}");
                            break;
                        case 2:
                            //Input
                            Console.WriteLine("Arcseconds angle:");
                            double arcsecondsAngle = double.Parse(Console.ReadLine());
                            // Output
                            double parsecs = calculate.StarDistance(arcsecondsAngle);
                            Console.WriteLine($"Parsecs Value: {parsecs}");
                            break;
                        case 3:
                            //Input
                            Console.WriteLine("Celsius:");
                            double celsius = double.Parse(Console.ReadLine());
                            // Output
                            double kelvin = calculate.TemperatureConversion(celsius);
                            Console.WriteLine($"Kelvin Value: {kelvin}");
                            break;
                        case 4:
                            //Input
                            Console.WriteLine("Blackhole Mass:");
                            double blackHoleMass = double.Parse(Console.ReadLine());
                            // Output
                            double schwarzschildRadius = calculate.BlackholeEventHorizon(blackHoleMass);
                            Console.WriteLine($"SchwarzschildRadius Value: {schwarzschildRadius}");
                            break;
                        case 5:
                            Console.WriteLine("Bye, thanks for participating! :)");
                            isRunning = true;
                            break;
                        default:
                            Console.WriteLine("More options are coming... ");
                            break;
                    }
                    }
                    catch { Console.WriteLine("*** Please entry a double value ***"); }
                }
                catch { Console.WriteLine("*** Please type (1 ~ 5) ***"); }
            }
            Console.ReadLine();
        }
    }
}
