using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.MkhitaryanSG.Sprint7.Project.V12
{
    public partial class FormFirms_MSG : Form
    {
        private List<Firm> firmsList = new List<Firm>();

        public FormFirms_MSG()
        {
            InitializeComponent();
            LoadFirmsData();
            AttachEventHandlers();
        }

        // КЛАСС ДЛЯ ХРАНЕНИЯ ДАННЫХ О ФИРМЕ
        private class Firm
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public string Description { get; set; }
            public string Website { get; set; }
            public string Specialization { get; set; }
            public string YearFounded { get; set; }
            public string PopularProducts { get; set; }
            public string PriceCategory { get; set; }
        }

        // ЗАГРУЗКА ГОТОВЫХ ДАННЫХ О ФИРМАХ
        private void LoadFirmsData()
        {
            try
            {
                // Очищаем список
                firmsList.Clear();
                listBoxFirms_MSG.Items.Clear();

                // ДОБАВЛЯЕМ ПОДРОБНЫЕ ДАННЫЕ О ФИРМАХ

                // 1. ASUS
                firmsList.Add(new Firm
                {
                    Name = "ASUS",
                    Address = "Тайвань, Тайбэй, район Шилинь",
                    Phone = "+886-2-2894-3447",
                    Description = "Ведущий мировой производитель компьютерных комплектующих и ноутбуков.",
                    Website = "www.asus.com",
                    Specialization = "Материнские платы, ноутбуки, видеокарты, мониторы, сетевое оборудование",
                    YearFounded = "1989",
                    PopularProducts = "ROG (Republic of Gamers) серия, ZenBook, VivoBook, TUF Gaming",
                    PriceCategory = "Средний и премиум-сегмент"
                });

                // 2. Dell
                firmsList.Add(new Firm
                {
                    Name = "Dell Technologies",
                    Address = "США, Техас, Раунд-Рок, One Dell Way",
                    Phone = "+1-800-624-9897",
                    Description = "Американская транснациональная корпорация, один из крупнейших в мире поставщиков компьютеров.",
                    Website = "www.dell.com",
                    Specialization = "Ноутбуки, рабочие станции, серверы, системы хранения данных",
                    YearFounded = "1984",
                    PopularProducts = "XPS, Alienware, Inspiron, Latitude, Precision",
                    PriceCategory = "От бюджетного до премиум-класса"
                });

                // 3. HP
                firmsList.Add(new Firm
                {
                    Name = "HP (Hewlett-Packard)",
                    Address = "США, Калифорния, Пало-Алто, 1501 Page Mill Road",
                    Phone = "+1-650-857-1501",
                    Description = "Одна из крупнейших IT-компаний в мире, основанная в гараже.",
                    Website = "www.hp.com",
                    Specialization = "Принтеры, ноутбуки, ПК, серверы, услуги ИТ",
                    YearFounded = "1939",
                    PopularProducts = "HP Pavilion, HP Omen, HP Elite, HP Spectre",
                    PriceCategory = "Широкий диапазон цен"
                });

                // 4. Lenovo
                firmsList.Add(new Firm
                {
                    Name = "Lenovo Group",
                    Address = "Китай, Пекин, район Хайдянь, No. 6 Chuangye Road",
                    Phone = "+86-10-5886-8888",
                    Description = "Крупнейший производитель ПК в мире, владелец брендов ThinkPad и Motorola.",
                    Website = "www.lenovo.com",
                    Specialization = "Ноутбуки, ПК, серверы, планшеты, смартфоны",
                    YearFounded = "1984",
                    PopularProducts = "ThinkPad, IdeaPad, Legion, Yoga",
                    PriceCategory = "От бюджетных до бизнес-решений"
                });

                // 5. Apple
                firmsList.Add(new Firm
                {
                    Name = "Apple Inc.",
                    Address = "США, Калифорния, Купертино, Apple Park Way",
                    Phone = "+1-408-996-1010",
                    Description = "Мировой лидер в производстве инновационной электроники и программного обеспечения.",
                    Website = "www.apple.com",
                    Specialization = "Ноутбуки Mac, настольные компьютеры, iPhone, iPad, Apple Watch",
                    YearFounded = "1976",
                    PopularProducts = "MacBook Pro, MacBook Air, iMac, Mac Pro, Mac mini",
                    PriceCategory = "Премиум-сегмент"
                });

                // 6. MSI
                firmsList.Add(new Firm
                {
                    Name = "MSI (Micro-Star International)",
                    Address = "Тайвань, Новый Тайбэй, район Синьчжуан, No. 69, Lide St.",
                    Phone = "+886-2-3234-5599",
                    Description = "Мировой лидер в производстве игрового оборудования и материнских плат.",
                    Website = "www.msi.com",
                    Specialization = "Игровые ноутбуки, материнские платы, видеокарты, мониторы",
                    YearFounded = "1986",
                    PopularProducts = "GE/GP/GL серии ноутбуков, материнские платы серии MPG/MAG",
                    PriceCategory = "Игровой сегмент, средний и высокий уровень"
                });

                // 7. Acer
                firmsList.Add(new Firm
                {
                    Name = "Acer Inc.",
                    Address = "Тайвань, Синьчжу, 8F, 88, Sec. 1, Xintai 5th Rd.",
                    Phone = "+886-3-567-8000",
                    Description = "Крупный производитель компьютерной техники и электроники.",
                    Website = "www.acer.com",
                    Specialization = "Ноутбуки, мониторы, проекторы, настольные ПК",
                    YearFounded = "1976",
                    PopularProducts = "Aspire, Predator, Swift, Spin, Nitro",
                    PriceCategory = "Бюджетный и средний сегмент"
                });

                // 8. Samsung
                firmsList.Add(new Firm
                {
                    Name = "Samsung Electronics",
                    Address = "Южная Корея, Сувон, 129, Samsung-ro, Yeongtong-gu",
                    Phone = "+82-2-2255-0114",
                    Description = "Крупнейший южнокорейский конгломерат, производитель электроники.",
                    Website = "www.samsung.com",
                    Specialization = "Ноутбуки, мониторы, SSD, память, полупроводники",
                    YearFounded = "1969",
                    PopularProducts = "Samsung Odyssey, Galaxy Book, мониторы серии S",
                    PriceCategory = "От бюджетных до премиум-моделей"
                });

                // 9. Intel
                firmsList.Add(new Firm
                {
                    Name = "Intel Corporation",
                    Address = "США, Калифорния, Санта-Клара, 2200 Mission College Blvd",
                    Phone = "+1-408-765-8080",
                    Description = "Мировой лидер в производстве процессоров для ПК и серверов.",
                    Website = "www.intel.com",
                    Specialization = "Процессоры, чипсеты, SSD, сетевые решения",
                    YearFounded = "1968",
                    PopularProducts = "Core i3/i5/i7/i9, Xeon, Pentium, Celeron",
                    PriceCategory = "Различные ценовые категории"
                });

                // 10. AMD
                firmsList.Add(new Firm
                {
                    Name = "AMD (Advanced Micro Devices)",
                    Address = "США, Калифорния, Санта-Клара, 2485 Augustine Drive",
                    Phone = "+1-408-749-4000",
                    Description = "Американский производитель полупроводниковых устройств, основной конкурент Intel.",
                    Website = "www.amd.com",
                    Specialization = "Процессоры, видеокарты, системы-на-чипе",
                    YearFounded = "1969",
                    PopularProducts = "Ryzen, EPYC, Radeon, Athlon",
                    PriceCategory = "Конкурентные цены"
                });

                // 11. Microsoft
                firmsList.Add(new Firm
                {
                    Name = "Microsoft Corporation",
                    Address = "США, Вашингтон, Редмонд, One Microsoft Way",
                    Phone = "+1-425-882-8080",
                    Description = "Крупнейшая компания-разработчик программного обеспечения, также производит устройства.",
                    Website = "www.microsoft.com",
                    Specialization = "Операционные системы, офисные приложения, Surface устройства, Xbox",
                    YearFounded = "1975",
                    PopularProducts = "Surface Pro, Surface Laptop, Surface Studio",
                    PriceCategory = "Премиум-сегмент"
                });

                // 12. Sony
                firmsList.Add(new Firm
                {
                    Name = "Sony Corporation",
                    Address = "Япония, Токио, Минато, 1-7-1 Konan",
                    Phone = "+81-3-6748-2111",
                    Description = "Японский транснациональный конгломерат, производитель электроники.",
                    Website = "www.sony.com",
                    Specialization = "Ноутбуки VAIO, игровые консоли, аудио- и видеотехника",
                    YearFounded = "1946",
                    PopularProducts = "VAIO серия (ранее), PlayStation",
                    PriceCategory = "Средний и премиум-сегмент"
                });

                // 13. Toshiba
                firmsList.Add(new Firm
                {
                    Name = "Toshiba Corporation",
                    Address = "Япония, Токио, Минато, 1-1-1 Shibaura",
                    Phone = "+81-3-3457-4511",
                    Description = "Японский конгломерат, один из пионеров в производстве ноутбуков.",
                    Website = "www.toshiba.co.jp",
                    Specialization = "Ноутбуки, жесткие диски, системы хранения данных",
                    YearFounded = "1875",
                    PopularProducts = "Toshiba Satellite, Tecra, Portégé",
                    PriceCategory = "Бюджетный и бизнес-сегмент"
                });

                // 14. Fujitsu
                firmsList.Add(new Firm
                {
                    Name = "Fujitsu Limited",
                    Address = "Япония, Токио, Минато, Shiodome City Center, 1-5-2 Higashi-Shimbashi",
                    Phone = "+81-3-6252-2222",
                    Description = "Японская компания, предоставляющая ИТ-услуги и производящая компьютерную технику.",
                    Website = "www.fujitsu.com",
                    Specialization = "Ноутбуки, серверы, ИТ-услуги, телекоммуникационное оборудование",
                    YearFounded = "1935",
                    PopularProducts = "LifeBook, Celsius, Primergy",
                    PriceCategory = "Бизнес-сегмент"
                });

                // 15. Razer
                firmsList.Add(new Firm
                {
                    Name = "Razer Inc.",
                    Address = "США, Калифорния, Ирвайн, 9 Pasteur, Suite 100",
                    Phone = "+1-855-872-3948",
                    Description = "Мировой лидер в производстве игрового оборудования и ноутбуков для геймеров.",
                    Website = "www.razer.com",
                    Specialization = "Игровые ноутбуки, периферия, аксессуары для геймеров",
                    YearFounded = "2005",
                    PopularProducts = "Razer Blade, Razer Blade Pro, периферия Razer",
                    PriceCategory = "Премиум игровой сегмент"
                });
                // 16. Gigabyte
                firmsList.Add(new Firm
                {
                    Name = "Gigabyte Technology",
                    Address = "Тайвань, Синьчжу, No.6, Baoqiang Rd., Xindian Dist.",
                    Phone = "+886-3-574-8188",
                    Description = "Ведущий производитель материнских плат, видеокарт и компьютерных компонентов.",
                    Website = "www.gigabyte.com",
                    Specialization = "Материнские платы, видеокарты, ноутбуки, мониторы",
                    YearFounded = "1986",
                    PopularProducts = "AORUS серия, материнские платы Gaming, видеокарты NVIDIA и AMD",
                    PriceCategory = "Средний и высокий сегмент"
                });

                // 17. Corsair
                firmsList.Add(new Firm
                {
                    Name = "Corsair Components",
                    Address = "США, Калифорния, Фремонт, 47100 Bayside Parkway",
                    Phone = "+1-510-657-8747",
                    Description = "Американская компания, специализирующаяся на производстве игрового оборудования и компьютерных компонентов.",
                    Website = "www.corsair.com",
                    Specialization = "Оперативная память, блоки питания, корпуса, игровая периферия",
                    YearFounded = "1994",
                    PopularProducts = "Vengeance, Dominator (память), RM серия (блоки питания), K70 (клавиатуры)",
                    PriceCategory = "Средний и премиум сегмент"
                });

                // 18. EVGA
                firmsList.Add(new Firm
                {
                    Name = "EVGA Corporation",
                    Address = "США, Калифорния, Бреа, 2900 Saturn Street, Suite B",
                    Phone = "+1-714-528-4500",
                    Description = "Американский производитель видеокарт, материнских плат и блоков питания.",
                    Website = "www.evga.com",
                    Specialization = "Видеокарты NVIDIA, материнские платы, блоки питания",
                    YearFounded = "1999",
                    PopularProducts = "FTW, SC, Black серии видеокарт, SuperNOVA блоки питания",
                    PriceCategory = "Средний и высокий сегмент"
                });

                // 19. ASRock
                firmsList.Add(new Firm
                {
                    Name = "ASRock Inc.",
                    Address = "Тайвань, Тайбэй, No.137, Sec. 2, Datong Rd., Xizhi Dist.",
                    Phone = "+886-2-8698-2000",
                    Description = "Производитель материнских плат и компьютерных комплектующих, дочерняя компания ASUS.",
                    Website = "www.asrock.com",
                    Specialization = "Материнские платы, мини-ПК, серверные платы",
                    YearFounded = "2002",
                    PopularProducts = "Phantom Gaming, Taichi, Steel Legend серии материнских плат",
                    PriceCategory = "Бюджетный и средний сегмент"
                });

                // 20. Zotac
                firmsList.Add(new Firm
                {
                    Name = "Zotac International",
                    Address = "Гонконг, Unit 1611-1612, 16/F, Metroplaza Tower 1, 223 Hing Fong Road",
                    Phone = "+852-2950-0175",
                    Description = "Производитель видеокарт, мини-ПК и компьютерных компонентов.",
                    Website = "www.zotac.com",
                    Specialization = "Видеокарты, мини-ПК, аксессуары",
                    YearFounded = "2006",
                    PopularProducts = "ZBOX (мини-ПК), видеокарты серий AMP, Twin Edge, Trinity",
                    PriceCategory = "Средний сегмент"
                });

                // СОРТИРУЕМ ФИРМЫ ПО АЛФАВИТУ И ДОБАВЛЯЕМ В LISTBOX
                var sortedFirms = firmsList.OrderBy(f => f.Name).ToList();

                foreach (var firm in sortedFirms)
                {
                    listBoxFirms_MSG.Items.Add(firm.Name);
                }

                // ВЫБИРАЕМ ПЕРВУЮ ФИРМУ
                if (listBoxFirms_MSG.Items.Count > 0)
                {
                    listBoxFirms_MSG.SelectedIndex = 0;
                }

                // ОБНОВЛЯЕМ СТАТУС
                UpdateStatusAndCount();

                // СООБЩЕНИЕ О ЗАГРУЗКЕ
                labelStatus_MSG.Text = $"Загружено {firmsList.Count} фирм-реализаторов";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных о фирмах: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelStatus_MSG.Text = "Ошибка загрузки данных";
            }
        }

        // ОБНОВЛЕНИЕ СТАТУСА И СЧЕТЧИКА
        private void UpdateStatusAndCount()
        {
            int count = firmsList.Count;
            labelCount_MSG.Text = $"Всего фирм в справочнике: {count}";
        }

        // ПОКАЗ ДЕТАЛЬНОЙ ИНФОРМАЦИИ О ФИРМЕ
        private void ShowFirmDetails(string firmName)
        {
            try
            {
                var firm = firmsList.FirstOrDefault(f => f.Name == firmName);
                if (firm != null)
                {
                    // ОСНОВНАЯ ИНФОРМАЦИЯ
                    textBoxName_MSG.Text = firm.Name;
                    textBoxAddress_MSG.Text = firm.Address;
                    textBoxPhone_MSG.Text = firm.Phone;

                    // ФОРМИРУЕМ ПОДРОБНОЕ ПРИМЕЧАНИЕ
                    string detailedInfo = $"{firm.Description}\n\n" +
                                         $"Специализация: {firm.Specialization}\n" +
                                         $"Год основания: {firm.YearFounded}\n" +
                                         $"Популярные продукты: {firm.PopularProducts}\n" +
                                         $"Ценовая категория: {firm.PriceCategory}\n" +
                                         $"Веб-сайт: {firm.Website}";

                    textBoxNote_MSG.Text = detailedInfo;

                    // ОБНОВЛЯЕМ СТАТУС
                    labelStatus_MSG.Text = $"Выбрана фирма: {firm.Name}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка отображения информации: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ПОИСК ФИРМЫ
        private void SearchFirm(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                if (listBoxFirms_MSG.Items.Count > 0)
                {
                    listBoxFirms_MSG.SelectedIndex = 0;
                }
                return;
            }

            searchText = searchText.ToLower();

            // ИЩЕМ ПО НАЗВАНИЮ
            for (int i = 0; i < listBoxFirms_MSG.Items.Count; i++)
            {
                string firmName = listBoxFirms_MSG.Items[i].ToString().ToLower();
                if (firmName.Contains(searchText))
                {
                    listBoxFirms_MSG.SelectedIndex = i;
                    listBoxFirms_MSG.TopIndex = Math.Max(0, i - 3);
                    labelStatus_MSG.Text = $"Найдена фирма: {listBoxFirms_MSG.Items[i]}";
                    return;
                }
            }

            // ИЩЕМ В ДРУГИХ ПОЛЯХ
            var foundFirm = firmsList.FirstOrDefault(f =>
                f.Description.ToLower().Contains(searchText) ||
                f.Specialization.ToLower().Contains(searchText) ||
                f.PopularProducts.ToLower().Contains(searchText));

            if (foundFirm != null)
            {
                int index = listBoxFirms_MSG.Items.IndexOf(foundFirm.Name);
                if (index >= 0)
                {
                    listBoxFirms_MSG.SelectedIndex = index;
                    labelStatus_MSG.Text = $"Найдена фирма: {foundFirm.Name}";
                    return;
                }
            }

            // ЕСЛИ НЕ НАЙДЕНО
            labelStatus_MSG.Text = $"Фирма по запросу '{searchText}' не найдена";
            MessageBox.Show($"Фирма по запросу '{searchText}' не найдена в справочнике.",
                "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ФИЛЬТРАЦИЯ ПО КАТЕГОРИЯМ
        private void FilterByCategory(string category)
        {
            try
            {
                List<string> filteredFirms = new List<string>();

                switch (category)
                {
                    case "Все":
                        filteredFirms = firmsList.Select(f => f.Name).ToList();
                        break;

                    case "Игровые":
                        filteredFirms = firmsList
                            .Where(f => f.Specialization.ToLower().Contains("игр") ||
                                       f.Name == "Razer" ||
                                       f.Name == "MSI" ||
                                       f.PriceCategory.ToLower().Contains("игр"))
                            .Select(f => f.Name)
                            .ToList();
                        break;

                    case "Бюджетные":
                        filteredFirms = firmsList
                            .Where(f => f.PriceCategory.ToLower().Contains("бюджет"))
                            .Select(f => f.Name)
                            .ToList();
                        break;

                    case "Премиум":
                        filteredFirms = firmsList
                            .Where(f => f.PriceCategory.ToLower().Contains("премиум"))
                            .Select(f => f.Name)
                            .ToList();
                        break;

                    case "Бизнес":
                        filteredFirms = firmsList
                            .Where(f => f.Specialization.ToLower().Contains("бизнес") ||
                                       f.Name == "Lenovo" ||
                                       f.Name == "Dell" ||
                                       f.Name == "HP")
                            .Select(f => f.Name)
                            .ToList();
                        break;

                    case "Американские":
                        filteredFirms = firmsList
                            .Where(f => f.Address.Contains("США"))
                            .Select(f => f.Name)
                            .ToList();
                        break;

                    case "Азиатские":
                        filteredFirms = firmsList
                            .Where(f => f.Address.Contains("Тайвань") ||
                                       f.Address.Contains("Китай") ||
                                       f.Address.Contains("Япония") ||
                                       f.Address.Contains("Корея"))
                            .Select(f => f.Name)
                            .ToList();
                        break;
                }

                // ОБНОВЛЯЕМ LISTBOX
                listBoxFirms_MSG.Items.Clear();
                foreach (var firm in filteredFirms.OrderBy(f => f))
                {
                    listBoxFirms_MSG.Items.Add(firm);
                }

                if (listBoxFirms_MSG.Items.Count > 0)
                {
                    listBoxFirms_MSG.SelectedIndex = 0;
                }

                labelStatus_MSG.Text = $"Показано фирм: {filteredFirms.Count} (фильтр: {category})";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка фильтрации: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ОБРАБОТЧИКИ СОБЫТИЙ
        private void AttachEventHandlers()
        {
            buttonBack_MSG.Click += ButtonBack_MSG_Click;
            buttonSearch_MSG.Click += (s, e) => SearchFirm(textBoxSearch_MSG.Text);
            listBoxFirms_MSG.SelectedIndexChanged += ListBoxFirms_MSG_SelectedIndexChanged;

           
            // ОБРАБОТКА ENTER В ПОЛЕ ПОИСКА
            textBoxSearch_MSG.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchFirm(textBoxSearch_MSG.Text);
                }
            };

            // КНОПКА СОХРАНЕНИЯ В ФАЙЛ
            if (buttonSave_MSG != null)
                buttonSave_MSG.Click += ButtonSaveToFile_MSG_Click;
        }

        // ВЫБОР ФИРМЫ ИЗ СПИСКА
        private void ListBoxFirms_MSG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFirms_MSG.SelectedIndex >= 0)
            {
                string selectedFirm = listBoxFirms_MSG.SelectedItem.ToString();
                ShowFirmDetails(selectedFirm);
            }
        }

        // КНОПКА "НАЗАД"
        private void ButtonBack_MSG_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // СОХРАНЕНИЕ СПРАВОЧНИКА В ФАЙЛ
        private void ButtonSaveToFile_MSG_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Сохранить справочник фирм";
                saveDialog.Filter = "Текстовый файл (*.txt)|*.txt|CSV файл (*.csv)|*.csv";
                saveDialog.DefaultExt = "txt";
                saveDialog.FileName = $"Справочник фирм-реализаторов {DateTime.Now:yyyy-MM-dd}";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveDialog.FileName, false, Encoding.UTF8))
                        {
                            writer.WriteLine("СПРАВОЧНИК ФИРМ-РЕАЛИЗАТОРОВ КОМПЬЮТЕРОВ");
                            writer.WriteLine("=".PadRight(80, '='));
                            writer.WriteLine($"Дата создания: {DateTime.Now:dd.MM.yyyy HH:mm}");
                            writer.WriteLine($"Всего фирм: {firmsList.Count}");
                            writer.WriteLine();

                            foreach (var firm in firmsList.OrderBy(f => f.Name))
                            {
                                writer.WriteLine($"ФИРМА: {firm.Name}");
                                writer.WriteLine($"Адрес: {firm.Address}");
                                writer.WriteLine($"Телефон: {firm.Phone}");
                                writer.WriteLine($"Сайт: {firm.Website}");
                                writer.WriteLine($"Год основания: {firm.YearFounded}");
                                writer.WriteLine($"Специализация: {firm.Specialization}");
                                writer.WriteLine($"Популярные продукты: {firm.PopularProducts}");
                                writer.WriteLine($"Ценовая категория: {firm.PriceCategory}");
                                writer.WriteLine($"Описание: {firm.Description}");
                                writer.WriteLine(new string('-', 80));
                                writer.WriteLine();
                            }

                            writer.WriteLine("КОНЕЦ СПРАВОЧНИКА");
                        }

                        MessageBox.Show($"Справочник успешно сохранен в файл:\n{saveDialog.FileName}",
                            "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка сохранения файла: {ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void buttonBack_MSG_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.Show();
        }
    }
}

    

