namespace LineComparisonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Wel- Come To Line Comparison Problem");

            // Create two lines with different points
            Line line1 = new Line
            {
                X1 = 1,
                Y1 = 2,
                X2 = 4,
                Y2 = 6
            };

            Line line2 = new Line
            {
                X1 = 4,
                Y1 = 6,
                X2 = 1,
                Y2 = 2
            };

            // Check if the lines are equal
            bool areEqual = line1.Equals(line2);
            Console.WriteLine("Are the lines equal? " + areEqual);
        }
    }
}