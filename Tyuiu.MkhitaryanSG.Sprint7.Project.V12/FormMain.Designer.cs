namespace Tyuiu.MkhitaryanSG.Sprint7.Project.V12
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonOpen_MSG = new Button();
            buttonAbout_MSG = new Button();
            toolTipButton = new ToolTip(components);
            buttonHelp_MSG = new Button();
            buttonSave_MSG = new Button();
            buttonDelet_MSG = new Button();
            buttonAdd_MSG = new Button();
            saveFileDialogMain = new SaveFileDialog();
            openFileDialogMain = new OpenFileDialog();
            dataGridViewTable_MSG = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_MSG).BeginInit();
            SuspendLayout();
            // 
            // buttonOpen_MSG
            // 
            buttonOpen_MSG.Location = new Point(12, 12);
            buttonOpen_MSG.Name = "buttonOpen_MSG";
            buttonOpen_MSG.Size = new Size(127, 29);
            buttonOpen_MSG.TabIndex = 0;
            buttonOpen_MSG.Text = "Открыть файл";
            buttonOpen_MSG.UseVisualStyleBackColor = true;
            // 
            // buttonAbout_MSG
            // 
            buttonAbout_MSG.Location = new Point(969, 486);
            buttonAbout_MSG.Name = "buttonAbout_MSG";
            buttonAbout_MSG.Size = new Size(50, 29);
            buttonAbout_MSG.TabIndex = 1;
            buttonAbout_MSG.Text = "INFO";
            toolTipButton.SetToolTip(buttonAbout_MSG, "Информация о разработчике");
            buttonAbout_MSG.UseVisualStyleBackColor = true;
            buttonAbout_MSG.Click += buttonAbout_MSG_Click;
            // 
            // toolTipButton
            // 
            toolTipButton.ToolTipTitle = "Информация о разработчике";
            // 
            // buttonHelp_MSG
            // 
            buttonHelp_MSG.Location = new Point(972, 12);
            buttonHelp_MSG.Name = "buttonHelp_MSG";
            buttonHelp_MSG.Size = new Size(47, 29);
            buttonHelp_MSG.TabIndex = 6;
            buttonHelp_MSG.Text = "?";
            toolTipButton.SetToolTip(buttonHelp_MSG, "Руководство пользователя");
            buttonHelp_MSG.UseVisualStyleBackColor = true;
            buttonHelp_MSG.Click += buttonHelp_MSG_Click;
            buttonHelp_MSG.MouseEnter += buttonHelp_MSG_Click;
            // 
            // buttonSave_MSG
            // 
            buttonSave_MSG.Location = new Point(145, 12);
            buttonSave_MSG.Name = "buttonSave_MSG";
            buttonSave_MSG.Size = new Size(94, 29);
            buttonSave_MSG.TabIndex = 2;
            buttonSave_MSG.Text = "Сохранить";
            buttonSave_MSG.UseVisualStyleBackColor = true;
            // 
            // buttonDelet_MSG
            // 
            buttonDelet_MSG.Location = new Point(345, 12);
            buttonDelet_MSG.Name = "buttonDelet_MSG";
            buttonDelet_MSG.Size = new Size(94, 29);
            buttonDelet_MSG.TabIndex = 3;
            buttonDelet_MSG.Text = "Удалить";
            buttonDelet_MSG.UseVisualStyleBackColor = true;
            // 
            // buttonAdd_MSG
            // 
            buttonAdd_MSG.Location = new Point(245, 12);
            buttonAdd_MSG.Name = "buttonAdd_MSG";
            buttonAdd_MSG.Size = new Size(94, 29);
            buttonAdd_MSG.TabIndex = 4;
            buttonAdd_MSG.Text = "Добавить";
            buttonAdd_MSG.UseVisualStyleBackColor = true;
            // 
            // openFileDialogMain
            // 
            openFileDialogMain.FileName = "openFileDialog1";
            // 
            // dataGridViewTable_MSG
            // 
            dataGridViewTable_MSG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable_MSG.Location = new Point(445, 12);
            dataGridViewTable_MSG.Name = "dataGridViewTable_MSG";
            dataGridViewTable_MSG.RowHeadersWidth = 51;
            dataGridViewTable_MSG.Size = new Size(518, 370);
            dataGridViewTable_MSG.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 527);
            Controls.Add(buttonHelp_MSG);
            Controls.Add(dataGridViewTable_MSG);
            Controls.Add(buttonAdd_MSG);
            Controls.Add(buttonDelet_MSG);
            Controls.Add(buttonSave_MSG);
            Controls.Add(buttonAbout_MSG);
            Controls.Add(buttonOpen_MSG);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Техническое задание | Вариант 12 | Мхитарян С. Г.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_MSG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen_MSG;
        private Button buttonAbout_MSG;
        private ToolTip toolTipButton;
        private Button buttonSave_MSG;
        private Button buttonDelet_MSG;
        private Button buttonAdd_MSG;
        private SaveFileDialog saveFileDialogMain;
        private OpenFileDialog openFileDialogMain;
        private DataGridView dataGridViewTable_MSG;
        private Button buttonHelp_MSG;
    }
}
