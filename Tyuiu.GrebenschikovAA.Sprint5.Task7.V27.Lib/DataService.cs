using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GrebenschikovAA.Sprint5.Task7.V27.Lib
{
    public class DataService: ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            string saveFilePath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V27.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;

            if (exists)
            {
                File.Delete(saveFilePath);
            }

            string strLine = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    while (line.Contains("  "))
                    {
                        line = line.Replace("  ", "");
                    }
                    File.AppendAllText(saveFilePath, line + Environment.NewLine);
                    strLine = "";
                }

            }
            return saveFilePath;
        }
    }
}
