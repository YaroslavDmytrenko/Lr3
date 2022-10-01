namespace Third
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point pointA = new Point("A", 0, 0);
            Point pointB = new Point("B", 0, 2);
            Point pointC = new Point("C", 2, 0);
            Figure figure = new Figure(pointA, pointB, pointC);
            Console.WriteLine(figure.LengthSide(pointA, pointB));
            Console.WriteLine(figure.PerimeterCalculator());
            Console.WriteLine(figure.Name());
        }

    }
}
