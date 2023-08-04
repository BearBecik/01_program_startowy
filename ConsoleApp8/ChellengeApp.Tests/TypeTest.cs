using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChellengeApp.Tests
{
    public class TypeTest
    {

        [Test]
        public void WhenTwoTypeReference_ResultNotEquals()
        {
            //1. arranege
            var employeeTest1 = GetEmployee("Arek" ,"Bett");
            var employeeTest2 = GetEmployee("Arek" ,"Bett");
            //2. act
            //3. assert
            Assert.AreNotEqual(employeeTest1, employeeTest2);
        }

        [Test]
        public void WhenTwoTypeReferenceValue_ResultEquals()
        {
            //1. arranege
            var employeeTest1 = GetEmployeeName("Arek");
            var employeeTest2 = GetEmployeeName("Arek");
            //2. act
            //3. assert
            Assert.AreEqual(employeeTest1.Name, employeeTest2.Name);
        }

        [Test]
        public void WhenTwoString_ResultEquals()
        {
            //1. arranege
            string employeeTest1 = "Arek";
            string employeeTest2 = "Arek";
            //2 act
            //3. assert
            Assert.AreEqual(employeeTest1, employeeTest2);
        }

        [Test]
        public void WhenTwoStringValue_ResultFirstGreaterSecond()
        {
            //1. arranege
            string employeeTest1 = "Arekz";
            string employeeTest2 = "Arek";
            //2 act
            //3. assert
            Assert.Greater(employeeTest1, employeeTest2);
        }

        [Test]
        public void WhenTwoIntValue_ResultEquals()
        {
            //1. arranege
            int ageUser1 = 56;
            int ageUser2 = 56;
            //2. act
            //3. assert
            Assert.AreEqual(ageUser1, ageUser2);
        }

        [Test]
        public void WhenTwoIntValue_ResultFirsteLetterSecond() //świadoma zamiana
        {
            //1. arranege
            int ageUser1 = 23;
            int ageUser2 = 56;
            //2. act
            //3. assert
            Assert.Greater(ageUser2, ageUser1);
        }

        [Test]
        public void WhenIntAndVarValue_ResultEquals()
        {
            //1. arranege
            int ageUser1 = 56;
            var ageUser2 = GetEmployeeAge(56);
            //2. act
            //3. assert
            Assert.AreEqual(ageUser1, ageUser2.Age);
        }

        [Test]
        public void WhenThreeFloatValue_ResultEquals()
        {
            //1. arranege
            float ageUser1 = 6.7f;
            float ageUser2 = 6.7f;
            float ageUser3 = 6.7f;

            //2. act
            //3. assert
            Assert.AreEqual(ageUser1, ageUser2, ageUser3);
        }

        public void WhenTwoFloatValue_ResultFirstGreaterSecond()
        {
            //1. arranege
            float ageUser1 = 23f;
            float ageUser2 = 13.8907f;
            //2. act
            //3. assert
            Assert.AreEqual(ageUser1, ageUser2);
        }

        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }

        private Employee GetEmployeeName(string name)
        {
            return new Employee(name);
        }
        private Employee GetEmployeeAge(int age)
        {
            return new Employee(age);
        }

    }
}
