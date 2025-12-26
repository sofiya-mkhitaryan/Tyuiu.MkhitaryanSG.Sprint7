using System.Windows.Forms;
using Tyuiu.MkhitaryanSG.Sprint7.Project.V12.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint7.Project.V12
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonOpen_MSG_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInstrument formInstrument = new FormInstrument();
            formInstrument.Show();
        }
        private void buttonFirms_MSG_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFirms_MSG fM = new FormFirms_MSG();
            fM.ShowDialog();
        }
        private void buttonOProgram_MSG_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGuide_MSG fG = new FormGuide_MSG();
            fG.ShowDialog();
        }
        private void buttonChart_MSG_Click(object sender, EventArgs e)
        {
            this.Hide();  // Скрываем главное меню
            FormChart_MSG fC = new FormChart_MSG();
            fC.Show();    // Используйте Show() вместо ShowDialog()
        }
    }
}
