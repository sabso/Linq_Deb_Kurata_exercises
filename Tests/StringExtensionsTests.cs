using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.Library;




namespace Tests
{
    [TestClass]
    public class StringExtensionsTest
    {

        public TestContext TestContext { get; set; }


        [TestMethod]
        public void ConvertToTitleCase()
        {

            // Arrange 
            var source = "the return of the king";
            var expected = "The Return Of The King";


            // Act 
            //var result = StringExtensions.ConvertToTitleCase(source); appel sans this 
            var result = source.ConvertToTitleCase();//appel avec this , devient plus facile a découvrir , comme un buit-in class 


            //Assert 
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result);




        }
    }
}