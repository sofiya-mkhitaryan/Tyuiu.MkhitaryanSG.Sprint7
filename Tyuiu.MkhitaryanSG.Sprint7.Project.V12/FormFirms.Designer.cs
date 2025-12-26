namespace Tyuiu.MkhitaryanSG.Sprint7.Project.V12
{
    partial class FormFirms_MSG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFirms_MSG));
            buttonBack_MSG = new Button();
            textBoxName_MSG = new TextBox();
            textBoxAddress_MSG = new TextBox();
            textBoxPhone_MSG = new TextBox();
            textBoxNote_MSG = new TextBox();
            listBoxFirms_MSG = new ListBox();
            labelSearch_MSG = new Label();
            textBoxSearch_MSG = new TextBox();
            buttonSearch_MSG = new Button();
            panelLeft_MSG = new Panel();
            labelCount_MSG = new Label();
            labelLIstTitle_MSG = new Label();
            panelRight_MSG = new Panel();
            labelInfFirm = new Label();
            labelNote = new Label();
            labelPhone = new Label();
            labelAddress = new Label();
            labelName = new Label();
            panelStatus = new Panel();
            labelStatus_MSG = new Label();
            buttonSave_MSG = new Button();
            panelPoisk = new Panel();
            panelLeft_MSG.SuspendLayout();
            panelRight_MSG.SuspendLayout();
            panelStatus.SuspendLayout();
            panelPoisk.SuspendLayout();
            SuspendLayout();
            // 
            // buttonBack_MSG
            // 
            buttonBack_MSG.Image = (Image)resources.GetObject("buttonBack_MSG.Image");
            buttonBack_MSG.Location = new Point(738, 0);
            buttonBack_MSG.Name = "buttonBack_MSG";
            buttonBack_MSG.Size = new Size(45, 40);
            buttonBack_MSG.TabIndex = 0;
            buttonBack_MSG.UseVisualStyleBackColor = true;
            buttonBack_MSG.Click += buttonBack_MSG_Click;
            // 
            // textBoxName_MSG
            // 
            textBoxName_MSG.Location = new Point(3, 66);
            textBoxName_MSG.Name = "textBoxName_MSG";
            textBoxName_MSG.Size = new Size(497, 27);
            textBoxName_MSG.TabIndex = 2;
            // 
            // textBoxAddress_MSG
            // 
            textBoxAddress_MSG.Location = new Point(3, 124);
            textBoxAddress_MSG.Name = "textBoxAddress_MSG";
            textBoxAddress_MSG.Size = new Size(497, 27);
            textBoxAddress_MSG.TabIndex = 3;
            // 
            // textBoxPhone_MSG
            // 
            textBoxPhone_MSG.Location = new Point(3, 189);
            textBoxPhone_MSG.Name = "textBoxPhone_MSG";
            textBoxPhone_MSG.Size = new Size(497, 27);
            textBoxPhone_MSG.TabIndex = 4;
            // 
            // textBoxNote_MSG
            // 
            textBoxNote_MSG.Location = new Point(3, 262);
            textBoxNote_MSG.Multiline = true;
            textBoxNote_MSG.Name = "textBoxNote_MSG";
            textBoxNote_MSG.ScrollBars = ScrollBars.Vertical;
            textBoxNote_MSG.Size = new Size(497, 119);
            textBoxNote_MSG.TabIndex = 5;
            // 
            // listBoxFirms_MSG
            // 
            listBoxFirms_MSG.FormattingEnabled = true;
            listBoxFirms_MSG.Location = new Point(13, 43);
            listBoxFirms_MSG.Name = "listBoxFirms_MSG";
            listBoxFirms_MSG.ScrollAlwaysVisible = true;
            listBoxFirms_MSG.Size = new Size(239, 304);
            listBoxFirms_MSG.TabIndex = 6;
            // 
            // labelSearch_MSG
            // 
            labelSearch_MSG.AutoSize = true;
            labelSearch_MSG.Location = new Point(3, 6);
            labelSearch_MSG.Name = "labelSearch_MSG";
            labelSearch_MSG.Size = new Size(109, 20);
            labelSearch_MSG.TabIndex = 7;
            labelSearch_MSG.Text = "Поиск фирмы:";
            // 
            // textBoxSearch_MSG
            // 
            textBoxSearch_MSG.Location = new Point(110, 3);
            textBoxSearch_MSG.Name = "textBoxSearch_MSG";
            textBoxSearch_MSG.Size = new Size(566, 27);
            textBoxSearch_MSG.TabIndex = 8;
            // 
            // buttonSearch_MSG
            // 
            buttonSearch_MSG.Location = new Point(676, 3);
            buttonSearch_MSG.Name = "buttonSearch_MSG";
            buttonSearch_MSG.Size = new Size(94, 29);
            buttonSearch_MSG.TabIndex = 9;
            buttonSearch_MSG.Text = "Найти";
            buttonSearch_MSG.UseVisualStyleBackColor = true;
            // 
            // panelLeft_MSG
            // 
            panelLeft_MSG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelLeft_MSG.Controls.Add(labelCount_MSG);
            panelLeft_MSG.Controls.Add(labelLIstTitle_MSG);
            panelLeft_MSG.Controls.Add(listBoxFirms_MSG);
            panelLeft_MSG.Location = new Point(12, 57);
            panelLeft_MSG.Name = "panelLeft_MSG";
            panelLeft_MSG.Size = new Size(267, 387);
            panelLeft_MSG.TabIndex = 10;
            // 
            // labelCount_MSG
            // 
            labelCount_MSG.AutoSize = true;
            labelCount_MSG.Location = new Point(13, 361);
            labelCount_MSG.Name = "labelCount_MSG";
            labelCount_MSG.Size = new Size(51, 20);
            labelCount_MSG.TabIndex = 7;
            labelCount_MSG.Text = "Всего:";
            // 
            // labelLIstTitle_MSG
            // 
            labelLIstTitle_MSG.AutoSize = true;
            labelLIstTitle_MSG.Location = new Point(13, 15);
            labelLIstTitle_MSG.Name = "labelLIstTitle_MSG";
            labelLIstTitle_MSG.Size = new Size(105, 20);
            labelLIstTitle_MSG.TabIndex = 0;
            labelLIstTitle_MSG.Text = "Список фирм:";
            // 
            // panelRight_MSG
            // 
            panelRight_MSG.Controls.Add(labelInfFirm);
            panelRight_MSG.Controls.Add(labelNote);
            panelRight_MSG.Controls.Add(labelPhone);
            panelRight_MSG.Controls.Add(labelAddress);
            panelRight_MSG.Controls.Add(labelName);
            panelRight_MSG.Controls.Add(textBoxName_MSG);
            panelRight_MSG.Controls.Add(textBoxAddress_MSG);
            panelRight_MSG.Controls.Add(textBoxPhone_MSG);
            panelRight_MSG.Controls.Add(textBoxNote_MSG);
            panelRight_MSG.Location = new Point(292, 57);
            panelRight_MSG.MinimumSize = new Size(503, 387);
            panelRight_MSG.Name = "panelRight_MSG";
            panelRight_MSG.Size = new Size(503, 387);
            panelRight_MSG.TabIndex = 11;
            // 
            // labelInfFirm
            // 
            labelInfFirm.AutoSize = true;
            labelInfFirm.Location = new Point(7, 15);
            labelInfFirm.Name = "labelInfFirm";
            labelInfFirm.Size = new Size(169, 20);
            labelInfFirm.TabIndex = 17;
            labelInfFirm.Text = "Информация о фирме:";
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Location = new Point(3, 239);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(102, 20);
            labelNote.TabIndex = 16;
            labelNote.Text = "Примечание:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(3, 166);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(60, 20);
            labelPhone.TabIndex = 15;
            labelPhone.Text = "Номер:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(3, 101);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(54, 20);
            labelAddress.TabIndex = 14;
            labelAddress.Text = "Адрес:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(3, 43);
            labelName.Name = "labelName";
            labelName.Size = new Size(80, 20);
            labelName.TabIndex = 13;
            labelName.Text = "Название:";
            // 
            // panelStatus
            // 
            panelStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelStatus.Controls.Add(labelStatus_MSG);
            panelStatus.Controls.Add(buttonSave_MSG);
            panelStatus.Controls.Add(buttonBack_MSG);
            panelStatus.Location = new Point(12, 450);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(783, 40);
            panelStatus.TabIndex = 12;
            // 
            // labelStatus_MSG
            // 
            labelStatus_MSG.AutoSize = true;
            labelStatus_MSG.Location = new Point(5, 7);
            labelStatus_MSG.Name = "labelStatus_MSG";
            labelStatus_MSG.Size = new Size(55, 20);
            labelStatus_MSG.TabIndex = 8;
            labelStatus_MSG.Text = "Статус:";
            // 
            // buttonSave_MSG
            // 
            buttonSave_MSG.Location = new Point(638, 3);
            buttonSave_MSG.Name = "buttonSave_MSG";
            buttonSave_MSG.Size = new Size(94, 29);
            buttonSave_MSG.TabIndex = 2;
            buttonSave_MSG.Text = "Сохранить";
            buttonSave_MSG.UseVisualStyleBackColor = true;
            // 
            // panelPoisk
            // 
            panelPoisk.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelPoisk.Controls.Add(labelSearch_MSG);
            panelPoisk.Controls.Add(textBoxSearch_MSG);
            panelPoisk.Controls.Add(buttonSearch_MSG);
            panelPoisk.Location = new Point(12, 3);
            panelPoisk.MaximumSize = new Size(0, 39);
            panelPoisk.Name = "panelPoisk";
            panelPoisk.Size = new Size(788, 39);
            panelPoisk.TabIndex = 8;
            // 
            // FormFirms_MSG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 505);
            Controls.Add(panelPoisk);
            Controls.Add(panelStatus);
            Controls.Add(panelRight_MSG);
            Controls.Add(panelLeft_MSG);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFirms_MSG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Фирмы-реализаторы компьютеров";
            panelLeft_MSG.ResumeLayout(false);
            panelLeft_MSG.PerformLayout();
            panelRight_MSG.ResumeLayout(false);
            panelRight_MSG.PerformLayout();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            panelPoisk.ResumeLayout(false);
            panelPoisk.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack_MSG;
        private TextBox textBoxName_MSG;
        private TextBox textBoxAddress_MSG;
        private TextBox textBoxPhone_MSG;
        private TextBox textBoxNote_MSG;
        private ListBox listBoxFirms_MSG;
        private Label labelSearch_MSG;
        private TextBox textBoxSearch_MSG;
        private Button buttonSearch_MSG;
        private Panel panelLeft_MSG;
        private Label labelCount_MSG;
        private Label labelLIstTitle_MSG;
        private Panel panelRight_MSG;
        private Panel panelStatus;
        private Button buttonSave_MSG;
        private Label labelNote;
        private Label labelPhone;
        private Label labelAddress;
        private Label labelName;
        private Label labelInfFirm;
        private Label labelStatus_MSG;
        private Panel panelPoisk;
    }
}