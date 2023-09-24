using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RainbowSchoolLib;

namespace NUnitTestProj
{
    [TestFixture]
    public class SubjectTests
    {
        [Test]
        public void TestSubjectName()
        {
            // Arrange
            Subject subject = new Subject();
            subject.Name = "Science";

            // Act
            string subjectName = subject.Name;

            // Assert
            Assert.AreEqual("Science", subjectName);
        }

        [Test]
        public void TestSubjectId()
        {
            // Arrange
            Subject subject = new Subject();
            subject.Id = 2;

            // Act
            int subjectId = subject.Id;

            // Assert
            Assert.AreEqual(2, subjectId);
        }
    }
}
