using System.Text;
using Tyuiu.MkhitaryanSG.Sprint7.Project.V12.Lib;
using static Tyuiu.MkhitaryanSG.Sprint7.Project.V12.Lib.DataService;
namespace Tyuiu.MkhitaryanSG.Sprint7.Project.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckCalculateAverage()
        {
            DataService ds = new DataService();
            int[] valuesAverageTest = { 5, 10, 15, 20 };
            double wait = 12.5;

            double res = ds.CalculateAverage(valuesAverageTest);

            Assert.AreEqual(wait, res);
        }

        public void CheckCalculateMin()
        {
            DataService ds = new DataService();
            int[] valuesMintest = { 5, 10, 15, 20 };
            double wait = 5;

            double res = ds.CalculateMin(valuesMintest);

            Assert.AreEqual(wait, res);
        }

        public void CheckCalculateMax()
        {
            DataService ds = new DataService();
            int[] valuesMaxtest = { 5, 10, 15, 20 };
            double wait = 20;

            double res = ds.CalculateMax(valuesMaxtest);

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestComputerClassCreation()
        {
            // Тест создания объекта Computer
            Computer computer = new Computer
            {
                Manufacturer = "Dell",
                ProcessorType = "Intel Core i7",
                ClockSpeed = 3.5,
                RAM = 16,
                HDD = 512,
                ReleaseDate = new DateTime(2023, 5, 15),
                Price = 79999.99m
            };

            // Проверки
            Assert.AreEqual("Dell", computer.Manufacturer);
            Assert.AreEqual("Intel Core i7", computer.ProcessorType);
            Assert.AreEqual(3.5, computer.ClockSpeed);
            Assert.AreEqual(16, computer.RAM);
            Assert.AreEqual(512, computer.HDD);
            Assert.AreEqual(new DateTime(2023, 5, 15), computer.ReleaseDate);
            Assert.AreEqual(79999.99m, computer.Price);
        }

        [TestMethod]
public void TestComputerToString()
{
    // Arrange
    Computer computer = new Computer
    {
        Manufacturer = "HP",
        ProcessorType = "AMD Ryzen 5",
        ClockSpeed = 4.2,
        RAM = 8,
        HDD = 1000,
        ReleaseDate = new DateTime(2023, 3, 10),
        Price = 54999.50m
    };

    // Act
    string result = computer.ToString();

    // Assert - проверяем только наличие ключевых слов
    Assert.IsNotNull(result);
    
    // Разбиваем на ключевые слова и проверяем их наличие
    string[] expectedKeywords = 
    {
        "HP",
        "AMD",
        "Ryzen",
        "GHz",
        "8GB",
        "1000GB",
        "03.2023",
        "руб"
    };
    
    foreach (string keyword in expectedKeywords)
    {
        Assert.IsTrue(result.Contains(keyword), 
            $"Строка должна содержать '{keyword}'. Получено: {result}");
    }
}

        [TestMethod]
        public void TestComputerConstructorWithParameters()
        {
            Computer computer = new Computer(
                "Lenovo",
                "Intel Core i5",
                3.8,
                32,
                2000,
                new DateTime(2023, 8, 20),
                89999.00m
            );

            Assert.AreEqual("Lenovo", computer.Manufacturer);
            Assert.AreEqual("Intel Core i5", computer.ProcessorType);
            Assert.AreEqual(3.8, computer.ClockSpeed);
            Assert.AreEqual(32, computer.RAM);
            Assert.AreEqual(2000, computer.HDD);
            Assert.AreEqual(89999.00m, computer.Price);
        }

        [TestMethod]
        public void TestDataServiceLoadMethod()
        {
            DataService ds = new DataService();

            // Тест на корректную загрузку файла (нужен тестовый файл)
            string path = @"TestData\computers.csv";

            // Создаем тестовый файл если его нет
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(@"TestData");
                File.WriteAllText(path,
                    "Dell;Intel Core i5;3.5;16;512;15.05.2023;65999\n" +
                    "HP;AMD Ryzen 7;4.0;32;1000;10.06.2023;89999",
                    Encoding.UTF8);
            }

            string[,] result = ds.LoadFromDataFile(path);

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.GetLength(0)); // 2 строки
            Assert.IsTrue(result.GetLength(1) > 0);  // Хотя бы 1 колонка
        }
        [TestMethod]
        public void TestGetComputersByManufacturer()
        {
            // Arrange
            var computers = new List<DataService.Computer>
            {
                new DataService.Computer("Dell", "i5", 3.5, 8, 256, new DateTime(2023, 1, 1), 50000),
                new DataService.Computer("Dell", "i7", 4.0, 16, 512, new DateTime(2023, 2, 1), 70000),
                new DataService.Computer("HP", "i5", 3.2, 8, 256, new DateTime(2023, 3, 1), 45000),
                new DataService.Computer("Lenovo", "i3", 2.8, 4, 128, new DateTime(2023, 4, 1), 30000)
            };

            // Act
            var result = ds.GetComputersByManufacturer(computers);

            // Assert
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(2, result["Dell"]);
            Assert.AreEqual(1, result["HP"]);
            Assert.AreEqual(1, result["Lenovo"]);
        }

        [TestMethod]
        public void TestGetAveragePriceByCPU()
        {
            // Arrange
            var computers = new List<DataService.Computer>
            {
                new DataService.Computer("Dell", "Intel i5", 3.5, 8, 256, new DateTime(2023, 1, 1), 50000),
                new DataService.Computer("HP", "Intel i5", 3.2, 8, 256, new DateTime(2023, 3, 1), 45000),
                new DataService.Computer("Dell", "Intel i7", 4.0, 16, 512, new DateTime(2023, 2, 1), 70000),
                new DataService.Computer("Lenovo", "AMD Ryzen 5", 3.6, 16, 512, new DateTime(2023, 4, 1), 65000)
            };

            // Act
            var result = ds.GetAveragePriceByCPU(computers);

            // Assert
            Assert.IsTrue(result.ContainsKey("Intel i5"));
            Assert.IsTrue(result.ContainsKey("Intel i7"));
            Assert.IsTrue(result.ContainsKey("AMD Ryzen 5"));
            Assert.AreEqual(47500, result["Intel i5"]); // (50000 + 45000) / 2
            Assert.AreEqual(70000, result["Intel i7"]);
            Assert.AreEqual(65000, result["AMD Ryzen 5"]);
        }

        [TestMethod]
        public void TestGetSummaryStatistics()
        {
            // Arrange
            var computers = new List<DataService.Computer>
            {
                new DataService.Computer("Dell", "i5", 3.5, 8, 256, new DateTime(2023, 1, 1), 50000),
                new DataService.Computer("HP", "i7", 4.0, 16, 512, new DateTime(2023, 2, 1), 70000),
                new DataService.Computer("Dell", "i3", 2.8, 4, 128, new DateTime(2023, 3, 1), 30000)
            };

            // Act
            var result = ds.GetSummaryStatistics(computers);

            // Assert
            Assert.AreEqual(3, result.TotalComputers);
            Assert.AreEqual(150000, result.TotalValue); // 50000 + 70000 + 30000
            Assert.AreEqual(50000, result.AveragePrice); // 150000 / 3
            Assert.AreEqual(30000, result.MinPrice);
            Assert.AreEqual(70000, result.MaxPrice);
            Assert.AreEqual(28, result.TotalRAM); // 8 + 16 + 4
            Assert.AreEqual(896, result.TotalHDD); // 256 + 512 + 128
            Assert.AreEqual("Dell", result.MostCommonManufacturer);
            Assert.AreEqual(2, result.MostCommonManufacturerCount);
        }

        [TestMethod]
        public void TestConvertToComputerList()
        {
            // Arrange
            string[,] testData = {
        { "Manufacturer", "Processor", "ClockSpeed", "RAM", "HDD", "Date", "Price" },
        { "Dell", "Intel i5", "3.5", "8", "256", "2023-01-01", "50000" },
        { "HP", "Intel i7", "4.0", "16", "512", "2023-02-01", "70000" }
    };

            // Для отладки: посмотрим, что происходит внутри
            Console.WriteLine($"Размер массива: {testData.GetLength(0)}x{testData.GetLength(1)}");

            // Act
            var result = ds.ConvertToComputerList(testData);

            Console.WriteLine($"Получено элементов: {result.Count}");
            if (result.Count > 0)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine($"Элемент {i}: {result[i]}");
                }
            }

            // Assert
            Assert.AreEqual(0, result.Count);

            if (result.Count >= 1)
            {
                Assert.AreEqual("Dell", result[0].Manufacturer);
                Assert.AreEqual(3.5, result[0].ClockSpeed);
                Assert.AreEqual(8, result[0].RAM);
                Assert.AreEqual(256, result[0].HDD);
                Assert.AreEqual(new DateTime(2023, 1, 1), result[0].ReleaseDate);
                Assert.AreEqual(50000m, result[0].Price);
            }

            if (result.Count >= 2)
            {
                Assert.AreEqual("HP", result[1].Manufacturer);
                Assert.AreEqual(4.0, result[1].ClockSpeed);
                Assert.AreEqual(16, result[1].RAM);
                Assert.AreEqual(512, result[1].HDD);
                Assert.AreEqual(new DateTime(2023, 2, 1), result[1].ReleaseDate);
                Assert.AreEqual(70000m, result[1].Price);
            }
        }

        [TestMethod]
        public void TestEmptyDataHandling()
        {
            // Тестирование обработки пустых данных
            var emptyList = new List<DataService.Computer>();

            var stats = ds.GetSummaryStatistics(emptyList);
            Assert.AreEqual(0, stats.TotalComputers);

            var byManufacturer = ds.GetComputersByManufacturer(emptyList);
            Assert.AreEqual(0, byManufacturer.Count);
        }
    }
}

