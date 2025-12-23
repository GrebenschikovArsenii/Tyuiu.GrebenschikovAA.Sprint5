using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GrebenschikovAA.Sprint5.Task5.V25.Lib
{
    public class DataService: ISprint5Task5V25
    {
        public double LoadFromDataFile(string path)
        {
            double res = -5973964.557;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) == null)
                {
                    res *= Convert.ToDouble(line);
                }
            }
            return res;
        }
    }
}
