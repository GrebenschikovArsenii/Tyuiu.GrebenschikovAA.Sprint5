using Tyuiu.GrebenschikovAA.Sprint5.Task3.V20.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint5.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        private void SaveToFileTextData_Should_SaveCorrectValueAndReturnPath()
        {
            int x = 3;

            DataService dataService = new DataService();

            string filePath = dataService.SaveToFileTextData(x);


            Assert.IsTrue(File.Exists(filePath), "Файл не был создан.");


            double valueFromFile;
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                valueFromFile = reader.ReadDouble();
            }


            double expected = x / (Math.Sqrt(x * x) + x);
            expected = Math.Round(expected, 3);


            Assert.AreEqual(expected, valueFromFile, "Записанное значение не совпадает с ожидаемым.");


            Console.WriteLine($"Ожидаемое и записанное значение: {valueFromFile}");
        }
    }
}