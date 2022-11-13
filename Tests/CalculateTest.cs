using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLib;
namespace Tests
{
    [TestClass]
    public class CalculateTest
    {
        [TestMethod] //���� ������� ������� ����� ��� ������� 45. ��������� ��������� - 6361.7
        public void CalculateCircleAreaTest()
        {
            Circle circle = new Circle(45);
            double expected = 6361.7;
            double actual = circle.CalculateArea();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//���� ������� ������� ������������ ��� �������� 12, 15, 20. ��������� ��������� - 89.6
        public void CalculateTriangleAreaTest()
        {
            Triangle triangle = new Triangle(12, 15, 20);
            double expected = 89.6;
            double actual = triangle.CalculateArea();
            Assert.AreEqual(expected, actual);
        }
        //����� �������� �� ��, �������� �� ����������� �������������
        [TestMethod]
        public void IsRectangularTest()
        {
            Triangle triangle = new Triangle(5, 3, 4);
            Assert.IsTrue(triangle.IsRectangular);
        }
        [TestMethod]
        public void IsntRectangularTest()
        {
            Triangle triangle = new Triangle(3, 4, 4);
            Assert.IsFalse(triangle.IsRectangular);
        }
    }
}