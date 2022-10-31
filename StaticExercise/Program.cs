namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            Console.WriteLine(celsius);

            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine(fahrenheit);
            

           
        }
    }
}
