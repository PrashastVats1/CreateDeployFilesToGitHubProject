using RainbowSchoolLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProj
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "John Doe";

            // Act
            string studentName = student.Name;

            // Assert
            Assert.AreEqual("John Doe", studentName);
        }

        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "123 Main St";

            // Act
            string studentAddress = student.Address;

            // Assert
            Assert.AreEqual("123 Main St", studentAddress);
        }
    }
}
