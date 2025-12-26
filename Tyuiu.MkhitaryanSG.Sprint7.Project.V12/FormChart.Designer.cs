namespace Tyuiu.MkhitaryanSG.Sprint7.Project.V12
{
    partial class FormChart_MSG
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChart_MSG));
            buttonBack_MSG = new Button();
            buttonLoadCSV_MSG = new Button();
            textBoxFilePath = new TextBox();
            comboBoxChartType = new ComboBox();
            comboBoxDataField = new ComboBox();
            textBoxStats = new TextBox();
            buttonExportImage = new Button();
            buttonUpdateChart = new Button();
            buttonShowData = new Button();
            pictureBoxChart = new PictureBox();
            labelChartType = new Label();
            labelDataField = new Label();
            toolTipTip = new ToolTip(components);
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonBack_MSG
            // 
            buttonBack_MSG.Image = (Image)resources.GetObject("buttonBack_MSG.Image");
            buttonBack_MSG.Location = new Point(4, 9);
            buttonBack_MSG.Margin = new Padding(4, 5, 4, 5);
            buttonBack_MSG.Name = "buttonBack_MSG";
            buttonBack_MSG.Size = new Size(100, 35);
            buttonBack_MSG.TabIndex = 0;
            buttonBack_MSG.UseVisualStyleBackColor = true;
            buttonBack_MSG.Click += buttonBack_MSG_Click;
            // 
            // buttonLoadCSV_MSG
            // 
            buttonLoadCSV_MSG.Location = new Point(4, 50);
            buttonLoadCSV_MSG.Margin = new Padding(4, 5, 4, 5);
            buttonLoadCSV_MSG.Name = "buttonLoadCSV_MSG";
            buttonLoadCSV_MSG.Size = new Size(160, 35);
            buttonLoadCSV_MSG.TabIndex = 1;
            buttonLoadCSV_MSG.Text = "Загрузить файл";
            toolTipTip.SetToolTip(buttonLoadCSV_MSG, "Формат csv");
            buttonLoadCSV_MSG.UseVisualStyleBackColor = true;
            buttonLoadCSV_MSG.Click += buttonLoadCSV_MSG_Click;
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Location = new Point(172, 50);
            textBoxFilePath.Margin = new Padding(4, 5, 4, 5);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.ReadOnly = true;
            textBoxFilePath.Size = new Size(289, 27);
            textBoxFilePath.TabIndex = 2;
            // 
            // comboBoxChartType
            // 
            comboBoxChartType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChartType.FormattingEnabled = true;
            comboBoxChartType.Items.AddRange(new object[] { "Столбчатая диаграмма", "Круговая диаграмма" });
            comboBoxChartType.Location = new Point(111, 105);
            comboBoxChartType.Margin = new Padding(4, 5, 4, 5);
            comboBoxChartType.Name = "comboBoxChartType";
            comboBoxChartType.Size = new Size(199, 28);
            comboBoxChartType.TabIndex = 4;
            // 
            // comboBoxDataField
            // 
            comboBoxDataField.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDataField.FormattingEnabled = true;
            comboBoxDataField.Items.AddRange(new object[] { "Цены по производителям", "Количество компьютеров", "ОЗУ по моделям" });
            comboBoxDataField.Location = new Point(111, 151);
            comboBoxDataField.Margin = new Padding(4, 5, 4, 5);
            comboBoxDataField.Name = "comboBoxDataField";
            comboBoxDataField.Size = new Size(199, 28);
            comboBoxDataField.TabIndex = 6;
            // 
            // textBoxStats
            // 
            textBoxStats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxStats.Location = new Point(4, 189);
            textBoxStats.Margin = new Padding(4, 5, 4, 5);
            textBoxStats.Multiline = true;
            textBoxStats.Name = "textBoxStats";
            textBoxStats.ReadOnly = true;
            textBoxStats.ScrollBars = ScrollBars.Vertical;
            textBoxStats.Size = new Size(457, 364);
            textBoxStats.TabIndex = 7;
            textBoxStats.Text = "Статистика будет отображена здесь";
            // 
            // buttonExportImage
            // 
            buttonExportImage.Location = new Point(159, 5);
            buttonExportImage.Margin = new Padding(4, 5, 4, 5);
            buttonExportImage.Name = "buttonExportImage";
            buttonExportImage.Size = new Size(147, 35);
            buttonExportImage.TabIndex = 9;
            buttonExportImage.Text = "Экспорт в фото";
            toolTipTip.SetToolTip(buttonExportImage, "Экспорт в формат png");
            buttonExportImage.UseVisualStyleBackColor = true;
            buttonExportImage.Click += buttonExportImage_Click;
            // 
            // buttonUpdateChart
            // 
            buttonUpdateChart.Location = new Point(4, 5);
            buttonUpdateChart.Margin = new Padding(4, 5, 4, 5);
            buttonUpdateChart.Name = "buttonUpdateChart";
            buttonUpdateChart.Size = new Size(147, 35);
            buttonUpdateChart.TabIndex = 8;
            buttonUpdateChart.Text = "Обновить график";
            toolTipTip.SetToolTip(buttonUpdateChart, "Если нужно поменять тип графика");
            buttonUpdateChart.UseVisualStyleBackColor = true;
            buttonUpdateChart.Click += buttonUpdateChart_Click;
            // 
            // buttonShowData
            // 
            buttonShowData.Location = new Point(317, 5);
            buttonShowData.Margin = new Padding(4, 5, 4, 5);
            buttonShowData.Name = "buttonShowData";
            buttonShowData.Size = new Size(147, 35);
            buttonShowData.TabIndex = 10;
            buttonShowData.Text = "Статистика";
            buttonShowData.UseVisualStyleBackColor = true;
            buttonShowData.Click += buttonShowData_Click;
            // 
            // pictureBoxChart
            // 
            pictureBoxChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxChart.Location = new Point(469, 0);
            pictureBoxChart.Margin = new Padding(4, 5, 4, 5);
            pictureBoxChart.Name = "pictureBoxChart";
            pictureBoxChart.Size = new Size(560, 652);
            pictureBoxChart.TabIndex = 11;
            pictureBoxChart.TabStop = false;
            // 
            // labelChartType
            // 
            labelChartType.AutoSize = true;
            labelChartType.Location = new Point(4, 108);
            labelChartType.Margin = new Padding(4, 0, 4, 0);
            labelChartType.Name = "labelChartType";
            labelChartType.Size = new Size(99, 20);
            labelChartType.TabIndex = 3;
            labelChartType.Text = "Тип графика:";
            // 
            // labelDataField
            // 
            labelDataField.AutoSize = true;
            labelDataField.Location = new Point(4, 154);
            labelDataField.Margin = new Padding(4, 0, 4, 0);
            labelDataField.Name = "labelDataField";
            labelDataField.Size = new Size(67, 20);
            labelDataField.TabIndex = 5;
            labelDataField.Text = "Данные:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonBack_MSG);
            panel1.Controls.Add(buttonLoadCSV_MSG);
            panel1.Controls.Add(textBoxFilePath);
            panel1.Controls.Add(labelChartType);
            panel1.Controls.Add(comboBoxChartType);
            panel1.Controls.Add(textBoxStats);
            panel1.Controls.Add(labelDataField);
            panel1.Controls.Add(comboBoxDataField);
            panel1.Location = new Point(0, 0);
            panel1.MinimumSize = new Size(471, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(471, 652);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(buttonUpdateChart);
            panel2.Controls.Add(buttonExportImage);
            panel2.Controls.Add(buttonShowData);
            panel2.Location = new Point(3, 600);
            panel2.MinimumSize = new Size(465, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(465, 49);
            panel2.TabIndex = 11;
            // 
            // FormChart_MSG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 652);
            Controls.Add(panel1);
            Controls.Add(pictureBoxChart);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormChart_MSG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Диаграмма";
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonBack_MSG;
        private System.Windows.Forms.Button buttonLoadCSV_MSG;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label labelChartType;
        private System.Windows.Forms.ComboBox comboBoxChartType;
        private System.Windows.Forms.Label labelDataField;
        private System.Windows.Forms.ComboBox comboBoxDataField;
        private System.Windows.Forms.TextBox textBoxStats;
        private System.Windows.Forms.Button buttonUpdateChart;
        private System.Windows.Forms.Button buttonExportImage;
        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.PictureBox pictureBoxChart;
        private ToolTip toolTipTip;
        private Panel panel1;
        private Panel panel2;
    }
}