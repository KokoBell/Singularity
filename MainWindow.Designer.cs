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
            ChkRunAsAdmin = new CheckBox();
            flLayout = new FlowLayoutPanel();
            txtFileName = new TextBox();
            flLayout.SuspendLayout();
            SuspendLayout();
            // 
            // BtnSelectScript
            // 
            BtnSelectScript.Location = new Point(12, 103);
            BtnSelectScript.Name = "BtnSelectScript";
            BtnSelectScript.Size = new Size(94, 23);
            BtnSelectScript.TabIndex = 0;
            BtnSelectScript.Text = "Select Script";
            BtnSelectScript.UseVisualStyleBackColor = true;
            BtnSelectScript.Click += BtnSelectScript_Click;
            // 
            // BtnRunScript
            // 
            BtnRunScript.Location = new Point(127, 103);
            BtnRunScript.Name = "BtnRunScript";
            BtnRunScript.Size = new Size(94, 23);
            BtnRunScript.TabIndex = 1;
            BtnRunScript.Text = "Run Script";
            BtnRunScript.UseVisualStyleBackColor = true;
            BtnRunScript.Click += BtnRunScript_Click;
            // 
            // ChkRunAsAdmin
            // 
            ChkRunAsAdmin.AutoSize = true;
            ChkRunAsAdmin.Location = new Point(12, 9);
            ChkRunAsAdmin.Name = "ChkRunAsAdmin";
            ChkRunAsAdmin.Size = new Size(137, 19);
            ChkRunAsAdmin.TabIndex = 3;
            ChkRunAsAdmin.Text = "Run as Administrator";
            ChkRunAsAdmin.UseVisualStyleBackColor = true;
            // 
            // flLayout
            // 
            flLayout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flLayout.AutoSize = true;
            flLayout.BackColor = SystemColors.Control;
            flLayout.Controls.Add(txtFileName);
            flLayout.Location = new Point(12, 34);
            flLayout.Name = "flLayout";
            flLayout.Size = new Size(214, 54);
            flLayout.TabIndex = 4;
            // 
            // txtFileName
            // 
            txtFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFileName.Location = new Point(3, 3);
            txtFileName.Multiline = true;
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(208, 48);
            txtFileName.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 141);
            Controls.Add(flLayout);
            Controls.Add(ChkRunAsAdmin);
            Controls.Add(BtnRunScript);
            Controls.Add(BtnSelectScript);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(260, 180);
            Name = "MainWindow";
            Text = "Singularity";
            flLayout.ResumeLayout(false);
            flLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button BtnSelectScript;
        public Button BtnRunScript;
        public CheckBox ChkRunAsAdmin;
        private FlowLayoutPanel flLayout;
        public TextBox txtFileName;
    }
}
