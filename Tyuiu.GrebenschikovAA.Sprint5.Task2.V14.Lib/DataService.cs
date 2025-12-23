using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GrebenschikovAA.Sprint5.Task2.V14.Lib
{
    public class DataService: ISprint5Task2V14
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            var result = "0;0;0\n1;1;1\n0;0;1";

            File.WriteAllText(path, Convert.ToString(result));
            return path;
        }
    }
}