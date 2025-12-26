using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tyuiu.MkhitaryanSG.Sprint7.Project.V12.Lib;

namespace Tyuiu.MkhitaryanSG.Sprint7.Project.V12
{
    public partial class FormInstrument : Form
    {
        private DataService ds = new DataService();
        private string openFilePath;
        private List<Computer> computersList = new List<Computer>();

        // Класс для хранения данных о компьютере - ДОЛЖЕН БЫТЬ PUBLIC
        public class Computer
        {
            public string Manufacturer { get; set; }      // Фирма-изготовитель
            public string ProcessorType { get; set; }     // Тип процессора
            public double ClockSpeed { get; set; }        // Тактовая частота (GHz)
            public int RAM { get; set; }                  // Объем ОЗУ (GB)
            public int HDD { get; set; }                  // Объем жесткого диска (GB)
            public DateTime ReleaseDate { get; set; }     // Дата выпуска
            public decimal Price { get; set; }            // Цена

            // Конструктор по умолчанию
            public Computer() { }

            // Конструктор с параметрами
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

            // Метод для отображения
            public override string ToString()
            {
                return $"{Manufacturer} | {ProcessorType} | {ClockSpeed}GHz | {RAM}GB RAM | {HDD}GB HDD | {ReleaseDate:dd.MM.yyyy} | {Price:N2} руб.";
            }
        }

        public FormInstrument()
        {
            InitializeComponent();
            InitializeDataGridView();
            SetupEventHandlers();
            SetupComboBoxes();
        }

        // ИНИЦИАЛИЗАЦИЯ DATAGRIDVIEW
        private void InitializeDataGridView()
        {
            dataGridViewTable_MSG.AutoGenerateColumns = false;
            dataGridViewTable_MSG.Columns.Clear();

            // Добавляем колонки с правильными заголовками
            DataGridViewTextBoxColumn[] columns = {
                new DataGridViewTextBoxColumn {
                    Name = "Manufacturer",
                    HeaderText = "Фирма-изготовитель",
                    DataPropertyName = "Manufacturer",
                    Width = 120,
                },
                new DataGridViewTextBoxColumn {
                    Name = "ProcessorType",
                    HeaderText = "Тип процессора",
                    DataPropertyName = "ProcessorType",
                    Width = 120,
                },
                new DataGridViewTextBoxColumn {
                    Name = "ClockSpeed",
                    HeaderText = "Тактовая частота (GHz)",
                    DataPropertyName = "ClockSpeed",
                    Width = 120,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "F2" }
                },
                new DataGridViewTextBoxColumn {
                    Name = "RAM",
                    HeaderText = "ОЗУ (GB)",
                    DataPropertyName = "RAM",
                    Width = 120,
                },
                new DataGridViewTextBoxColumn {
                    Name = "HDD",
                    HeaderText = "Жесткий диск (GB)",
                    DataPropertyName = "HDD",
                    Width = 120,
                },
                new DataGridViewTextBoxColumn {
                    Name = "ReleaseDate",
                    HeaderText = "Дата выпуска",
                    DataPropertyName = "ReleaseDate",
                    Width = 120,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy" }
                },
                new DataGridViewTextBoxColumn {
                    Name = "Price",
                    HeaderText = "Цена (руб.)",
                    DataPropertyName = "Price",
                    Width = 120,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
                }
            };

            dataGridViewTable_MSG.Columns.AddRange(columns);

