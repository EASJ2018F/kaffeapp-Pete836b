using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kaffeTests

{
    [TestClass()]

     public class FlatWhiteTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            // Arrange
            var fw = new FlatWhite();
            // Act
            int result = fw.Pris(); 
            // Assert
            Assert.AreEqual(45 , result);
        }


        [TestMethod()]
        public void TestMlMælk()
        {
            // Arrange 
            var fw = new FlatWhite();
            // Act
            int result = fw.MlMælk();
            // Assert
            Assert.AreEqual(160 , result);
        }

        [TestMethod()]
        public void TestStryke()
        {
            var fw = new FlatWhite();
            string result = fw.Styrke();
            Assert.AreEqual("Mild", result);
        }
    }
}
