using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tyuiu.MkhitaryanSG.Sprint7.Project.V12.Lib;

namespace Tyuiu.MkhitaryanSG.Sprint7.Project.V12
{
    public partial class FormChart_MSG : Form
    {
        private DataService ds;
        private List<DataService.Computer> computers;

        public FormChart_MSG()
        {
            InitializeComponent();
            ds = new DataService();
            computers = new List<DataService.Computer>();
            InitializeComboBoxes();
        }

        private void buttonBack_MSG_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.Show();
        }

        // 1. Загрузка CSV файла
        private void buttonLoadCSV_MSG_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV файлы (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                textBoxFilePath.Text = Path.GetFileName(filePath);

                try
                {
                    string[,] data = ds.LoadFromDataFile(filePath);
                    computers = ds.ConvertToComputerList(data);

                    if (computers.Count > 0)
                    {
                        MessageBox.Show($"Загружено {computers.Count} записей", "Успех");
                        ShowStatistics();
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка загрузки файла", "Ошибка");
                }
            }
        }

        // 2. Показать статистику
        private void ShowStatistics()
        {
            if (computers.Count == 0) return;

            StringBuilder stats = new StringBuilder();
            stats.AppendLine("=== СТАТИСТИКА ===");
            stats.AppendLine($"Всего: {computers.Count} компьютеров");
            stats.AppendLine();
            stats.AppendLine("Цены:");
            stats.AppendLine($"Средняя: {computers.Average(c => c.Price):N0} руб.");
            stats.AppendLine($"Мин: {computers.Min(c => c.Price):N0} руб.");
            stats.AppendLine($"Макс: {computers.Max(c => c.Price):N0} руб.");
            stats.AppendLine();
            stats.AppendLine("Производители:");

            foreach (var group in computers.GroupBy(c => c.Manufacturer))
            {
                stats.AppendLine($"{group.Key}: {group.Count()} шт.");
            }

            textBoxStats.Text = stats.ToString();
        }

        // 3. Обновить график
        private void buttonUpdateChart_Click(object sender, EventArgs e)
        {
            if (computers.Count == 0)
            {
                MessageBox.Show("Сначала загрузите данные", "Нет данных");
                return;
            }

            if (comboBoxChartType.SelectedItem == null || comboBoxDataField.SelectedItem == null)
            {
                MessageBox.Show("Выберите тип графика и тип данных", "Выбор");
                return;
            }

            Bitmap image = new Bitmap(pictureBoxChart.Width, pictureBoxChart.Height);
            using (Graphics g = Graphics.FromImage(image))
            {
                g.Clear(Color.White);

                string chartType = comboBoxChartType.SelectedItem.ToString();
                string dataType = comboBoxDataField.SelectedItem.ToString();

                // Получаем данные в зависимости от выбора
                var chartData = GetChartData(dataType);

                if (chartData.Count == 0)
                {
                    g.DrawString("Нет данных для графика",
                        new Font("Arial", 12), Brushes.Red,
                        pictureBoxChart.Width / 2 - 70, pictureBoxChart.Height / 2);
                    pictureBoxChart.Image = image;
                    return;
                }

                // Простой график - столбчатый
                if (chartType.Contains("Столб"))
                {
                    DrawSimpleBarChart(g, chartData, dataType);
                }
                else // Круговая диаграмма
                {
                    DrawSimplePieChart(g, chartData, dataType);
                }
            }

            pictureBoxChart.Image = image;
        }

