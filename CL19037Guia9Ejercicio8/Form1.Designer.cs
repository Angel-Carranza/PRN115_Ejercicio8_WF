namespace CL19037Guia9Ejercicio8
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
            this.components = new System.ComponentModel.Container();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFrasNor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFrasDes = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(117, 56);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "INSERTE FRASE";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(248, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 56);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "LIMPIAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "FRASE INGRESADA:";
            // 
            // lblFrasNor
            // 
            this.lblFrasNor.AutoSize = true;
            this.lblFrasNor.Location = new System.Drawing.Point(156, 130);
            this.lblFrasNor.Name = "lblFrasNor";
            this.lblFrasNor.Size = new System.Drawing.Size(13, 17);
            this.lblFrasNor.TabIndex = 3;
            this.lblFrasNor.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "FRASE DESCOMPUESTA:";
            // 
            // lbFrasDes
            // 
            this.lbFrasDes.FormattingEnabled = true;
            this.lbFrasDes.ItemHeight = 16;
            this.lbFrasDes.Location = new System.Drawing.Point(9, 180);
            this.lbFrasDes.Name = "lbFrasDes";
            this.lbFrasDes.Size = new System.Drawing.Size(356, 132);
            this.lbFrasDes.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(248, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 56);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "CERRAR";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 389);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbFrasDes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFrasNor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip ttAyuda;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFrasNor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbFrasDes;
        private System.Windows.Forms.Button btnClose;
    }
}

