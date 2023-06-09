namespace LineComparisonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Wel- Come To Line Comparison Problem");

            // Create a line with two points
            Line line = new Line
            {
                X1 = 1,
                Y1 = 2,
                X2 = 4,
                Y2 = 6
            };

            // Calculate and print the length of the line
            double length = line.CalculateLength();
            Console.WriteLine("Length of the line: " + length);
        }
    }
}