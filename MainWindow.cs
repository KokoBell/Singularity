using Singularity.Components;
using Singularity.Interfaces;

namespace Singularity
{
    public partial class MainWindow : Form
    {
        public IScriptHandler scriptHandler = new BatHandler();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSelectScript_Click(object sender, EventArgs e)
        {
            LblCurrentScript.Text = Path.GetFileName(scriptHandler.SelectScript());
        }

        private void BtnRunScript_Click(object sender, EventArgs e)
        {
            scriptHandler.RunScript();
        }
    }
}