            // Настройка внешнего вида
            dataGridViewTable_MSG.AllowUserToAddRows = false;
            dataGridViewTable_MSG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTable_MSG.RowHeadersVisible = false;
            dataGridViewTable_MSG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // НАСТРОЙКА ОБРАБОТЧИКОВ СОБЫТИЙ
        private void SetupEventHandlers()
        {
            buttonBack_MSG.Click += ButtonBack_MSG_Click;
            buttonOpen_MSG.Click += ButtonOpen_MSG_Click;
            buttonSave_MSG.Click += ButtonSave_MSG_Click;
            buttonAdd_MSG.Click += ButtonAdd_MSG_Click;
            buttonDel_MSG.Click += ButtonDel_MSG_Click;
            buttonClearFilters_MSG.Click += ButtonClearFilters_MSG_Click;
            buttonRefresh_MSG.Click += ButtonRefresh_MSG_Click;
            textBoxSearch_MSG.TextChanged += TextBoxSearch_MSG_TextChanged;
            comboBoxSorted_MSG.SelectedIndexChanged += ComboBoxSorted_MSG_SelectedIndexChanged;
            comboBoxFiltr_MSG.SelectedIndexChanged += ComboBoxFiltr_MSG_SelectedIndexChanged;

            // Двойной клик для просмотра деталей
            dataGridViewTable_MSG.CellDoubleClick += DataGridViewTable_MSG_CellDoubleClick;

            // Обработка нажатия Enter в поиске
            textBoxSearch_MSG.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ApplySearch();
                }
            };
        }

        // НАСТРОЙКА COMBOBOX
        private void SetupComboBoxes()
        {
            // Настройка сортировки
            comboBoxFiltr_MSG.Items.AddRange(new string[]
            {
                "Без сортировки",
                "Цена по возрастанию",
                "Цена по убыванию",
                "Дата выпуска (новые)",
                "Дата выпуска (старые)",
                "ОЗУ по возрастанию",
                "ОЗУ по убыванию",
                "Частота по возрастанию",
                "Частота по убыванию"
            });
            comboBoxFiltr_MSG.SelectedIndex = 0;

            // Настройка фильтрации
            comboBoxSorted_MSG.Items.Add("Все производители");
            comboBoxSorted_MSG.SelectedIndex = 0;
        }

        

        // КНОПКА "НАЗАД"
        private void ButtonBack_MSG_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.Show();
        }
        private void TextBoxSearch_MSG_TextChanged(object sender, EventArgs e)
        {
            
        }

        // ОТКРЫТИЕ ФАЙЛА
        private void ButtonOpen_MSG_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogMain_MSG.Filter = "CSV файлы (*.csv)|*.csv|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialogMain_MSG.FilterIndex = 1;
                openFileDialogMain_MSG.RestoreDirectory = true;

                if (openFileDialogMain_MSG.ShowDialog() == DialogResult.OK)
                {
                    openFilePath = openFileDialogMain_MSG.FileName;
                    LoadDataFromFile(openFilePath);
                    UpdateManufacturersComboBox();

                    // Сброс фильтров
                    ResetFilters();

                    MessageBox.Show($"Файл успешно загружен!\nЗагружено записей: {computersList.Count}",
                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла: {ex.Message}\n\nПроверьте формат файла.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ЗАГРУЗКА ДАННЫХ ИЗ ФАЙЛА
        private void LoadDataFromFile(string filePath)
        {
            computersList.Clear();

            string[,] matrix = ds.LoadFromDataFile(filePath);
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Проверяем минимальное количество колонок
            if (columns < 7)
            {
                throw new Exception("Файл должен содержать минимум 7 колонок данных");
            }

            for (int i = 0; i < rows; i++)
            {
                try
                {
                    Computer computer = new Computer
                    {
                        Manufacturer = matrix[i, 0]?.Trim() ?? "",
                        ProcessorType = matrix[i, 1]?.Trim() ?? "",
                        ClockSpeed = ParseDouble(matrix[i, 2]),
                        RAM = ParseInt(matrix[i, 3]),
                        HDD = ParseInt(matrix[i, 4]),
                        ReleaseDate = ParseDate(matrix[i, 5]),
                        Price = ParseDecimal(matrix[i, 6])
                    };

                    computersList.Add(computer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка в строке {i + 1}: {ex.Message}",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Привязка данных к DataGridView
            BindDataToGridView();
        }

        // ПРИВЯЗКА ДАННЫХ К GRIDVIEW
        private void BindDataToGridView()
        {
            dataGridViewTable_MSG.DataSource = null;
            dataGridViewTable_MSG.DataSource = computersList;

            // Автоматическая подстройка ширины и высоты столбцов
            dataGridViewTable_MSG.AutoResizeColumns();
            dataGridViewTable_MSG.AutoResizeRows();

            UpdateStatus($"Загружено записей: {computersList.Count}");
        }

        private void UpdateStatus(string message)
        {
            if (labelStatus_MSG != null)
                labelStatus_MSG.Text = message;
        }

        // ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ ДЛЯ ПАРСИНГА
        private double ParseDouble(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return 0;
            value = value.Replace(',', '.');
            return double.TryParse(value, out double result) ? result : 0;
        }

        private int ParseInt(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return 0;
            return int.TryParse(value, out int result) ? result : 0;
        }

        private decimal ParseDecimal(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return 0;
            value = value.Replace(',', '.');
            return decimal.TryParse(value, out decimal result) ? result : 0;
        }

        private DateTime ParseDate(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return DateTime.Now;

            // Пробуем разные форматы даты
            string[] formats = { "dd.MM.yyyy", "dd/MM/yyyy", "yyyy-MM-dd", "MM/dd/yyyy" };
            return DateTime.TryParseExact(value, formats,
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime result)
                ? result : DateTime.Now;
        }

        // СОХРАНЕНИЕ ДАННЫХ
        private void ButtonSave_MSG_Click(object sender, EventArgs e)
        {
            try
            {
                if (computersList.Count == 0)
                {
                    MessageBox.Show("Нет данных для сохранения",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                saveFileDialogMain_MSG.Filter = "CSV файлы (*.csv)|*.csv";
                saveFileDialogMain_MSG.DefaultExt = "csv";
                saveFileDialogMain_MSG.FileName = $"Компьютеры_{DateTime.Now:yyyy-MM-dd}.csv";

                if (saveFileDialogMain_MSG.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder csvContent = new StringBuilder();

                    // Заголовки
                    csvContent.AppendLine("Фирма-изготовитель;Тип процессора;Тактовая частота;ОЗУ;Жесткий диск;Дата выпуска;Цена");

                    // Данные
                    foreach (var computer in computersList)
                    {
                        csvContent.AppendLine(
                            $"{computer.Manufacturer};" +
                            $"{computer.ProcessorType};" +
                            $"{computer.ClockSpeed.ToString().Replace(',', '.')};" +
                            $"{computer.RAM};" +
                            $"{computer.HDD};" +
                            $"{computer.ReleaseDate:dd.MM.yyyy};" +
                            $"{computer.Price.ToString().Replace(',', '.')}"
                        );
                    }

                    File.WriteAllText(saveFileDialogMain_MSG.FileName, csvContent.ToString(), Encoding.UTF8);

                    MessageBox.Show($"Данные успешно сохранены в файл:\n{saveFileDialogMain_MSG.FileName}",
                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ДОБАВЛЕНИЕ НОВОЙ ЗАПИСИ 
        private void ButtonAdd_MSG_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormAddComputer addForm = new FormAddComputer())
                {
                    if (addForm.ShowDialog() == DialogResult.OK)
                    {
                        Computer newComputer = addForm.GetComputer();
                        computersList.Add(newComputer);

                        // Обновляем DataGridView
                        BindDataToGridView();

                        // Обновляем комбобокс производителей
                        UpdateManufacturersComboBox();

                        MessageBox.Show($"Компьютер {newComputer.Manufacturer} успешно добавлен!",
                            "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // УДАЛЕНИЕ ЗАПИСИ
        private void ButtonDel_MSG_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable_MSG.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Удалить выбранные записи?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Удаляем из списка
                    foreach (DataGridViewRow row in dataGridViewTable_MSG.SelectedRows)
                    {
                        if (row.DataBoundItem is Computer computer)
                        {
                            computersList.Remove(computer);
                        }
                    }

                    // Обновляем DataGridView
                    BindDataToGridView();

                    // Обновляем комбобокс
                    UpdateManufacturersComboBox();

                    MessageBox.Show($"Удалено {dataGridViewTable_MSG.SelectedRows.Count} записей",
                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ПОКАЗ ДЕТАЛЕЙ ПРИ ДВОЙНОМ КЛИКЕ
        private void DataGridViewTable_MSG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < computersList.Count)
            {
                Computer computer = computersList[e.RowIndex];
                MessageBox.Show(
                    $"Детальная информация:\n\n" +
                    $"Фирма-изготовитель: {computer.Manufacturer}\n" +
                    $"Тип процессора: {computer.ProcessorType}\n" +
                    $"Тактовая частота: {computer.ClockSpeed:F2} GHz\n" +
                    $"Объем ОЗУ: {computer.RAM} GB\n" +
                    $"Объем жесткого диска: {computer.HDD} GB\n" +
                    $"Дата выпуска: {computer.ReleaseDate:dd.MM.yyyy}\n" +
                    $"Цена: {computer.Price:N2} руб.",
                    $"Компьютер: {computer.Manufacturer}",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ApplySearch()
        {
            string searchText = textBoxSearch_MSG.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                dataGridViewTable_MSG.DataSource = computersList;
                UpdateStatus($"Всего записей: {computersList.Count}");
                return;
            }

            var filtered = computersList.Where(c =>
                c.Manufacturer.ToLower().Contains(searchText) ||
                c.ProcessorType.ToLower().Contains(searchText) ||
                c.RAM.ToString().Contains(searchText) ||
                c.HDD.ToString().Contains(searchText) ||
                c.Price.ToString().Contains(searchText) ||
                c.ClockSpeed.ToString().Contains(searchText)).ToList();

            dataGridViewTable_MSG.DataSource = filtered;
            UpdateStatus($"Найдено: {filtered.Count} из {computersList.Count}");
        }

        // СОРТИРОВКА
        private void ComboBoxFiltr_MSG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFiltr_MSG.SelectedIndex == 0 || computersList.Count == 0) return;

            List<Computer> sortedList = new List<Computer>(computersList);

            switch (comboBoxFiltr_MSG.SelectedItem.ToString())
            {
                case "Цена по возрастанию":
                    sortedList = sortedList.OrderBy(c => c.Price).ToList();
                    break;
                case "Цена по убыванию":
                    sortedList = sortedList.OrderByDescending(c => c.Price).ToList();
                    break;
                case "Дата выпуска (новые)":
                    sortedList = sortedList.OrderByDescending(c => c.ReleaseDate).ToList();
                    break;
                case "Дата выпуска (старые)":
                    sortedList = sortedList.OrderBy(c => c.ReleaseDate).ToList();
                    break;
                case "ОЗУ по возрастанию":
                    sortedList = sortedList.OrderBy(c => c.RAM).ToList();
                    break;
                case "ОЗУ по убыванию":
                    sortedList = sortedList.OrderByDescending(c => c.RAM).ToList();
                    break;
                case "Частота по возрастанию":
                    sortedList = sortedList.OrderBy(c => c.ClockSpeed).ToList();
                    break;
                case "Частота по убыванию":
                    sortedList = sortedList.OrderByDescending(c => c.ClockSpeed).ToList();
                    break;
            }

            dataGridViewTable_MSG.DataSource = sortedList;
            UpdateStatus($"Отсортировано по: {comboBoxFiltr_MSG.SelectedItem}");
        }

        // ФИЛЬТРАЦИЯ ПО ПРОИЗВОДИТЕЛЮ
        private void ComboBoxSorted_MSG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSorted_MSG.SelectedIndex == 0) // "Все производители"
            {
                dataGridViewTable_MSG.DataSource = computersList;
                UpdateStatus($"Все производители: {computersList.Count} записей");
            }
            else
            {
                string selectedManufacturer = comboBoxSorted_MSG.SelectedItem.ToString();
                var filtered = computersList.Where(c => c.Manufacturer == selectedManufacturer).ToList();
                dataGridViewTable_MSG.DataSource = filtered;
                UpdateStatus($"Производитель: {selectedManufacturer} ({filtered.Count} записей)");
            }
        }

        // ОБНОВЛЕНИЕ COMBOBOX ПРОИЗВОДИТЕЛЕЙ
        private void UpdateManufacturersComboBox()
        {
            comboBoxSorted_MSG.Items.Clear();
            comboBoxSorted_MSG.Items.Add("Все производители");

            var manufacturers = computersList
                .Select(c => c.Manufacturer)
                .Distinct()
                .OrderBy(m => m)
                .ToList();

            comboBoxSorted_MSG.Items.AddRange(manufacturers.ToArray());
            comboBoxSorted_MSG.SelectedIndex = 0;
        }

        // СБРОС ФИЛЬТРОВ
        private void ButtonClearFilters_MSG_Click(object sender, EventArgs e)
        {
            ResetFilters();
        }

        private void ResetFilters()
        {
            textBoxSearch_MSG.Clear();
            comboBoxFiltr_MSG.SelectedIndex = 0;
            comboBoxSorted_MSG.SelectedIndex = 0;
            dataGridViewTable_MSG.DataSource = computersList;
            UpdateStatus($"Все фильтры сброшены. Всего записей: {computersList.Count}");
        }

        // ОБНОВЛЕНИЕ СПИСКА
        private void ButtonRefresh_MSG_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(openFilePath) && File.Exists(openFilePath))
            {
                LoadDataFromFile(openFilePath);
                UpdateManufacturersComboBox();
                ResetFilters();
                MessageBox.Show("Данные обновлены", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нет открытого файла для обновления",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public class FormAddComputer : Form
    {
        private TextBox txtManufacturer;
        private TextBox txtProcessor;
        private TextBox txtClockSpeed;
        private TextBox txtRAM;
        private TextBox txtHDD;
        private DateTimePicker dtpReleaseDate;
        private TextBox txtPrice;
        private Button btnOK;
        private Button btnCancel;

        public FormAddComputer()
        {
            InitializeComponent();
            this.Load += FormAddComputer_Load;
        }

        private void FormAddComputer_Load(object sender, EventArgs e)
        {
            // Устанавливаем текущую дату по умолчанию
            dtpReleaseDate.Value = DateTime.Now;
            txtManufacturer.Focus();
        }

        private void InitializeComponent()
        {
            this.Text = "Добавить новый компьютер";
            this.Size = new Size(450, 350);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Создание элементов управления
            CreateControls();
            LayoutControls();
        }

        private void CreateControls()
        {
            txtManufacturer = new TextBox { Location = new Point(150, 20), Width = 200 };
            txtProcessor = new TextBox { Location = new Point(150, 50), Width = 200 };
            txtClockSpeed = new TextBox { Location = new Point(150, 80), Width = 100 };
            txtRAM = new TextBox { Location = new Point(150, 110), Width = 100 };
            txtHDD = new TextBox { Location = new Point(150, 140), Width = 100 };
            dtpReleaseDate = new DateTimePicker
            {
                Location = new Point(150, 170),
                Width = 200,
                Format = DateTimePickerFormat.Short
            };
            txtPrice = new TextBox { Location = new Point(150, 200), Width = 100 };

            btnOK = new Button
            {
                Text = "Добавить",
                DialogResult = DialogResult.OK,
                Location = new Point(100, 230),
                Width = 80
            };

            btnCancel = new Button
            {
                Text = "Отмена",
                DialogResult = DialogResult.Cancel,
                Location = new Point(200, 230),
                Width = 80
            };

            // Добавление обработчиков
            btnOK.Click += BtnOK_Click;
        }

        private void LayoutControls()
        {
            int labelY = 25;
            int spacing = 30;

            string[] labels = {
                "Фирма-изготовитель:",
                "Тип процессора:",
                "Тактовая частота (GHz):",
                "ОЗУ (GB):",
                "Жесткий диск (GB):",
                "Дата выпуска:",
                "Цена (руб.):"
            };

            for (int i = 0; i < labels.Length; i++)
            {
                Label label = new Label
                {
                    Text = labels[i],
                    Location = new Point(20, labelY + i * spacing),
                    Width = 120,
                    TextAlign = ContentAlignment.MiddleRight
                };
                this.Controls.Add(label);
            }

            // Добавление элементов управления
            this.Controls.AddRange(new Control[] {
                txtManufacturer, txtProcessor, txtClockSpeed, txtRAM,
                txtHDD, dtpReleaseDate, txtPrice, btnOK, btnCancel
            });
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // Валидация данных
            if (string.IsNullOrWhiteSpace(txtManufacturer.Text))
            {
                MessageBox.Show("Введите фирму-изготовителя", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManufacturer.Focus();
                return;
            }

            if (!double.TryParse(txtClockSpeed.Text.Replace(',', '.'), out double clockSpeed) || clockSpeed <= 0)
            {
                MessageBox.Show("Введите корректную тактовую частоту", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClockSpeed.Focus();
                txtClockSpeed.SelectAll();
                return;
            }

            if (!int.TryParse(txtRAM.Text, out int ram) || ram <= 0)
            {
                MessageBox.Show("Введите корректный объем ОЗУ", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRAM.Focus();
                txtRAM.SelectAll();
                return;
            }

            if (!int.TryParse(txtHDD.Text, out int hdd) || hdd <= 0)
            {
                MessageBox.Show("Введите корректный объем жесткого диска", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHDD.Focus();
                txtHDD.SelectAll();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Replace(',', '.'), out decimal price) || price <= 0)
            {
                MessageBox.Show("Введите корректную цену", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                txtPrice.SelectAll();
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
        public FormInstrument.Computer GetComputer()
        {
            return new FormInstrument.Computer
            {
                Manufacturer = txtManufacturer.Text.Trim(),
                ProcessorType = txtProcessor.Text.Trim(),
                ClockSpeed = double.Parse(txtClockSpeed.Text.Replace(',', '.')),
                RAM = int.Parse(txtRAM.Text),
                HDD = int.Parse(txtHDD.Text),
                ReleaseDate = dtpReleaseDate.Value,
                Price = decimal.Parse(txtPrice.Text.Replace(',', '.'))
            };
        }
    }
}