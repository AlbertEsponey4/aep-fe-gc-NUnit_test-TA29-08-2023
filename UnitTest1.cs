namespace NUnit_test
{
    public class Tests
    {
        Geometria.Geometria geo;
        [SetUp]
        public void Setup()
        {
            geo = new Geometria.Geometria();
        }

        [Test]
        public void TestAreaCuadrado()
        {
            Assert.AreEqual(4, geo.areacuadrado(2));
        }

        [Test]
        public void TestAreaCirculo() 
        { 
            double area = 3.1416 * Math.Pow(3, 2);
            Assert.AreEqual(area, geo.areaCirculo(3));
        }

        [Test]
        public void TestAreaTriangulo()
        {
            Assert.AreEqual(3, geo.areatriangulo(2, 3));
        }

        [Test]
        public void TestAreaRectangulo()
        {
            Assert.AreEqual(12, geo.arearectangulo(4, 3));
        }

        [Test]
        public void TestAreaPentagono()
        {
            Assert.AreEqual(25, geo.areapentagono(5, 10));
        }

        [Test]
        public void TestAreaRombo()
        {
            Assert.AreEqual(6, geo.arearombo(3, 4));
        }

        [Test]
        public void TestAreaRomboide()
        {
            Assert.AreEqual(18, geo.arearomboide(3, 6));
        }

        [Test]
        public void AreaTrapecio()
        {
            Assert.AreEqual(24, geo.areatrapecio(2, 4, 8));
        }
    }
}