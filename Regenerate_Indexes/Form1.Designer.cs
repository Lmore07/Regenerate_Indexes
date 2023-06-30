namespace Regenerate_Indexes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegenerateIndexes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bienvenido,\r\nSi desea regenerar los índices, presione el botón.";
            // 
            // buttonRegenerateIndexes
            // 
            this.buttonRegenerateIndexes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegenerateIndexes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRegenerateIndexes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegenerateIndexes.Location = new System.Drawing.Point(124, 127);
            this.buttonRegenerateIndexes.Name = "buttonRegenerateIndexes";
            this.buttonRegenerateIndexes.Size = new System.Drawing.Size(183, 87);
            this.buttonRegenerateIndexes.TabIndex = 1;
            this.buttonRegenerateIndexes.Text = "Regenerar Índices";
            this.buttonRegenerateIndexes.UseVisualStyleBackColor = true;
            this.buttonRegenerateIndexes.Click += new System.EventHandler(this.buttonRegenerateIndexes_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(455, 289);
            this.Controls.Add(this.buttonRegenerateIndexes);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegenerateIndexes;
    }
}

