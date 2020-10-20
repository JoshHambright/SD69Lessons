using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using W2D3_Challenge_Repo;

namespace W2D3_Challenge_Tests
{
    [TestClass]
    public class KomodoCustomerTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange
            KomodoCustomer customer = new KomodoCustomer();
            KomodoCustomer_Repo repository = new KomodoCustomer_Repo();

            //Act 
            bool addResult = repository.AddCustomerToDirectory(customer);

            //Assert
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            KomodoCustomer customer = new KomodoCustomer();
            KomodoCustomer_Repo repository = new KomodoCustomer_Repo();

            repository.AddCustomerToDirectory(customer);

            List<KomodoCustomer> customers = repository.GetContent();

            bool directoryHasCustomers = customers.Contains(customer);

            Assert.IsTrue(directoryHasCustomers);
        }

        [TestMethod]
        public void GetByLastName_ShouldReturnCorrectContents()
        {
            KomodoCustomer_Repo repo = new KomodoCustomer_Repo();
            KomodoCustomer customer = new KomodoCustomer(001, "Hambright", new DateTime(1984, 11, 12), new DateTime(2015, 01, 02));
            repo.AddCustomerToDirectory(customer);
            string lastname = "Hambright";

            KomodoCustomer searchResult = repo.GetCustomerByLastName(lastname);

            Assert.AreEqual(searchResult.LastName, lastname);
        }

        [TestMethod]
        public void GetByCustomerID_ShouldReturnCorrectContents()
        {
            KomodoCustomer_Repo repo = new KomodoCustomer_Repo();
            KomodoCustomer customer = new KomodoCustomer(001, "Hambright", new DateTime(1984, 11, 12), new DateTime(2015, 01, 02));
            repo.AddCustomerToDirectory(customer);
            int id = 001;

        KomodoCustomer searchResult = repo.GetCustomerByID(id);

        Assert.AreEqual(searchResult.CustomerID, id);
        }

        [TestMethod]
        public void UpdateExistingCustomerByID_ShouldReturnTRue()
        {
            KomodoCustomer_Repo repo = new KomodoCustomer_Repo();
            KomodoCustomer oldCustomer = new KomodoCustomer(001, "Hambright", new DateTime(1984, 11, 12), new DateTime(2015, 01, 02));
            KomodoCustomer newCustomer = new KomodoCustomer(001, "Hambright", new DateTime(1984, 11, 07), new DateTime(2016, 01, 02));

            repo.AddCustomerToDirectory(oldCustomer);

            bool updateResult = repo.UpdateExistingCustomerByID(oldCustomer.CustomerID, newCustomer);

            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void UpdateExistingCustomerByLastName_ShouldReturnTrue()
        {
            KomodoCustomer_Repo repo = new KomodoCustomer_Repo();
            KomodoCustomer oldCustomer = new KomodoCustomer(001, "Hambright", new DateTime(1984, 11, 12), new DateTime(2015, 01, 02));
            KomodoCustomer newCustomer = new KomodoCustomer(001, "Hambright", new DateTime(1984, 11, 07), new DateTime(2016, 01, 02));

            repo.AddCustomerToDirectory(oldCustomer);

            bool updateResult = repo.UpdateExistingCustomerByLastName(oldCustomer.LastName, newCustomer);

            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            KomodoCustomer_Repo repo = new KomodoCustomer_Repo();
            KomodoCustomer customer = new KomodoCustomer(001, "Hambright", new DateTime(1984, 11, 12), new DateTime(2015, 01, 02));
            repo.AddCustomerToDirectory(customer);

            KomodoCustomer oldCustomer = repo.GetCustomerByID(001);

            bool removeResults = repo.DeleteExistingCustomer(oldCustomer);

            Assert.IsTrue(removeResults);

        }

        [TestMethod]
        public void IsGoldMember_ShouldReturnTrue()
        {
            KomodoCustomer_Repo repo = new KomodoCustomer_Repo();
            KomodoCustomer customer1 = new KomodoCustomer(001, "Hambright", new DateTime(1984, 11, 12), new DateTime(2015, 01, 02));
            KomodoCustomer customer2 = new KomodoCustomer(001, "Smith", new DateTime(1982, 03, 28), new DateTime(2019, 01, 02));


            //repo.MessageCustomers();
            Console.WriteLine("Hello world!");
            
        }
    }
}
