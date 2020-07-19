using NUnit.Framework;
using ProjetASPwithtest.Controllers;

namespace ProjetASPwithtest.Tests.Controllers
{
    [TestFixture]
    public class ProduitControllerTest
    {
        // Arrange
        ProduitController controller = new ProduitController();

        [Test]
        public void GetNumber15Test()
        {

            var result = controller.GetNumber15();
            // Assert
            Assert.AreEqual(result, 15);
        }

        [Test]
        public void GetNumber16Test()
        {

            var result = controller.GetNumber16();
            // Assert
            Assert.AreEqual(result, 16);
        }

        [Test]
        public void GetNumber17Test()
        {

            var result = controller.GetNumber17();
            // Assert
            Assert.AreEqual(result, 17);
        }

        [Test]
        public void GetNumber18Test()
        {

            var result = controller.GetNumber18();
            // Assert
            Assert.AreEqual(result, 18);
        }

        [Test]
        public void GetNumber19Test()
        {

            var result = controller.GetNumber19();
            // Assert
            Assert.AreEqual(result, 19);
        }
    }
}
