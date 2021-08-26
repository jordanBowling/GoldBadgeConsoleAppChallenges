using CafeChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CafeMenuRepositoryTests
{
    [TestClass]
    public class MenuRepositoryTests
    {
        [TestMethod]
        public void SetMealName_ShouldSetCorrectString()
        {
            Menu menuContent = new Menu();

            menuContent.MealName = "General Tso's Chicken";

            string expected = "General Tso's Chicken";
            string actual = menuContent.MealName;

            Assert.AreEqual(expected, actual);
        }
    }
}
