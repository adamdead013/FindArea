using FindArea;

namespace FindAreaTESTS
{
    [TestClass]
    public class UnitTest1
    {
        Circle circle = new Circle();
        Triangle triangle = new Triangle();
        [TestMethod]
        public void TestMethod1()
        {
            
            double resultCircle = circle.GetArea(13.4); // 564.1043768785833
            double resultCircle2 = circle.GetArea(0.73);//1.6741547250980005
            double resultCircle3 = circle.GetArea(100); //31415.926535897932
        }
        [TestMethod]
        public void TestMethod2()
        {
            double resultTriangle = triangle.GetArea(12, 10, 11); //51.521233
            double resultTriangle2 = triangle.GetArea(13.1, 12.2, 10.11); //58.385544
            double resultTriangle3 = triangle.GetArea(150, 300, 200); //13331.70563
            
        }
        [TestMethod]
        public void TestMethod3()
        {
            bool resultTriangleRectangular = triangle.IsRectangular(12, 10, 11);
            bool resultTriangleRectangular2 = triangle.IsRectangular(13.1, 12.2, 10.11);
            bool resultTriangleRectangular3 = triangle.IsRectangular(150, 300, 200);
        }

    }
}