namespace Tyuiu.MkhitaryanSG.Sprint7.Project.V12
{
    partial class FormGuide_MSG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide_MSG));
            buttonBack_MSG = new Button();
            textBoxOProgram_MSG = new TextBox();
            SuspendLayout();
            // 
            // buttonBack_MSG
            // 
            buttonBack_MSG.Image = (Image)resources.GetObject("buttonBack_MSG.Image");
            buttonBack_MSG.Location = new Point(12, 12);
            buttonBack_MSG.Name = "buttonBack_MSG";
            buttonBack_MSG.Size = new Size(59, 44);
            buttonBack_MSG.TabIndex = 0;
            buttonBack_MSG.UseVisualStyleBackColor = true;
            buttonBack_MSG.Click += buttonBack_MSG_Click;
            // 
            // textBoxOProgram_MSG
            // 
            textBoxOProgram_MSG.BackColor = SystemColors.InactiveCaption;
            textBoxOProgram_MSG.Location = new Point(12, 68);
            textBoxOProgram_MSG.Multiline = true;
            textBoxOProgram_MSG.Name = "textBoxOProgram_MSG";
            textBoxOProgram_MSG.Size = new Size(950, 458);
            textBoxOProgram_MSG.TabIndex = 1;
            textBoxOProgram_MSG.Text = resources.GetString("textBoxOProgram_MSG.Text");
            // 
            // FormGuide_MSG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(978, 538);
            Controls.Add(textBoxOProgram_MSG);
            Controls.Add(buttonBack_MSG);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGuide_MSG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack_MSG;
        private TextBox textBoxOProgram_MSG;
    }
}