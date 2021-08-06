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
    }
}
