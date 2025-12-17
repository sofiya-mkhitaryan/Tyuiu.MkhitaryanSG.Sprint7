using System.Windows.Forms;
using Tyuiu.MkhitaryanSG.Sprint7.Project.V12.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonAbout_MSG_Click(object sender, EventArgs e)
        {
            FormAbout_MSG formAbout = new FormAbout_MSG();
            formAbout.ShowDialog();
        }
        private void buttonHelp_MSG_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Руководство пользователя";
        }
        private void buttonHelp_MSG_Click(object sender, EventArgs e)
        {
            FormGuide_MSG formGuide = new FormGuide_MSG();
            formGuide.ShowDialog();
        }
    }
}
