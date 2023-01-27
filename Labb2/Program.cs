using ClassLibrary;

namespace Labb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ammountOfShapes = 20;
            List<Shape> shapes = new(ammountOfShapes);
            float totalTriangleCicumference = 0;
            float totalArea = 0;
            float biggestVolume = 0;
            int biggestVolumeIndex = 0;


            for (int i = 0; i < ammountOfShapes; i++)
            {
                shapes.Add(Shape.GenerateShape());
            }

            for (int i = 0; i < ammountOfShapes; i++)
            {
                Console.WriteLine(shapes[i]);

                if (shapes[i].GetType() == typeof(Triangle))
                {
                    var triangle = shapes[i] as Triangle;
                    totalTriangleCicumference += triangle.Circumference;
                }

                totalArea += shapes[i].Area;

                if (shapes[i].GetType() == typeof(Cuboid) || shapes[i].GetType() == typeof(Sphere))
                {
                    var volume = shapes[i] as Shape3D;
                    if (volume.Volume > biggestVolume)
                    {
                        biggestVolume = volume.Volume;
                        biggestVolumeIndex = i;
                    }
                }

            }

            
            Console.WriteLine("\nThe average area of all the shapes is: " + totalArea / 20);
            Console.WriteLine("The 3D shape with the biggest volume is shape nr: " + (biggestVolumeIndex + 1) + " with a volume of: " + biggestVolume);
            Console.WriteLine("The total circumference of the triangles is: " + totalTriangleCicumference);


        }
    }
}