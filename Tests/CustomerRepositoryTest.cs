using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class CustomerRepositoryTest
    {

        public TestContext TestContext { get; set; }

        [TestMethod]
        public void FindTestExistingCustomer()
        {
            //Arrange 
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();// to get the prebuld of our list of customer


            ////Act 
            //var result = repository.Find(customerList, 2);

            ////Assert 
            //Assert.IsNotNull(result);
            //Assert.AreEqual(2, result.CustomerId);
            //Assert.AreEqual("Beggins", result.LastName);
            //Assert.AreEqual("Bilbo", result.FirstName);



            //Act 

            var result = repository.Find(customerList, 42);//an id that doesnt exist

            //Assert 
            Assert.IsNull(result);

        }

        [TestMethod]
        public void SortByNameTest()
        {
            //Arrange 
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //Act
            var result = repository.SortByName(customerList);

            //Assert 
            Assert.IsNotNull(result);
            Assert.AreEqual(2,result.First().CustomerId);
            Assert.AreEqual("Beggins",result.First().LastName);
            Assert.AreEqual("Bilbo", result.First().FirstName);

        }

        [TestMethod]
        public void SortByNameInReverseTest()
        {
            //Arrange 
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //Act
            var result = repository.SortByNameInReverse(customerList);

            //Assert 
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Last().CustomerId);
            Assert.AreEqual("Beggins", result.Last().LastName);
            Assert.AreEqual("Bilbo", result.Last().FirstName);

        }

        [TestMethod]
        public void SortByTypeTest()
        {
            //Arrange 
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //Act
            var result = repository.SortByType(customerList);

            //Assert 
            Assert.IsNotNull(result);
            Assert.AreEqual(null,result.Last().CustomerTypeId);
            Assert.AreEqual("Bilbo", result.Last().FirstName);
            

        }



    }
}