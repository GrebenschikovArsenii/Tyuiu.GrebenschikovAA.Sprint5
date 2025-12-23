using Tyuiu.GrebenschikovAA.Sprint5.Task6.V29.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint5.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V29.txt");
            Assert.AreEqual(21, ds.LoadFromDataFile(path));
        }
    }
}