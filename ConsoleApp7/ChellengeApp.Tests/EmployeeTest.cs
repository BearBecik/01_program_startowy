

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
            employeeTest.countPoint(2);
            employeeTest.countPoint(10);
            employeeTest.countPoint(3);
            employeeTest.countPoint(10);

            //2. act
            int result = employeeTest.employee.Sum();

            //3. asset
            Assert.AreEqual(25, result);
        }

        [Test]
        public void WhenEmployeeCollectThreeScoresOneMinus_ShouldCorrectResult()
        {
            var employeeTest = new Employee("Arkadiusz", "Bett", 56);
            employeeTest.countPoint(-2);
            employeeTest.countPoint(10);
            employeeTest.countPoint(4);

            int result = employeeTest.employee.Sum();

            Assert.AreEqual(12, result);
        }

        [Test]
        public void WhenEmployeeCollectThreeScoresOnlyMinus_ShouldCorrectResult()
        {
            var employeeTest = new Employee("Arkadiusz", "Bett", 56);
            employeeTest.countPoint(-2);
            employeeTest.countPoint(-10);
            employeeTest.countPoint(-5);

            int result = employeeTest.employee.Sum();

            Assert.AreEqual(-17, result);
        }

        [Test]
        public void WhenEmployeeCollectFiveScores_ShouldCorrectResultZero()
        {
            var employeeTest = new Employee("Arkadiusz", "Bett", 56);
            employeeTest.countPoint(-2);
            employeeTest.countPoint(10);
            employeeTest.countPoint(-6);
            employeeTest.countPoint(7);
            employeeTest.countPoint(-9);

            int result = employeeTest.employee.Sum();

            Assert.AreEqual(0, result);
        }


    }
}