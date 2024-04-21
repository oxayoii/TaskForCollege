using CalculatorTest;
namespace MSTestCalculate
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdditioanal()
        {
            int a = 2;
            int b = 2;

            Calculator calculator = new Addition(a, b);
            double result = calculator.Action();
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TestMethodSubstract()
        {
            int a = 5;
            int b = 2;

            Calculator calculator = new Subtract(a, b);
            double result = calculator.Action();
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestMethodMultply()
        {
            int a = 5;
            int b = 2;

            Calculator calculator = new Multply(a, b);
            double result = calculator.Action();
            Assert.AreEqual(10, result);
        }
        [TestMethod]
        public void TestMethodDivide()
        {
            int a = 6;
            int b = 2;

            Calculator calculator = new Divide(a, b);
            double result = calculator.Action();
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestMethodSquare()
        {
            int a = 3;

            Calculator calculator = new Square(a);
            double result = calculator.Action();
            Assert.AreEqual(9, result);
        }
    }
}