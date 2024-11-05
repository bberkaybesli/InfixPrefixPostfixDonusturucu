namespace InfixPrefixPostfixConverter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInfix = new System.Windows.Forms.TextBox();
            this.btnToPostfix = new System.Windows.Forms.Button();
            this.btnToPrefix = new System.Windows.Forms.Button();
            this.lblPostfix = new System.Windows.Forms.Label();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.txtInfix.Location = new System.Drawing.Point(12, 12);
            this.txtInfix.Multiline = true;
            this.txtInfix.Name = "txtInfix";
            this.txtInfix.Size = new System.Drawing.Size(360, 60);
            this.txtInfix.TabIndex = 0;
 
            this.btnToPostfix.Location = new System.Drawing.Point(12, 78);
            this.btnToPostfix.Name = "btnToPostfix";
            this.btnToPostfix.Size = new System.Drawing.Size(175, 30);
            this.btnToPostfix.TabIndex = 1;
            this.btnToPostfix.Text = "Postfix\'e Dönüştür";
            this.btnToPostfix.UseVisualStyleBackColor = true;
            this.btnToPostfix.Click += new System.EventHandler(this.btnToPostfix_Click);

            this.btnToPrefix.Location = new System.Drawing.Point(197, 78);
            this.btnToPrefix.Name = "btnToPrefix";
            this.btnToPrefix.Size = new System.Drawing.Size(175, 30);
            this.btnToPrefix.TabIndex = 2;
            this.btnToPrefix.Text = "Prefix\'e Dönüştür";
            this.btnToPrefix.UseVisualStyleBackColor = true;
            this.btnToPrefix.Click += new System.EventHandler(this.btnToPrefix_Click);

            this.lblPostfix.AutoSize = true;
            this.lblPostfix.Location = new System.Drawing.Point(12, 121);
            this.lblPostfix.Name = "lblPostfix";
            this.lblPostfix.Size = new System.Drawing.Size(52, 16);
            this.lblPostfix.TabIndex = 3;
            this.lblPostfix.Text = "Postfix: ";

            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(12, 150);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(46, 16);
            this.lblPrefix.TabIndex = 4;
            this.lblPrefix.Text = "Prefix: ";

            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.lblPrefix);
            this.Controls.Add(this.lblPostfix);
            this.Controls.Add(this.btnToPrefix);
            this.Controls.Add(this.btnToPostfix);
            this.Controls.Add(this.txtInfix);
            this.Name = "Form1";
            this.Text = "Infix, Prefix, Postfix Dönüştürücü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtInfix;
        private System.Windows.Forms.Button btnToPostfix;
        private System.Windows.Forms.Button btnToPrefix;
        private System.Windows.Forms.Label lblPostfix;
        private System.Windows.Forms.Label lblPrefix;
    }
}
