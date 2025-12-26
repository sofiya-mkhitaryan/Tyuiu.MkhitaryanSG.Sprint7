using System.Data.Common;
using System.IO;
using System.Reflection;
using System.Text;
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
        // 1. Методы для работы со списком компьютеров
        public Dictionary<string, int> GetComputersByManufacturer(List<Computer> computers)
        {
            return computers.GroupBy(c => c.Manufacturer)
                           .OrderByDescending(g => g.Count())
                           .ToDictionary(g => g.Key, g => g.Count());
        }

        public Dictionary<string, decimal> GetAveragePriceByCPU(List<Computer> computers)
        {
            return computers.GroupBy(c => c.ProcessorType)
                           .OrderBy(g => g.Key)
                           .ToDictionary(g => g.Key, g => g.Average(c => c.Price));
        }

        public Dictionary<int, int> GetComputersByYear(List<Computer> computers)
        {
            return computers.GroupBy(c => c.ReleaseDate.Year)
                           .OrderBy(g => g.Key)
                           .ToDictionary(g => g.Key, g => g.Count());
        }

        public Dictionary<string, int> GetRAMDistribution(List<Computer> computers)
        {
            var groups = computers.GroupBy(c => c.RAM <= 8 ? "≤ 8GB" :
                                                c.RAM <= 16 ? "9-16GB" :
                                                c.RAM <= 32 ? "17-32GB" : "> 32GB")
                                 .OrderBy(g => g.Key);

            return groups.ToDictionary(g => g.Key, g => g.Count());
        }

        public Dictionary<string, int> GetPriceRangeDistribution(List<Computer> computers)
        {
            var distribution = computers.GroupBy(c =>
                c.Price < 40000 ? "До 40к" :
                c.Price < 70000 ? "40-70к" :
                c.Price < 100000 ? "70-100к" : "Свыше 100к")
                .OrderBy(g => g.Key);

            return distribution.ToDictionary(g => g.Key, g => g.Count());
        }


        // 2. Общая статистика
        public class StatisticsSummary
        {
            public int TotalComputers { get; set; }
            public decimal TotalValue { get; set; }
            public decimal AveragePrice { get; set; }
            public decimal MinPrice { get; set; }
            public decimal MaxPrice { get; set; }
            public int TotalRAM { get; set; }
            public int TotalHDD { get; set; }
            public string MostCommonManufacturer { get; set; }
            public int MostCommonManufacturerCount { get; set; }
        }

        public StatisticsSummary GetSummaryStatistics(List<Computer> computers)
        {
            if (computers == null || !computers.Any())
                return new StatisticsSummary();

            var summary = new StatisticsSummary
            {
                TotalComputers = computers.Count,
                TotalValue = computers.Sum(c => c.Price),
                AveragePrice = computers.Average(c => c.Price),
                MinPrice = computers.Min(c => c.Price),
                MaxPrice = computers.Max(c => c.Price),
                TotalRAM = computers.Sum(c => c.RAM),
                TotalHDD = computers.Sum(c => c.HDD)
            };

            // Самый популярный производитель
            var manufacturerGroups = computers.GroupBy(c => c.Manufacturer)
                                            .OrderByDescending(g => g.Count());
            if (manufacturerGroups.Any())
            {
                var mostCommon = manufacturerGroups.First();
                summary.MostCommonManufacturer = mostCommon.Key;
                summary.MostCommonManufacturerCount = mostCommon.Count();
            }

            return summary;
        }

        // 3. Методы для загрузки данных из DataGridView
        public List<Computer> ConvertToComputerList(string[,] data)
        {
            var computers = new List<Computer>();

            for (int i = 1; i < data.GetLength(0); i++) // Пропускаем заголовок
            {
                try
                {
                    var computer = new Computer
                    {
                        Manufacturer = data[i, 0],
                        ProcessorType = data[i, 1],
                        ClockSpeed = Convert.ToDouble(data[i, 2]),
                        RAM = Convert.ToInt32(data[i, 3]),
                        HDD = Convert.ToInt32(data[i, 4]),
                        ReleaseDate = DateTime.Parse(data[i, 5]),
                        Price = Convert.ToDecimal(data[i, 6])
                    };
                    computers.Add(computer);
                }
                catch
                {
                    // Пропускаем некорректные строки
                    continue;
                }
            }

            return computers;
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
        public class Computer
        {
            public string Manufacturer { get; set; }      // Фирма-изготовитель
            public string ProcessorType { get; set; }     // Тип процессора
            public double ClockSpeed { get; set; }        // Тактовая частота (GHz)
            public int RAM { get; set; }                  // Объем ОЗУ (GB)
            public int HDD { get; set; }                  // Объем жесткого диска (GB)
            public DateTime ReleaseDate { get; set; }     // Дата выпуска
            public decimal Price { get; set; }            // Цена

            // Конструкторы
            public Computer() { }

            public Computer(string manufacturer, string processorType, double clockSpeed,
                           int ram, int hdd, DateTime releaseDate, decimal price)
            {
                Manufacturer = manufacturer;
                ProcessorType = processorType;
                ClockSpeed = clockSpeed;
                RAM = ram;
                HDD = hdd;
                ReleaseDate = releaseDate;
                Price = price;
            }

            public override string ToString()
            {
                return $"{Manufacturer} | {ProcessorType} | {ClockSpeed}GHz | {RAM}GB RAM | {HDD}GB HDD | {ReleaseDate:dd.MM.yyyy} | {Price:N2} руб.";
            }
        }
        
    }
}