        // Новый метод для получения данных в зависимости от выбора
        private List<ChartDataItem> GetChartData(string dataType)
        {
            List<ChartDataItem> data = new List<ChartDataItem>();

            switch (dataType)
            {
                case "Цены по производителям":
                    var priceData = computers
                        .GroupBy(c => c.Manufacturer)
                        .Select(g => new ChartDataItem
                        {
                            Label = g.Key,
                            Value = (double)g.Average(c => c.Price)
                        })
                        .OrderByDescending(x => x.Value)
                        .Take(6)
                        .ToList();
                    data.AddRange(priceData);
                    break;

                case "ОЗУ по производителям":
                    var ramData = computers
                        .GroupBy(c => c.Manufacturer)
                        .Select(g => new ChartDataItem
                        {
                            Label = g.Key,
                            Value = g.Average(c => c.RAM)
                        })
                        .OrderByDescending(x => x.Value)
                        .Take(6)
                        .ToList();
                    data.AddRange(ramData);
                    break;

                case "Объем HDD по производителям":
                    var hddData = computers
                        .GroupBy(c => c.Manufacturer)
                        .Select(g => new ChartDataItem
                        {
                            Label = g.Key,
                            Value = g.Average(c => c.HDD)
                        })
                        .OrderByDescending(x => x.Value)
                        .Take(6)
                        .ToList();
                    data.AddRange(hddData);
                    break;

                case "Количество компьютеров по производителям":
                    var countData = computers
                        .GroupBy(c => c.Manufacturer)
                        .Select(g => new ChartDataItem
                        {
                            Label = g.Key,
                            Value = g.Count()
                        })
                        .OrderByDescending(x => x.Value)
                        .Take(6)
                        .ToList();
                    data.AddRange(countData);
                    break;

                case "Частота процессора по производителям":
                    var clockData = computers
                        .GroupBy(c => c.Manufacturer)
                        .Select(g => new ChartDataItem
                        {
                            Label = g.Key,
                            Value = g.Average(c => c.ClockSpeed)
                        })
                        .OrderByDescending(x => x.Value)
                        .Take(6)
                        .ToList();
                    data.AddRange(clockData);
                    break;
            }

            return data;
        }

        // Обновленный метод для столбчатой диаграммы
        private void DrawSimpleBarChart(Graphics g, List<ChartDataItem> data, string dataType)
        {
            if (data.Count == 0) return;

            int left = 50;
            int top = 50;
            int width = pictureBoxChart.Width - 100;
            int height = pictureBoxChart.Height - 150;

            // Заголовок в зависимости от типа данных
            string title = GetChartTitle(dataType);
            g.DrawString(title,
                new Font("Arial", 14), Brushes.Black, left, 10);

            // Оси
            g.DrawLine(Pens.Black, left, top, left, top + height);
            g.DrawLine(Pens.Black, left, top + height, left + width, top + height);

            // Столбцы
            int barWidth = width / (data.Count * 2);
            double maxValue = data.Max(d => d.Value);

            for (int i = 0; i < data.Count; i++)
            {
                int x = left + (i * 2 + 1) * barWidth;
                int barHeight = (int)((data[i].Value / maxValue) * height);
                int y = top + height - barHeight;

                // Рисуем столбец
                Color[] colors = { Color.Blue, Color.Red, Color.Green,
                          Color.Orange, Color.Purple, Color.Teal };
                g.FillRectangle(new SolidBrush(colors[i % colors.Length]), x, y, barWidth, barHeight);
                g.DrawRectangle(Pens.Black, x, y, barWidth, barHeight);

                // Подпись значения
                string valueText = data[i].Value.ToString("N1");
                g.DrawString(valueText, new Font("Arial", 9),
                    Brushes.Black, x, y - 20);

                // Подпись категории
                g.DrawString(data[i].Label, new Font("Arial", 9),
                    Brushes.Black, x, top + height + 5);
            }
        }

