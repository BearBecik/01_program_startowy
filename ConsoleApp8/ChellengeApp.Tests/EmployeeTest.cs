

namespace ChellengeApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenEmployeeCollectFourScores_ShouldCorrectResult()
        {
            //1. arranege
            var employeeTest = new Employee("Arkadiusz", "Bett", 56);
            employeeTest.CountPoint(2);
            employeeTest.CountPoint(10);
            employeeTest.CountPoint(3);
            employeeTest.CountPoint(10);

            //2. act
            int result = employeeTest.employee.Sum();

            //3. assert
            Assert.AreEqual(25, result);
        }

        [Test]
        public void WhenEmployeeCollectThreeScoresOneMinus_ShouldCorrectResult()
        {
            var employeeTest = new Employee("Arkadiusz", "Bett", 56);
            employeeTest.CountPoint(-2);
            employeeTest.CountPoint(10);
            employeeTest.CountPoint(4);

            int result = employeeTest.employee.Sum();

            Assert.AreEqual(12, result);
        }

        [Test]
        public void WhenEmployeeCollectThreeScoresOnlyMinus_ShouldCorrectResult()
        {
            var employeeTest = new Employee("Arkadiusz", "Bett", 56);
            employeeTest.CountPoint(-2);
            employeeTest.CountPoint(-10);
            employeeTest.CountPoint(-5);

            int result = employeeTest.employee.Sum();

            Assert.AreEqual(-17, result);
        }

        [Test]
        public void WhenEmployeeCollectFiveScores_ShouldCorrectResultZero()
        {
            var employeeTest = new Employee("Arkadiusz", "Bett", 56);
            employeeTest.CountPoint(-2);
            employeeTest.CountPoint(10);
            employeeTest.CountPoint(-6);
            employeeTest.CountPoint(7);
            employeeTest.CountPoint(-9);

            int result = employeeTest.employee.Sum();

            Assert.AreEqual(0, result);
        }
    }
}