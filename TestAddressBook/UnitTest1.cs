using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBookLinq;
namespace TestAddressBook
{
    [TestClass]
    public class UnitTest1
    {
        AddressBookRepo repo;
        [TestInitialize]
        public void TestSetUp()
        {
            repo = new AddressBookRepo();
        }
        [TestMethod]
        public void TestInsertData()
        {
            int expected = 1;
            int actual = repo.InsertData();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestEditDetails()
        {
            int expected = 1;
            int actual = repo.EditDetails(3,"Joey",7645432);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDeleteDetails()
        {
            int expected = 1;
            int actual = repo.DeleteDetails("Joey");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestRetrieveCityOrStateTest()
        {
            string expected = "Chandler";
            string actual = repo.RetrieveOnCityOrState("NewYork","Adol");
            Assert.AreEqual(expected, actual);
        }

    }
}
