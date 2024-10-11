using Tyuiu.MorozovSM.Sprint3.Task3.V14.Lib;

namespace Tyuiu.MorozovSM.Sprint3.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInString()
        {
            DataService ds = new DataService();
            char replaceable = 'd';
            char replacement = '’';
            string value = "dgt ghedd bed";
            string wait = "’gt ghe’’ be’";
            var res = ds.ReplaceCharInString(value, replaceable, replacement);
            Assert.AreEqual(res,wait);
        }
    }
}