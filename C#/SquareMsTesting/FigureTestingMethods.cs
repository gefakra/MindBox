using Square;
using System.Threading;

namespace SquareMsTesting
{    
    [TestClass]
    public class FigureTestingMethods
    {
        [TestMethod]
        public void Ñalculate_the_area_of_a_circle_by_radius()
        {
            // Arrange
            double r = 2;
            double expected = 12.57;
            Circle circle = new(r);

            // Act
            var actual = Math.Round( circle.GetAreaShape(),2);

            //Asert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_the_area_of_a_triangle_on_three_sides()
        {
            // Arrange
            double a = 5;
            double b = 9;
            double c = 13;
            double expected = 16.07;
            Triangle triangle = new(a,b,c);

            // Act
            var actual = Math.Round(triangle.GetAreaShape(),2);

            //Asert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Triangle_is_rectangular()
        {
            // Arrange            
            bool expected = true;
            Triangle triangle = new(6, 8, 10);

            // Act
            var actual = triangle.IsRectangular();

            //Asert
            Assert.AreEqual(expected, actual);
        }

    }
}