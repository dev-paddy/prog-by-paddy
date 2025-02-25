namespace TriangleCalculator;

class Program
{
    static void Main(string[] args)
    {
        //Declare variables for area, length and height as double types to allow for decimals
        double area, length, height;

        //Prompt user to enter the length of the base of the triangle
        Console.WriteLine("Enter the length of the base of the triangle: ");
        //Read the user input and convert it to a double
        length = Convert.ToDouble(Console.ReadLine());
        //Prompt user to enter the height of the triangle
        Console.WriteLine("\nEnter the height of the triangle: ");
        //Read the user input and convert it to a double
        height = Convert.ToDouble(Console.ReadLine());

        //Calculates area of the triangle
        area = 0.5 * length * height;

        //Outputs area of triangle
        Console.WriteLine("\n\nThe area of the triangle is " + area);
    }
}
