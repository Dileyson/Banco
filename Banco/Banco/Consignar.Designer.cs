namespace Banco
{
    partial class FrmConsignar
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
            this.LTituloConsignar = new System.Windows.Forms.Label();
            this.TxtNumeroCuentaConignar = new System.Windows.Forms.TextBox();
            this.LMontoConsignar = new System.Windows.Forms.Label();
            this.TxtValorConsignar = new System.Windows.Forms.TextBox();
            this.BttConsignarCuenta = new System.Windows.Forms.Button();
            this.BttRegresarConsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LTituloConsignar
            // 
            this.LTituloConsignar.AutoSize = true;
            this.LTituloConsignar.Location = new System.Drawing.Point(94, 32);
            this.LTituloConsignar.Name = "LTituloConsignar";
            this.LTituloConsignar.Size = new System.Drawing.Size(136, 13);
            this.LTituloConsignar.TabIndex = 0;
            this.LTituloConsignar.Text = "Ingrese cuenta a consignar";
            // 
            // TxtNumeroCuentaConignar
            // 
            this.TxtNumeroCuentaConignar.Location = new System.Drawing.Point(96, 62);
            this.TxtNumeroCuentaConignar.Name = "TxtNumeroCuentaConignar";
            this.TxtNumeroCuentaConignar.Size = new System.Drawing.Size(193, 20);
            this.TxtNumeroCuentaConignar.TabIndex = 1;
            // 
            // LMontoConsignar
            // 
            this.LMontoConsignar.AutoSize = true;
            this.LMontoConsignar.Location = new System.Drawing.Point(94, 85);
            this.LMontoConsignar.Name = "LMontoConsignar";
            this.LMontoConsignar.Size = new System.Drawing.Size(137, 13);
            this.LMontoConsignar.TabIndex = 2;
            this.LMontoConsignar.Text = "Ingrese el valor a consignar";
            // 
            // TxtValorConsignar
            // 
            this.TxtValorConsignar.Location = new System.Drawing.Point(97, 101);
            this.TxtValorConsignar.Name = "TxtValorConsignar";
            this.TxtValorConsignar.Size = new System.Drawing.Size(193, 20);
            this.TxtValorConsignar.TabIndex = 3;
            this.TxtValorConsignar.TextChanged += new System.EventHandler(this.TxtValorConsignar_TextChanged);
            // 
            // BttConsignarCuenta
            // 
            this.BttConsignarCuenta.Location = new System.Drawing.Point(96, 143);
            this.BttConsignarCuenta.Name = "BttConsignarCuenta";
            this.BttConsignarCuenta.Size = new System.Drawing.Size(117, 31);
            this.BttConsignarCuenta.TabIndex = 4;
            this.BttConsignarCuenta.Text = "Consignar";
            this.BttConsignarCuenta.UseVisualStyleBackColor = true;
            this.BttConsignarCuenta.Click += new System.EventHandler(this.BttConsignarCuenta_Click);
            // 
            // BttRegresarConsignar
            // 
            this.BttRegresarConsignar.Location = new System.Drawing.Point(13, 13);
            this.BttRegresarConsignar.Name = "BttRegresarConsignar";
            this.BttRegresarConsignar.Size = new System.Drawing.Size(75, 23);
            this.BttRegresarConsignar.TabIndex = 5;
            this.BttRegresarConsignar.Text = "Regresar";
            this.BttRegresarConsignar.UseVisualStyleBackColor = true;
            this.BttRegresarConsignar.Click += new System.EventHandler(this.BttRegresarConsignar_Click);
            // 
            // FrmConsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 268);
            this.Controls.Add(this.BttRegresarConsignar);
            this.Controls.Add(this.BttConsignarCuenta);
            this.Controls.Add(this.TxtValorConsignar);
            this.Controls.Add(this.LMontoConsignar);
            this.Controls.Add(this.TxtNumeroCuentaConignar);
            this.Controls.Add(this.LTituloConsignar);
            this.Name = "FrmConsignar";
            this.Text = "Consignar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsignarFormClosed);
            this.Click += new System.EventHandler(this.FormConsignacionLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloConsignar;
        private System.Windows.Forms.TextBox TxtNumeroCuentaConignar;
        private System.Windows.Forms.Label LMontoConsignar;
        private System.Windows.Forms.TextBox TxtValorConsignar;
        private System.Windows.Forms.Button BttConsignarCuenta;
        private System.Windows.Forms.Button BttRegresarConsignar;
    }
}