namespace Banco
{
    partial class FrmResgistrarCuenta
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
            this.TxtNombreTitular = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LIdentificacion = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.LSaldo = new System.Windows.Forms.Label();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.BttRegistrar = new System.Windows.Forms.Button();
            this.BttRegresarRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNombreTitular
            // 
            this.TxtNombreTitular.Location = new System.Drawing.Point(181, 81);
            this.TxtNombreTitular.Name = "TxtNombreTitular";
            this.TxtNombreTitular.Size = new System.Drawing.Size(305, 20);
            this.TxtNombreTitular.TabIndex = 0;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(178, 56);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(125, 13);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Ingrese nombre del titular";
            // 
            // LIdentificacion
            // 
            this.LIdentificacion.AutoSize = true;
            this.LIdentificacion.Location = new System.Drawing.Point(178, 115);
            this.LIdentificacion.Name = "LIdentificacion";
            this.LIdentificacion.Size = new System.Drawing.Size(216, 13);
            this.LIdentificacion.TabIndex = 4;
            this.LIdentificacion.Text = "Ingrese el numero de identificacion del titular";
            this.LIdentificacion.Click += new System.EventHandler(this.LIdentificacion_Click);
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(181, 131);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(305, 20);
            this.TxtIdentificacion.TabIndex = 5;
            this.TxtIdentificacion.TextChanged += new System.EventHandler(this.TxtIdentificacion_TextChanged);
            // 
            // LSaldo
            // 
            this.LSaldo.AutoSize = true;
            this.LSaldo.Location = new System.Drawing.Point(178, 170);
            this.LSaldo.Name = "LSaldo";
            this.LSaldo.Size = new System.Drawing.Size(114, 13);
            this.LSaldo.TabIndex = 6;
            this.LSaldo.Text = "Ingrese el saldo Actual";
            this.LSaldo.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Location = new System.Drawing.Point(181, 186);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(305, 20);
            this.TxtSaldo.TabIndex = 7;
            // 
            // BttRegistrar
            // 
            this.BttRegistrar.Location = new System.Drawing.Point(273, 277);
            this.BttRegistrar.Name = "BttRegistrar";
            this.BttRegistrar.Size = new System.Drawing.Size(136, 46);
            this.BttRegistrar.TabIndex = 8;
            this.BttRegistrar.Text = "Registrar";
            this.BttRegistrar.UseVisualStyleBackColor = true;
            this.BttRegistrar.Click += new System.EventHandler(this.BttRegistrar_Click);
            // 
            // BttRegresarRegistrar
            // 
            this.BttRegresarRegistrar.Location = new System.Drawing.Point(38, 13);
            this.BttRegresarRegistrar.Name = "BttRegresarRegistrar";
            this.BttRegresarRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BttRegresarRegistrar.TabIndex = 9;
            this.BttRegresarRegistrar.Text = "Regresar";
            this.BttRegresarRegistrar.UseVisualStyleBackColor = true;
            this.BttRegresarRegistrar.Click += new System.EventHandler(this.BttRegresarRegistrar_Click);
            // 
            // FrmResgistrarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 360);
            this.Controls.Add(this.BttRegresarRegistrar);
            this.Controls.Add(this.BttRegistrar);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.LSaldo);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.LIdentificacion);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.TxtNombreTitular);
            this.Name = "FrmResgistrarCuenta";
            this.Text = "RegistrarCuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombreTitular;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LIdentificacion;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label LSaldo;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.Button BttRegistrar;
        private System.Windows.Forms.Button BttRegresarRegistrar;
    }
}