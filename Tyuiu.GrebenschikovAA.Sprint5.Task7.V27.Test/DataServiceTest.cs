using Tyuiu.GrebenschikovAA.Sprint5.Task7.V27.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint5.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V27.txt");

        [TestMethod]
        public void CheckPath()
        {
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);

        }
        [TestMethod]
        public void CheckNewPath()
        {
            string newPath = ds.LoadDataAndSave(path);
            FileInfo fileInfo = new FileInfo(newPath);
            Assert.IsTrue(fileInfo.Exists);

        }

        [TestMethod]
        public void CheckValid()
        {
            string newPath = ds.LoadDataAndSave(path);
            string text = "";
            using (StreamReader reader = new StreamReader(newPath))
            {
                text = reader.ReadToEnd();

            }




            string wait = "dddddddddddd";

            Assert.AreEqual(wait, text);
        }
    }
}