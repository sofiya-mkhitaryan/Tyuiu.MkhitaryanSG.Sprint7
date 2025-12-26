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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpen_MSG = new Button();
            buttonOProgram_MSG = new Button();
            labelText = new Label();
            buttonFirms_MSG = new Button();
            buttonChart_MSG = new Button();
            SuspendLayout();
            // 
            // buttonOpen_MSG
            // 
            buttonOpen_MSG.Location = new Point(129, 127);
            buttonOpen_MSG.Name = "buttonOpen_MSG";
            buttonOpen_MSG.Size = new Size(115, 42);
            buttonOpen_MSG.TabIndex = 0;
            buttonOpen_MSG.Text = "Данные ПК";
            buttonOpen_MSG.UseVisualStyleBackColor = true;
            buttonOpen_MSG.Click += buttonOpen_MSG_Click;
            // 
            // buttonOProgram_MSG
            // 
            buttonOProgram_MSG.Image = (Image)resources.GetObject("buttonOProgram_MSG.Image");
            buttonOProgram_MSG.Location = new Point(657, 12);
            buttonOProgram_MSG.Name = "buttonOProgram_MSG";
            buttonOProgram_MSG.Size = new Size(50, 45);
            buttonOProgram_MSG.TabIndex = 13;
            buttonOProgram_MSG.Click += buttonOProgram_MSG_Click;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelText.Location = new Point(249, 35);
            labelText.Name = "labelText";
            labelText.Size = new Size(210, 38);
            labelText.TabIndex = 2;
            labelText.Text = "Главное меню";
            // 
            // buttonFirms_MSG
            // 
            buttonFirms_MSG.Location = new Point(293, 127);
            buttonFirms_MSG.Name = "buttonFirms_MSG";
            buttonFirms_MSG.Size = new Size(115, 42);
            buttonFirms_MSG.TabIndex = 11;
            buttonFirms_MSG.Text = "Фирмы";
            buttonFirms_MSG.UseVisualStyleBackColor = true;
            buttonFirms_MSG.Click += buttonFirms_MSG_Click;
            // 
            // buttonChart_MSG
            // 
            buttonChart_MSG.Location = new Point(466, 127);
            buttonChart_MSG.Name = "buttonChart_MSG";
            buttonChart_MSG.Size = new Size(115, 42);
            buttonChart_MSG.TabIndex = 12;
            buttonChart_MSG.Text = "Диаграмма";
            buttonChart_MSG.UseVisualStyleBackColor = true;
            buttonChart_MSG.Click += buttonChart_MSG_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 317);
            Controls.Add(buttonChart_MSG);
            Controls.Add(buttonFirms_MSG);
            Controls.Add(labelText);
            Controls.Add(buttonOProgram_MSG);
            Controls.Add(buttonOpen_MSG);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное меню | Спринт 7 | Техническое задание | Вариант 12 | Мхитарян С. Г.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpen_MSG;
        private Button buttonOProgram_MSG;
        private Label labelText;
        private Button buttonFirms_MSG;
        private Button buttonChart_MSG;
    }
}
