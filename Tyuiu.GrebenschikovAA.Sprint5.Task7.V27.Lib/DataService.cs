using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GrebenschikovAA.Sprint5.Task7.V27.Lib
{
    public class DataService: ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            string newPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V27.txt");

            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();
                text = text.Replace("  ", "");
                File.WriteAllText(newPath, text);

            }


            return newPath;

        }
    }
}
