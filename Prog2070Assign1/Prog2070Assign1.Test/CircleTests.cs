using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Prog2070Assign1.Test
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void GetRadius_ResultIsNumber()
        {
            //Arrange
            Circle circle = new Circle();

            //Act

          
            //Assert
            Assert.True(int.TryParse(circle.GetRadius().ToString(),out int result));
        }
        [Test]
        public void SetRadius_Given2_ResultIs2()
        {
            //Arrange
            Circle circle = new Circle();
            //Act
            circle.SetRadius(2);

            //Assert
            Assert.AreEqual(2, circle.GetRadius());
        }
        [Test]
        public void GetCircumfremce_Given2_ResultIs12()
        {
            //Arrange
            Circle circle = new Circle();
            //Act
            circle.SetRadius(2);
            
            //Assert
            Assert.AreEqual(12.57, circle.GetCircumference());
        }
        [Test]
        public void GetArea_Given2_ResultIs12()
        {
            //Arrange
            Circle circle = new Circle();
            //Act
            circle.SetRadius(2);

            //Assert
            Assert.AreEqual(12.57, circle.GetArea());
        }
    }
}
