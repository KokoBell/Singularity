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
            BtnSelectScript = new Button();
            BtnRunScript = new Button();
            LblCurrentScript = new Label();
            ChkRunAsAdmin = new CheckBox();
            SuspendLayout();
            // 
            // BtnSelectScript
            // 
            BtnSelectScript.Location = new Point(12, 76);
            BtnSelectScript.Name = "BtnSelectScript";
            BtnSelectScript.Size = new Size(94, 23);
            BtnSelectScript.TabIndex = 0;
            BtnSelectScript.Text = "Select Script";
            BtnSelectScript.UseVisualStyleBackColor = true;
            BtnSelectScript.Click += BtnSelectScript_Click;
            // 
            // BtnRunScript
            // 
            BtnRunScript.Location = new Point(122, 76);
            BtnRunScript.Name = "BtnRunScript";
            BtnRunScript.Size = new Size(94, 23);
            BtnRunScript.TabIndex = 1;
            BtnRunScript.Text = "Run Script";
            BtnRunScript.UseVisualStyleBackColor = true;
            BtnRunScript.Click += BtnRunScript_Click;
            // 
            // LblCurrentScript
            // 
            LblCurrentScript.AutoSize = true;
            LblCurrentScript.Location = new Point(17, 31);
            LblCurrentScript.Name = "LblCurrentScript";
            LblCurrentScript.Size = new Size(0, 15);
            LblCurrentScript.TabIndex = 2;
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
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 111);
            Controls.Add(ChkRunAsAdmin);
            Controls.Add(LblCurrentScript);
            Controls.Add(BtnRunScript);
            Controls.Add(BtnSelectScript);
            MaximumSize = new Size(300, 150);
            Name = "MainWindow";
            Text = "Singularity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button BtnSelectScript;
        public Button BtnRunScript;
        public Label LblCurrentScript;
        public CheckBox ChkRunAsAdmin;
    }
}
