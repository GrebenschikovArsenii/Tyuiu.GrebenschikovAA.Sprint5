using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GrebenschikovAA.Sprint5.Task3.V20.Lib
{
    public class DataService: ISprint5Task3V20
    {
        public string SaveToFileTextData(int x)
        {
            double y = x / (Math.Sqrt(x * x) + x);


            y = Math.Round(y, 3);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));
            writer.Write(y);
            writer.Close();
            return path;
        }
    }
}
