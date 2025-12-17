using System.Data.Common;
using System.IO;
using System.Reflection;
namespace Tyuiu.MkhitaryanSG.Sprint7.Project.V12.Lib
{
    public class DataService
    {
        public string[,] LoadFromDataFile(string path)
        {
            string[] str = File.ReadAllLines(path);

            //определение количества столбцов и строк
            int columns = str[0].Split(';').Length;
            int rows = str.Length;

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < str.Length; i++)
            {
                string strIndexI = str[i];
                string[] strArr = strIndexI.Split(';');
                for (int c = 0; c < strArr.Length; c++)
                {
                    matrix[i, c] = strArr[c];
                }
            }
            return matrix;
        }

        public double CalculateAverage(int[] values)
        {
            double average = 0;

            double sumAverage = 0;


            for (int i = 0; i < values.Length; i++)
            {
                sumAverage += values[i];
            }
            average = (sumAverage / values.Length);

            return Math.Round(average, 2);
        }

        public double CalculateMin(int[] values)
        {
            double min = 10000000;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
            }

            return min;
        }

        public double CalculateMax(int[] values)
        {
            double max = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }

            return max;
        }
    }
}

