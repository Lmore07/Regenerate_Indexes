namespace Regenerate_Indexes
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serverNameTxt = new System.Windows.Forms.TextBox();
            this.databaseNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.procedureNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor";
            // 
            // serverNameTxt
            // 
            this.serverNameTxt.Location = new System.Drawing.Point(146, 39);
            this.serverNameTxt.Name = "serverNameTxt";
            this.serverNameTxt.Size = new System.Drawing.Size(161, 22);
            this.serverNameTxt.TabIndex = 2;
            // 
            // databaseNameTxt
            // 
            this.databaseNameTxt.Location = new System.Drawing.Point(146, 90);
            this.databaseNameTxt.Name = "databaseNameTxt";
            this.databaseNameTxt.Size = new System.Drawing.Size(161, 22);
            this.databaseNameTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base de datos";
            // 
            // procedureNameTxt
            // 
            this.procedureNameTxt.Location = new System.Drawing.Point(146, 141);
            this.procedureNameTxt.Name = "procedureNameTxt";
            this.procedureNameTxt.Size = new System.Drawing.Size(161, 22);
            this.procedureNameTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de P.A";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 310);
            this.Controls.Add(this.procedureNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.databaseNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverNameTxt;
        private System.Windows.Forms.TextBox databaseNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox procedureNameTxt;
        private System.Windows.Forms.Label label3;
    }
}