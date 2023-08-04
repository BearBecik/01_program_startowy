

namespace ChellengeApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenEmployeeCollectFourGrades_ShouldCorrectResult()
        {
            //1. arranege
            var employeeTest = new Employee("Arkadiusz", "Bett");
            employeeTest.AddGrade(2);
            employeeTest.AddGrade(10);
            employeeTest.AddGrade(3);
            employeeTest.AddGrade(10);

            //2. act
            var result = employeeTest.GetStatistics();

            //3. assert
            Assert.That((result.Min, result.Max, result.Average), Is.EqualTo((2, 10, 6.25f)));
        }

        [Test]
        public void WhenEmployeeCollectThreeScoresOneMinus_ShouldCorrectResult()
        {
            var employeeTest = new Employee("Arkadiusz", "Bett");
            employeeTest.AddGrade(-2.698f);
            employeeTest.AddGrade(100);
            employeeTest.AddGrade(14.999f);

            var result = employeeTest.GetStatistics();

            Assert.That((result.Min, result.Max, (float)Math.Round(result.Average,2)), Is.EqualTo((-2.698f, 100, 37.43f)));
        }

        [Test]
        public void WhenEmployeeCollectNullScoress_ShouldCorrectResult()
        {
            var employeeTest = new Employee("Arkadiusz", "Bett");

            var result = employeeTest.GetStatistics();

            Assert.That((result.Min, result.Max, result.Average), Is.EqualTo((0, 0, 0f)));
        }
    }
}