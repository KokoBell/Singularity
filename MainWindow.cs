using Singularity.Interfaces;

namespace Singularity
{
    public partial class MainWindow : Form
    {
        private readonly IScriptHandler _scriptHandler;
        public MainWindow(IScriptHandler scriptHandler)
        {
            _scriptHandler = scriptHandler;
            InitializeComponent();
        }

        private void BtnSelectScript_Click(object sender, EventArgs e)
        {
            txtFileName.Text = _scriptHandler.SelectScript();
            txtFileName.ReadOnly = false;
            //LblCurrentScript.Text = Path.GetFileName(_scriptHandler.SelectScript());
        }

        private void BtnRunScript_Click(object sender, EventArgs e)
        {
            string[] arguments = txtFileName.Text.Split(' ', StringSplitOptions.None);

            if (!ChkRunAsAdmin.Checked)
            {
                _scriptHandler.RunScript(arguments);
            }
            else
            {
                _scriptHandler.RunScriptAsAdmin();
                return;
            }
        }
    }
}
