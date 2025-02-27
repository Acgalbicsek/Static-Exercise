using System.Runtime.CompilerServices;

namespace StaticExercise
{
    public class Program 
    {
        static void Main(string[] args)
        {
            

            var celsius = TempConverter.FToC(15);
            Console.WriteLine($"{celsius} celsius");
           

            var farenheit = TempConverter.CToF(87);
            Console.WriteLine($"{farenheit} farentheit");
        }
    }
}
