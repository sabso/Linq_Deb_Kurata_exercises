using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.Library;

namespace Tests
{
    /// <summary>
    /// Description résumée pour UnitTest1
    /// </summary>
    [TestClass]
    public class BuiderTest
    {

        public TestContext TestContext { get; set; }
         
        [TestMethod]
        public void BuildIntegerSequenceTest()
        {
            //Arrange 
            Builder listBuilder = new Builder();

            // Act 
            var result = listBuilder.BuildIntegerSequence();

            //Analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }

            //Assert 
            Assert.IsNotNull(result);
            
        }

        [TestMethod]
        public void BuildStringSequenceTest()
        {
            //Arrange 
            Builder listBuilder = new Builder();

            // Act 
            var result = listBuilder.BuildStringSequence();

            //Analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item);
            }

            //Assert 
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void BuildStringSequenceRandomTest()
        {
            //Arrange 
            Builder listBuilder = new Builder();

            // Act 
            var result = listBuilder.BuildStringSequenceRandom();

            //Analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item);
            }

            //Assert 
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void BuildIntegerSequenceUsingRepeatTest()
        {
            //Arrange 
            Builder listBuilder = new Builder();

            // Act 
            var result = listBuilder.BuildIntegerSequenceUsingRepeat();

            //Analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }

            //Assert 
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void BuildStringSequenceUsingRepeatTest()
        {
            //Arrange 
            Builder listBuilder = new Builder();

            // Act 
            var result = listBuilder.BuildStringSequenceUsingRepeat();

            //Analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item);
            }

            //Assert 
            Assert.IsNotNull(result);

        }



    }
}
