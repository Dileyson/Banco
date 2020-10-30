namespace Banco
{
    partial class FrmRetirar
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
            this.LCuentaRetirar = new System.Windows.Forms.Label();
            this.TxtNumeroCuentaRetirar = new System.Windows.Forms.TextBox();
            this.LValorRetirar = new System.Windows.Forms.Label();
            this.TxtValorRetirar = new System.Windows.Forms.TextBox();
            this.BttRetirarCuenta = new System.Windows.Forms.Button();
            this.BttRegresarRetirar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LCuentaRetirar
            // 
            this.LCuentaRetirar.AutoSize = true;
            this.LCuentaRetirar.Location = new System.Drawing.Point(97, 31);
            this.LCuentaRetirar.Name = "LCuentaRetirar";
            this.LCuentaRetirar.Size = new System.Drawing.Size(116, 13);
            this.LCuentaRetirar.TabIndex = 0;
            this.LCuentaRetirar.Text = "Ingrese cuenta a retirar";
            // 
            // TxtNumeroCuentaRetirar
            // 
            this.TxtNumeroCuentaRetirar.Location = new System.Drawing.Point(100, 47);
            this.TxtNumeroCuentaRetirar.Name = "TxtNumeroCuentaRetirar";
            this.TxtNumeroCuentaRetirar.Size = new System.Drawing.Size(147, 20);
            this.TxtNumeroCuentaRetirar.TabIndex = 1;
            // 
            // LValorRetirar
            // 
            this.LValorRetirar.AutoSize = true;
            this.LValorRetirar.Location = new System.Drawing.Point(97, 75);
            this.LValorRetirar.Name = "LValorRetirar";
            this.LValorRetirar.Size = new System.Drawing.Size(117, 13);
            this.LValorRetirar.TabIndex = 2;
            this.LValorRetirar.Text = "Ingrese el valor a retirar";
            this.LValorRetirar.Click += new System.EventHandler(this.LValorRetirar_Click);
            // 
            // TxtValorRetirar
            // 
            this.TxtValorRetirar.Location = new System.Drawing.Point(100, 91);
            this.TxtValorRetirar.Name = "TxtValorRetirar";
            this.TxtValorRetirar.Size = new System.Drawing.Size(144, 20);
            this.TxtValorRetirar.TabIndex = 3;
            this.TxtValorRetirar.TextChanged += new System.EventHandler(this.TxtValorRetirar_TextChanged);
            // 
            // BttRetirarCuenta
            // 
            this.BttRetirarCuenta.Location = new System.Drawing.Point(121, 143);
            this.BttRetirarCuenta.Name = "BttRetirarCuenta";
            this.BttRetirarCuenta.Size = new System.Drawing.Size(103, 36);
            this.BttRetirarCuenta.TabIndex = 4;
            this.BttRetirarCuenta.Text = "Retirar";
            this.BttRetirarCuenta.UseVisualStyleBackColor = true;
            this.BttRetirarCuenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // BttRegresarRetirar
            // 
            this.BttRegresarRetirar.Location = new System.Drawing.Point(13, 13);
            this.BttRegresarRetirar.Name = "BttRegresarRetirar";
            this.BttRegresarRetirar.Size = new System.Drawing.Size(75, 23);
            this.BttRegresarRetirar.TabIndex = 5;
            this.BttRegresarRetirar.Text = "Regresar";
            this.BttRegresarRetirar.UseVisualStyleBackColor = true;
            this.BttRegresarRetirar.Click += new System.EventHandler(this.BttRegresarRetirar_Click);
            // 
            // FrmRetirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 223);
            this.Controls.Add(this.BttRegresarRetirar);
            this.Controls.Add(this.BttRetirarCuenta);
            this.Controls.Add(this.TxtValorRetirar);
            this.Controls.Add(this.LValorRetirar);
            this.Controls.Add(this.TxtNumeroCuentaRetirar);
            this.Controls.Add(this.LCuentaRetirar);
            this.Name = "FrmRetirar";
            this.Text = "Retirar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCuentaRetirar;
        private System.Windows.Forms.TextBox TxtNumeroCuentaRetirar;
        private System.Windows.Forms.Label LValorRetirar;
        private System.Windows.Forms.TextBox TxtValorRetirar;
        private System.Windows.Forms.Button BttRetirarCuenta;
        private System.Windows.Forms.Button BttRegresarRetirar;
    }
}