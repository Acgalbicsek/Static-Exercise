namespace StaticExercise
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fahrenheit -> Celsius");
            Console.WriteLine(TempConverter.FahrenheitToCelsius(32));

            Console.WriteLine("Celsius -> Fahrenheit");
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(0));
        }
    }
}
