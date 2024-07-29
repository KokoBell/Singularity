namespace Singularity
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            BtnSelectScript = new Button();
            BtnRunScript = new Button();
            flLayout = new FlowLayoutPanel();
            txtFileName = new TextBox();
            MainMenuStrip = new MenuStrip();
            runAsAdministratorMenuItem = new ToolStripMenuItem();
            runAsAdministratorToolStripMenuItem = new ToolStripMenuItem();
            flLayout.SuspendLayout();
            MainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // BtnSelectScript
            // 
            BtnSelectScript.Location = new Point(12, 110);
            BtnSelectScript.Name = "BtnSelectScript";
            BtnSelectScript.Size = new Size(94, 23);
            BtnSelectScript.TabIndex = 0;
            BtnSelectScript.Text = "Select Script";
            BtnSelectScript.UseVisualStyleBackColor = true;
            BtnSelectScript.Click += BtnSelectScript_Click;
            // 
            // BtnRunScript
            // 
            BtnRunScript.Location = new Point(129, 110);
            BtnRunScript.Name = "BtnRunScript";
            BtnRunScript.Size = new Size(94, 23);
            BtnRunScript.TabIndex = 1;
            BtnRunScript.Text = "Run Script";
            BtnRunScript.UseVisualStyleBackColor = true;
            BtnRunScript.Click += BtnRunScript_Click;
            // 
            // flLayout
            // 
            flLayout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flLayout.AutoSize = true;
            flLayout.BackColor = SystemColors.Control;
            flLayout.Controls.Add(txtFileName);
            flLayout.Location = new Point(12, 27);
            flLayout.Name = "flLayout";
            flLayout.Size = new Size(214, 76);
            flLayout.TabIndex = 4;
            // 
            // txtFileName
            // 
            txtFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFileName.Location = new Point(3, 3);
            txtFileName.Multiline = true;
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(208, 70);
            txtFileName.TabIndex = 0;
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { runAsAdministratorMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(244, 24);
            MainMenuStrip.TabIndex = 5;
            MainMenuStrip.Text = "Options";
            // 
            // runAsAdministratorMenuItem
            // 
            runAsAdministratorMenuItem.DropDownItems.AddRange(new ToolStripItem[] { runAsAdministratorToolStripMenuItem });
            runAsAdministratorMenuItem.Name = "runAsAdministratorMenuItem";
            runAsAdministratorMenuItem.Size = new Size(61, 20);
            runAsAdministratorMenuItem.Text = "Options";
            // 
            // runAsAdministratorToolStripMenuItem
            // 
            runAsAdministratorToolStripMenuItem.CheckOnClick = true;
            runAsAdministratorToolStripMenuItem.Name = "runAsAdministratorToolStripMenuItem";
            runAsAdministratorToolStripMenuItem.Size = new Size(187, 22);
            runAsAdministratorToolStripMenuItem.Text = "Run As Administrator";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 141);
            Controls.Add(MainMenuStrip);
            Controls.Add(flLayout);
            Controls.Add(BtnRunScript);
            Controls.Add(BtnSelectScript);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(260, 180);
            Name = "MainWindow";
            Text = "Singularity";
            flLayout.ResumeLayout(false);
            flLayout.PerformLayout();
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button BtnSelectScript;
        public Button BtnRunScript;
        private FlowLayoutPanel flLayout;
        public TextBox txtFileName;
        private ContextMenuStrip MainMenu;
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem runAsAdministratorMenuItem;
        private ToolStripMenuItem runAsAdministratorToolStripMenuItem;
    }
}
