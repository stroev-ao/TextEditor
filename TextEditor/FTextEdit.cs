using System.Windows.Forms;

namespace TextEditor
{
    public partial class FTextEdit : Form
    {
        string text;

        public FTextEdit(string text)
        {
            InitializeComponent();

            this.text = text;
        }

        private void FTextEdit_Load(object sender, System.EventArgs e)
        {
            TB_Main.Text = text;
        }

        private void B_OK_Click(object sender, System.EventArgs e)
        {
            this.Tag = TB_Main.Text;
            Close();
        }

        private void B_Cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
