using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GrebenschikovAA.Sprint5.Task6.V29.Lib
{
    public class DataService: ISprint5Task6V29
    {
        public int LoadFromDataFile(string path)
        {
            string[] text = File.ReadAllText(path).Split(' ');
            int count = text.Count(x => x.Length == 7);
            return count;
        }
    }
}