        // Обновленный метод для круговой диаграммы
        private void DrawSimplePieChart(Graphics g, List<ChartDataItem> data, string dataType)
        {
            if (data.Count == 0) return;

            int centerX = pictureBoxChart.Width / 2;
            int centerY = pictureBoxChart.Height / 2;
            int radius = 150;

            // Цвета
            Color[] colors = { Color.Red, Color.Blue, Color.Green,
                       Color.Orange, Color.Purple, Color.Brown };

            double total = data.Sum(d => d.Value);
            Rectangle rect = new Rectangle(centerX - radius, centerY - radius,
                                          radius * 2, radius * 2);

            float startAngle = 0;

            for (int i = 0; i < data.Count; i++)
            {
                float sweepAngle = (float)(360 * data[i].Value / total);

                g.FillPie(new SolidBrush(colors[i]), rect, startAngle, sweepAngle);
                g.DrawPie(Pens.Black, rect, startAngle, sweepAngle);

                startAngle += sweepAngle;
            }

            // Легенда
            int legendX = 20;
            int legendY = pictureBoxChart.Height - 120;

            for (int i = 0; i < data.Count; i++)
            {
                g.FillRectangle(new SolidBrush(colors[i]), legendX, legendY, 15, 15);

                // Добавляем значение в легенду
                string legendText = $"{data[i].Label}: {data[i].Value:N1}";
                g.DrawString(legendText, new Font("Arial", 9),
                    Brushes.Black, legendX + 20, legendY);

                legendY += 20;
            }

            // Заголовок
            string title = GetChartTitle(dataType);
            g.DrawString(title,
                new Font("Arial", 14), Brushes.Black, centerX - 100, 10);
        }

        // Метод для получения заголовка графика
        private string GetChartTitle(string dataType)
        {
            return dataType switch
            {
                "Цены по производителям" => "Средняя цена по производителям (руб.)",
                "ОЗУ по производителям" => "Средний объем ОЗУ по производителям (GB)",
                "Объем HDD по производителям" => "Средний объем HDD по производителям (GB)",
                "Количество компьютеров по производителям" => "Количество компьютеров по производителям",
                "Частота процессора по производителям" => "Средняя частота процессора по производителям (GHz)",
                _ => dataType
            };
        }

        // Вспомогательный класс для данных графика
        private class ChartDataItem
        {
            public string Label { get; set; }
            public double Value { get; set; }
        }

        // Также добавьте инициализацию ComboBox при загрузке формы
       

        private void InitializeComboBoxes()
        {
            // Типы графиков
            comboBoxChartType.Items.Clear();
            comboBoxChartType.Items.Add("Столбчатая диаграмма");
            comboBoxChartType.Items.Add("Круговая диаграмма");
            comboBoxChartType.SelectedIndex = 0;

            // Типы данных
            comboBoxDataField.Items.Clear();
            comboBoxDataField.Items.Add("Цены по производителям");
            comboBoxDataField.Items.Add("ОЗУ по производителям");
            comboBoxDataField.Items.Add("Объем HDD по производителям");
            comboBoxDataField.Items.Add("Количество компьютеров по производителям");
            comboBoxDataField.Items.Add("Частота процессора по производителям");
            comboBoxDataField.SelectedIndex = 0;
        }

        // 4. Экспорт в фото
        private void buttonExportImage_Click(object sender, EventArgs e)
        {
            if (pictureBoxChart.Image == null)
            {
                MessageBox.Show("Сначала создайте график", "Нет графика");
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PNG файлы (*.png)|*.png";
            saveDialog.FileName = "График.png";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxChart.Image.Save(saveDialog.FileName);
                    MessageBox.Show("График сохранен", "Успех");
                }
                catch
                {
                    MessageBox.Show("Ошибка сохранения", "Ошибка");
                }
            }
        }

        // 5. Показать данные
        private void buttonShowData_Click(object sender, EventArgs e)
        {
            if (computers.Count == 0)
            {
                MessageBox.Show("Сначала загрузите данные", "Нет данных");
                return;
            }

            // Простой вывод в MessageBox
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== ДАННЫЕ КОМПЬЮТЕРОВ ===");
            sb.AppendLine();

            int count = 0;
            foreach (var comp in computers.Take(10)) // Первые 10
            {
                count++;
                sb.AppendLine($"{count}. {comp.Manufacturer}");
                sb.AppendLine($"   Процессор: {comp.ProcessorType}");
                sb.AppendLine($"   Цена: {comp.Price:N0} руб.");
                sb.AppendLine($"   ОЗУ: {comp.RAM} GB, HDD: {comp.HDD} GB");
                sb.AppendLine();
            }

            if (computers.Count > 10)
            {
                sb.AppendLine($"... и еще {computers.Count - 10} записей");
            }

            MessageBox.Show(sb.ToString(), "Данные компьютеров");
        }
    }
}