namespace CircleCalcProg;

class Program
{
    static void Main(string[] args)
    {
        //Declaring the constant PI and the variables radius, area and circumference
        const Double PI = 3.14159;
        Double radius, area, circumference;

        //User is prompted to enter the radius of the circle
        Console.Write("Enter the radius of the circle: ");
        //User input is stored in the variable radius which is a double type to allow for decimals
        radius = Convert.ToDouble(Console.ReadLine());

        //Calculating the area and circumference of the circle
        area = PI * radius * radius;
        circumference = 2 * PI * radius;

        //Output of calculated area and circumference
        Console.WriteLine("\n\nThe area of the circle is: " + area);
        Console.WriteLine("\n\nThe circumference of the circle is: " + circumference);
    }
}