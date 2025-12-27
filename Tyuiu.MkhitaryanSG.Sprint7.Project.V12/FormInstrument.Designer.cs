namespace Tyuiu.MkhitaryanSG.Sprint7.Project.V12
{
    partial class FormInstrument
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstrument));
            buttonOpen_MSG = new Button();
            buttonSave_MSG = new Button();
            buttonAdd_MSG = new Button();
            buttonDel_MSG = new Button();
            dataGridViewTable_MSG = new DataGridView();
            toolTipButton = new ToolTip(components);
            buttonBack_MSG = new Button();
            buttonRefresh_MSG = new Button();
            saveFileDialogMain_MSG = new SaveFileDialog();
            openFileDialogMain_MSG = new OpenFileDialog();
            groupBoxPanel = new GroupBox();
            labelStatus_MSG = new Label();
            FiltrandPoisk = new GroupBox();
            buttonClearFilters_MSG = new Button();
            labelFilt = new Label();
            labelSort = new Label();
            comboBoxFiltr_MSG = new ComboBox();
            comboBoxSorted_MSG = new ComboBox();
            labelPoisk = new Label();
            textBoxSearch_MSG = new TextBox();
            groupBoxRedaktirovanie = new GroupBox();
            panelRabota = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_MSG).BeginInit();
            groupBoxPanel.SuspendLayout();
            FiltrandPoisk.SuspendLayout();
            groupBoxRedaktirovanie.SuspendLayout();
            panelRabota.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpen_MSG
            // 
            buttonOpen_MSG.BackColor = SystemColors.InactiveCaption;
            buttonOpen_MSG.Location = new Point(8, 26);
            buttonOpen_MSG.Name = "buttonOpen_MSG";
            buttonOpen_MSG.Size = new Size(127, 29);
            buttonOpen_MSG.TabIndex = 1;
            buttonOpen_MSG.Text = "Открыть файл";
            toolTipButton.SetToolTip(buttonOpen_MSG, "Открыть файл в любом формате");
            buttonOpen_MSG.UseVisualStyleBackColor = false;
            // 
            // buttonSave_MSG
            // 
            buttonSave_MSG.BackColor = SystemColors.InactiveCaption;
            buttonSave_MSG.Location = new Point(139, 26);
            buttonSave_MSG.Name = "buttonSave_MSG";
            buttonSave_MSG.Size = new Size(94, 29);
            buttonSave_MSG.TabIndex = 3;
            buttonSave_MSG.Text = "Сохранить";
            toolTipButton.SetToolTip(buttonSave_MSG, "Сохранить файл в формате .cvs");
            buttonSave_MSG.UseVisualStyleBackColor = false;
            // 
            // buttonAdd_MSG
            // 
            buttonAdd_MSG.BackColor = SystemColors.InactiveBorder;
            buttonAdd_MSG.Location = new Point(6, 43);
            buttonAdd_MSG.Name = "buttonAdd_MSG";
            buttonAdd_MSG.Size = new Size(94, 29);
            buttonAdd_MSG.TabIndex = 5;
            buttonAdd_MSG.Text = "Добавить";
            toolTipButton.SetToolTip(buttonAdd_MSG, "Добавить новый компьютер");
            buttonAdd_MSG.UseVisualStyleBackColor = false;
            // 
            // buttonDel_MSG
            // 
            buttonDel_MSG.BackColor = SystemColors.InactiveBorder;
            buttonDel_MSG.Location = new Point(6, 78);
            buttonDel_MSG.Name = "buttonDel_MSG";
            buttonDel_MSG.Size = new Size(94, 29);
            buttonDel_MSG.TabIndex = 6;
            buttonDel_MSG.Text = "Удалить";
            toolTipButton.SetToolTip(buttonDel_MSG, "Выберите ненужную строчку");
            buttonDel_MSG.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTable_MSG
            // 
            dataGridViewTable_MSG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTable_MSG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTable_MSG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable_MSG.Location = new Point(392, 0);
            dataGridViewTable_MSG.Name = "dataGridViewTable_MSG";
            dataGridViewTable_MSG.RowHeadersVisible = false;
            dataGridViewTable_MSG.RowHeadersWidth = 51;
            dataGridViewTable_MSG.Size = new Size(708, 516);
            dataGridViewTable_MSG.TabIndex = 7;
            // 
            // buttonBack_MSG
            // 
            buttonBack_MSG.BackColor = SystemColors.InactiveBorder;
            buttonBack_MSG.Image = (Image)resources.GetObject("buttonBack_MSG.Image");
            buttonBack_MSG.Location = new Point(322, 16);
            buttonBack_MSG.Name = "buttonBack_MSG";
            buttonBack_MSG.Size = new Size(45, 39);
            buttonBack_MSG.TabIndex = 12;
            toolTipButton.SetToolTip(buttonBack_MSG, "Вернуться в главное меню");
            buttonBack_MSG.UseVisualStyleBackColor = false;
            // 
            // buttonRefresh_MSG
            // 
            buttonRefresh_MSG.BackColor = SystemColors.InactiveBorder;
            buttonRefresh_MSG.Location = new Point(6, 306);
            buttonRefresh_MSG.Name = "buttonRefresh_MSG";
            buttonRefresh_MSG.Size = new Size(148, 29);
            buttonRefresh_MSG.TabIndex = 20;
            buttonRefresh_MSG.Text = "Обновить список";
            toolTipButton.SetToolTip(buttonRefresh_MSG, "После обнавления появться добавленные строки");
            buttonRefresh_MSG.UseVisualStyleBackColor = false;
            // 
            // openFileDialogMain_MSG
            // 
            openFileDialogMain_MSG.FileName = "openFileDialog1";
            // 
            // groupBoxPanel
            // 
            groupBoxPanel.Controls.Add(buttonOpen_MSG);
            groupBoxPanel.Controls.Add(buttonSave_MSG);
            groupBoxPanel.Controls.Add(buttonBack_MSG);
            groupBoxPanel.Location = new Point(11, 16);
            groupBoxPanel.Name = "groupBoxPanel";
            groupBoxPanel.Size = new Size(373, 66);
            groupBoxPanel.TabIndex = 12;
            groupBoxPanel.TabStop = false;
            groupBoxPanel.Text = "Панель управления файлами";
            // 
            // labelStatus_MSG
            // 
            labelStatus_MSG.AutoSize = true;
            labelStatus_MSG.Location = new Point(3, 461);
            labelStatus_MSG.Name = "labelStatus_MSG";
            labelStatus_MSG.Size = new Size(59, 20);
            labelStatus_MSG.TabIndex = 14;
            labelStatus_MSG.Text = "Статус: ";
            // 
            // FiltrandPoisk
            // 
            FiltrandPoisk.Controls.Add(buttonRefresh_MSG);
            FiltrandPoisk.Controls.Add(buttonClearFilters_MSG);
            FiltrandPoisk.Controls.Add(labelFilt);
            FiltrandPoisk.Controls.Add(labelSort);
            FiltrandPoisk.Controls.Add(comboBoxFiltr_MSG);
            FiltrandPoisk.Controls.Add(comboBoxSorted_MSG);
            FiltrandPoisk.Controls.Add(labelPoisk);
            FiltrandPoisk.Controls.Add(textBoxSearch_MSG);
            FiltrandPoisk.Location = new Point(3, 110);
            FiltrandPoisk.Name = "FiltrandPoisk";
            FiltrandPoisk.Size = new Size(239, 348);
            FiltrandPoisk.TabIndex = 13;
            FiltrandPoisk.TabStop = false;
            FiltrandPoisk.Text = "Панель фильтрации и поиска";
            // 
            // buttonClearFilters_MSG
            // 
            buttonClearFilters_MSG.BackColor = SystemColors.InactiveBorder;
            buttonClearFilters_MSG.Location = new Point(6, 271);
            buttonClearFilters_MSG.Name = "buttonClearFilters_MSG";
            buttonClearFilters_MSG.Size = new Size(151, 29);
            buttonClearFilters_MSG.TabIndex = 19;
            buttonClearFilters_MSG.Text = "Сброс фильтров";
            buttonClearFilters_MSG.UseVisualStyleBackColor = false;
            // 
            // labelFilt
            // 
            labelFilt.AutoSize = true;
            labelFilt.Location = new Point(8, 188);
            labelFilt.Name = "labelFilt";
            labelFilt.Size = new Size(97, 20);
            labelFilt.TabIndex = 18;
            labelFilt.Text = "Фильтрация:";
            // 
            // labelSort
            // 
            labelSort.AutoSize = true;
            labelSort.Location = new Point(6, 112);
            labelSort.Name = "labelSort";
            labelSort.Size = new Size(179, 20);
            labelSort.TabIndex = 17;
            labelSort.Text = "Сортировка по фирмам:";
            // 
            // comboBoxFiltr_MSG
            // 
            comboBoxFiltr_MSG.FormattingEnabled = true;
            comboBoxFiltr_MSG.Location = new Point(6, 211);
            comboBoxFiltr_MSG.Name = "comboBoxFiltr_MSG";
            comboBoxFiltr_MSG.Size = new Size(199, 28);
            comboBoxFiltr_MSG.TabIndex = 16;
            // 
            // comboBoxSorted_MSG
            // 
            comboBoxSorted_MSG.FormattingEnabled = true;
            comboBoxSorted_MSG.Location = new Point(6, 135);
            comboBoxSorted_MSG.Name = "comboBoxSorted_MSG";
            comboBoxSorted_MSG.Size = new Size(199, 28);
            comboBoxSorted_MSG.TabIndex = 15;
            // 
            // labelPoisk
            // 
            labelPoisk.AutoSize = true;
            labelPoisk.Location = new Point(6, 43);
            labelPoisk.Name = "labelPoisk";
            labelPoisk.Size = new Size(55, 20);
            labelPoisk.TabIndex = 14;
            labelPoisk.Text = "Поиск:";
            // 
            // textBoxSearch_MSG
            // 
            textBoxSearch_MSG.Location = new Point(6, 66);
            textBoxSearch_MSG.Name = "textBoxSearch_MSG";
            textBoxSearch_MSG.Size = new Size(199, 27);
            textBoxSearch_MSG.TabIndex = 13;
            // 
            // groupBoxRedaktirovanie
            // 
            groupBoxRedaktirovanie.Controls.Add(buttonDel_MSG);
            groupBoxRedaktirovanie.Controls.Add(buttonAdd_MSG);
            groupBoxRedaktirovanie.Location = new Point(248, 110);
            groupBoxRedaktirovanie.Name = "groupBoxRedaktirovanie";
            groupBoxRedaktirovanie.Size = new Size(138, 115);
            groupBoxRedaktirovanie.TabIndex = 15;
            groupBoxRedaktirovanie.TabStop = false;
            groupBoxRedaktirovanie.Text = "Редактирование строк";
            // 
            // panelRabota
            // 
            panelRabota.Controls.Add(groupBoxRedaktirovanie);
            panelRabota.Controls.Add(labelStatus_MSG);
            panelRabota.Controls.Add(FiltrandPoisk);
            panelRabota.Controls.Add(groupBoxPanel);
            panelRabota.Dock = DockStyle.Left;
            panelRabota.Location = new Point(0, 0);
            panelRabota.MinimumSize = new Size(392, 0);
            panelRabota.Name = "panelRabota";
            panelRabota.Size = new Size(392, 570);
            panelRabota.TabIndex = 16;
            // 
            // FormInstrument
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 570);
            Controls.Add(panelRabota);
            Controls.Add(dataGridViewTable_MSG);
            Name = "FormInstrument";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Данные ПК";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_MSG).EndInit();
            groupBoxPanel.ResumeLayout(false);
            FiltrandPoisk.ResumeLayout(false);
            FiltrandPoisk.PerformLayout();
            groupBoxRedaktirovanie.ResumeLayout(false);
            panelRabota.ResumeLayout(false);
            panelRabota.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen_MSG;
        private Button buttonSave_MSG;
        private Button buttonAdd_MSG;
        private Button buttonDel_MSG;
        private DataGridView dataGridViewTable_MSG;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogMain_MSG;
        private OpenFileDialog openFileDialogMain_MSG;
        private GroupBox groupBoxPanel;
        private GroupBox FiltrandPoisk;
        private Label labelPoisk;
        private TextBox textBoxSearch_MSG;
        private Label labelFilt;
        private Label labelSort;
        private ComboBox comboBoxFiltr_MSG;
        private ComboBox comboBoxSorted_MSG;
        private Button buttonClearFilters_MSG;
        private Button buttonRefresh_MSG;
        private Button buttonBack_MSG;
        private Label labelStatus_MSG;
        private GroupBox groupBoxRedaktirovanie;
        private Panel panelRabota;
    }
}