namespace Tyuiu.MkhitaryanSG.Sprint7.Project.V12
{
    partial class FormAbout_MSG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_MSG));
            buttonOK_MSG = new Button();
            textBoxAbout_MSG = new TextBox();
            pictureBox_KOT = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_KOT).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_MSG
            // 
            buttonOK_MSG.Location = new Point(694, 409);
            buttonOK_MSG.Name = "buttonOK_MSG";
            buttonOK_MSG.Size = new Size(94, 29);
            buttonOK_MSG.TabIndex = 0;
            buttonOK_MSG.Text = "OK";
            buttonOK_MSG.UseVisualStyleBackColor = true;
            buttonOK_MSG.Click += buttonOK_Click;
            // 
            // textBoxAbout_MSG
            // 
            textBoxAbout_MSG.Location = new Point(350, 12);
            textBoxAbout_MSG.Multiline = true;
            textBoxAbout_MSG.Name = "textBoxAbout_MSG";
            textBoxAbout_MSG.Size = new Size(289, 59);
            textBoxAbout_MSG.TabIndex = 1;
            textBoxAbout_MSG.Text = "Разработчик: Мхитарян София Геворковна студентка РППб25-1";
            // 
            // pictureBox_KOT
            // 
            pictureBox_KOT.Image = (Image)resources.GetObject("pictureBox_KOT.Image");
            pictureBox_KOT.Location = new Point(12, 12);
            pictureBox_KOT.Name = "pictureBox_KOT";
            pictureBox_KOT.Size = new Size(298, 340);
            pictureBox_KOT.TabIndex = 2;
            pictureBox_KOT.TabStop = false;
            // 
            // FormAbout_MSG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox_KOT);
            Controls.Add(textBoxAbout_MSG);
            Controls.Add(buttonOK_MSG);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout_MSG";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)pictureBox_KOT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK_MSG;
        private TextBox textBoxAbout_MSG;
        private PictureBox pictureBox_KOT;
    }
}