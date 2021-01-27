using System;

namespace if_else_if_weather_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int FahrenheitTemperature = 75;
            int CelciusTemperature = 0;
            FahrenheitTemperature = int.Parse(Console.ReadLine());

            CelciusTemperature = (FahrenheitTemperature - 32) * 5 / 9;

            if (CelciusTemperature < 0)
            {
                Console.WriteLine("It's freezing out!");
            }
            else if (CelciusTemperature < 15)
            {
                Console.WriteLine("Wear a jacket.");
            }
            else if (CelciusTemperature < 30)
            {
                Console.WriteLine("Its gorgeous outside.");
            }
            else
            {
                Console.WriteLine("It's finally summer!");
            }
        }
    }
}
