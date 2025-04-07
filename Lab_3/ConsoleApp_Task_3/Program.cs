using Bridge;

namespace ConsoleApp_Task_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            IRenderer raster = new RasterRenderer();
            IRenderer vector = new VectorRenderer();

            Shape circle = new Circle(vector);
            Shape square = new Square(raster);
            Shape triangle = new Triangle(vector);

            circle.Draw();     
            square.Draw();     
            triangle.Draw();   
        }
    }
}
