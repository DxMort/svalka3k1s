namespace AbstractFabricLibrary
{
    public interface ShapesFabrics
    {
        Color color { get; set; }
        Shape CreateCircle(int x, int y);
        Shape CreateSquare(int x, int y);
        Shape CreateTriangle(int x, int y);
    }

    public class BlueFabric : ShapesFabrics
    {
        public Color color { get; set; } = Color.Blue;
        public Shape CreateCircle(int x, int y) => new Circle(Brushes.Blue, x, y);
        public Shape CreateSquare(int x, int y) => new Square(Brushes.Blue, x, y);
        public Shape CreateTriangle(int x, int y) => new Triangle(Brushes.Blue, x, y);
    }

    public class RedFabric : ShapesFabrics
    {
        public Color color { get; set; } = Color.Red;
        public Shape CreateCircle(int x, int y) => new Circle(Brushes.Red, x, y);
        public Shape CreateSquare(int x, int y) => new Square(Brushes.Red, x, y);
        public Shape CreateTriangle(int x, int y) => new Triangle(Brushes.Red, x, y);
    }
    public class GreenFabric : ShapesFabrics
    {
        public Color color { get; set; } = Color.Red;
        public Shape CreateCircle(int x, int y) => new Circle(Brushes.Green, x, y);
        public Shape CreateSquare(int x, int y) => new Square(Brushes.Green, x, y);
        public Shape CreateTriangle(int x, int y) => new Triangle(Brushes.Green, x, y);
    }
}
