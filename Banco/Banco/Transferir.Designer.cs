namespace Banco
{
    partial class FrmTransferir
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
            this.BttTransferirCuenta = new System.Windows.Forms.Button();
            this.LCuentaOrigen = new System.Windows.Forms.Label();
            this.TxtNumeroCuentaOrigen = new System.Windows.Forms.TextBox();
            this.LCuentaDestino = new System.Windows.Forms.Label();
            this.TxtNumeroCuentaDestino = new System.Windows.Forms.TextBox();
            this.LValorTransferir = new System.Windows.Forms.Label();
            this.TxtMontoTransferir = new System.Windows.Forms.TextBox();
            this.BttRegresarTransferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BttTransferirCuenta
            // 
            this.BttTransferirCuenta.Location = new System.Drawing.Point(162, 225);
            this.BttTransferirCuenta.Name = "BttTransferirCuenta";
            this.BttTransferirCuenta.Size = new System.Drawing.Size(93, 43);
            this.BttTransferirCuenta.TabIndex = 0;
            this.BttTransferirCuenta.Text = "Transferir";
            this.BttTransferirCuenta.UseVisualStyleBackColor = true;
            this.BttTransferirCuenta.Click += new System.EventHandler(this.BttTransferirCuenta_Click);
            // 
            // LCuentaOrigen
            // 
            this.LCuentaOrigen.AutoSize = true;
            this.LCuentaOrigen.Location = new System.Drawing.Point(121, 34);
            this.LCuentaOrigen.Name = "LCuentaOrigen";
            this.LCuentaOrigen.Size = new System.Drawing.Size(125, 13);
            this.LCuentaOrigen.TabIndex = 1;
            this.LCuentaOrigen.Text = "Ingrese cuenta de origen";
            // 
            // TxtNumeroCuentaOrigen
            // 
            this.TxtNumeroCuentaOrigen.Location = new System.Drawing.Point(124, 61);
            this.TxtNumeroCuentaOrigen.Name = "TxtNumeroCuentaOrigen";
            this.TxtNumeroCuentaOrigen.Size = new System.Drawing.Size(170, 20);
            this.TxtNumeroCuentaOrigen.TabIndex = 2;
            // 
            // LCuentaDestino
            // 
            this.LCuentaDestino.AutoSize = true;
            this.LCuentaDestino.Location = new System.Drawing.Point(121, 96);
            this.LCuentaDestino.Name = "LCuentaDestino";
            this.LCuentaDestino.Size = new System.Drawing.Size(115, 13);
            this.LCuentaDestino.TabIndex = 3;
            this.LCuentaDestino.Text = "Ingrese cuenta destino";
            // 
            // TxtNumeroCuentaDestino
            // 
            this.TxtNumeroCuentaDestino.Location = new System.Drawing.Point(124, 123);
            this.TxtNumeroCuentaDestino.Name = "TxtNumeroCuentaDestino";
            this.TxtNumeroCuentaDestino.Size = new System.Drawing.Size(170, 20);
            this.TxtNumeroCuentaDestino.TabIndex = 4;
            // 
            // LValorTransferir
            // 
            this.LValorTransferir.AutoSize = true;
            this.LValorTransferir.Location = new System.Drawing.Point(121, 160);
            this.LValorTransferir.Name = "LValorTransferir";
            this.LValorTransferir.Size = new System.Drawing.Size(120, 13);
            this.LValorTransferir.TabIndex = 5;
            this.LValorTransferir.Text = "Ingrese valor a transferir";
            this.LValorTransferir.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtMontoTransferir
            // 
            this.TxtMontoTransferir.Location = new System.Drawing.Point(124, 189);
            this.TxtMontoTransferir.Name = "TxtMontoTransferir";
            this.TxtMontoTransferir.Size = new System.Drawing.Size(170, 20);
            this.TxtMontoTransferir.TabIndex = 6;
            // 
            // BttRegresarTransferir
            // 
            this.BttRegresarTransferir.Location = new System.Drawing.Point(13, 13);
            this.BttRegresarTransferir.Name = "BttRegresarTransferir";
            this.BttRegresarTransferir.Size = new System.Drawing.Size(75, 23);
            this.BttRegresarTransferir.TabIndex = 7;
            this.BttRegresarTransferir.Text = "Regresar";
            this.BttRegresarTransferir.UseVisualStyleBackColor = true;
            this.BttRegresarTransferir.Click += new System.EventHandler(this.BttRegresarTransferir_Click);
            // 
            // FrmTransferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 280);
            this.Controls.Add(this.BttRegresarTransferir);
            this.Controls.Add(this.TxtMontoTransferir);
            this.Controls.Add(this.LValorTransferir);
            this.Controls.Add(this.TxtNumeroCuentaDestino);
            this.Controls.Add(this.LCuentaDestino);
            this.Controls.Add(this.TxtNumeroCuentaOrigen);
            this.Controls.Add(this.LCuentaOrigen);
            this.Controls.Add(this.BttTransferirCuenta);
            this.Name = "FrmTransferir";
            this.Text = "Transferir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttTransferirCuenta;
        private System.Windows.Forms.Label LCuentaOrigen;
        private System.Windows.Forms.TextBox TxtNumeroCuentaOrigen;
        private System.Windows.Forms.Label LCuentaDestino;
        private System.Windows.Forms.TextBox TxtNumeroCuentaDestino;
        private System.Windows.Forms.Label LValorTransferir;
        private System.Windows.Forms.TextBox TxtMontoTransferir;
        private System.Windows.Forms.Button BttRegresarTransferir;
    }
}