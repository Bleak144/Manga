using BusinessLayer;
using DataLayerInjection;

namespace BusinessLayerTest
{
    [TestClass]
    public class UnitTest1
    {
        Business business = new Business(new DataMemory(),new DataMemory());
        [TestMethod]
        public void TestCreateRegisterUsernameJuanPassword0980()
        {
            bool created = business.createRegister("Juan", "0980");
            Assert.AreEqual(true, created);
        }

        [TestMethod]
        public void TestCreateRegisterUsernameSierraPassword321()
        {
            bool created = business.createRegister("Sierra", "321");
            Assert.AreEqual(false, created);
        }

        [TestMethod]
        public void TestSearchIncomeUsernameSierraPassword321()
        {
            bool created = business.searchIncome("Sierra", "321");
            Assert.AreEqual(true, created);
        }

        [TestMethod]
        public void TestSearchIncomeUsernamePabloPassword456()
        {
            bool created = business.searchIncome("Pablo", "456");
            Assert.AreEqual(false, created);
        }

        [TestMethod]
        public void TestCreateRegisterMangaUsernameSierraidManga9087rating5comentExcelente()
        {
            bool created = business.createRegisterManga("Sierra", "9087",5,"Excelente");
            Assert.AreEqual(true, created);
        }
    }
}