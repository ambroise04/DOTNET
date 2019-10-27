using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMS.BusinessLogic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Language_Selected()
        {
            var sut = new Fournisseur
            {
                Name = "Ambroise",
                ContactName = "Ambroise Koami",
                Email = "ambroiselaba2000@gmail.com",
                LanguageChoice = Langue.French.ToString()
            };

            Assert.AreEqual(sut.LanguageChoice, Langue.English.ToString());
        }
    }
}
