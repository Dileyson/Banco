namespace Banco
{
    partial class FrmMenu
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BttRegistrar = new System.Windows.Forms.Button();
            this.BttConsignar = new System.Windows.Forms.Button();
            this.BttRetirar = new System.Windows.Forms.Button();
            this.BttTransferir = new System.Windows.Forms.Button();
            this.BttEstadisticas = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.Estadisticas = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.Label();
            this.LTotalRetiros = new System.Windows.Forms.Label();
            this.LMayorConsignaciones = new System.Windows.Forms.Label();
            this.LTotalTransaciones = new System.Windows.Forms.Label();
            this.LClienteMayorConsignacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // BttRegistrar
            // 
            this.BttRegistrar.Location = new System.Drawing.Point(57, 85);
            this.BttRegistrar.Name = "BttRegistrar";
            this.BttRegistrar.Size = new System.Drawing.Size(299, 31);
            this.BttRegistrar.TabIndex = 2;
            this.BttRegistrar.Text = "Registrar Cuenta";
            this.BttRegistrar.UseVisualStyleBackColor = true;
            this.BttRegistrar.Click += new System.EventHandler(this.BttRegistrar_Click);
            // 
            // BttConsignar
            // 
            this.BttConsignar.Location = new System.Drawing.Point(57, 133);
            this.BttConsignar.Name = "BttConsignar";
            this.BttConsignar.Size = new System.Drawing.Size(299, 33);
            this.BttConsignar.TabIndex = 3;
            this.BttConsignar.Text = "Consignar";
            this.BttConsignar.UseVisualStyleBackColor = true;
            this.BttConsignar.Click += new System.EventHandler(this.BttConsignar_Click);
            // 
            // BttRetirar
            // 
            this.BttRetirar.Location = new System.Drawing.Point(57, 172);
            this.BttRetirar.Name = "BttRetirar";
            this.BttRetirar.Size = new System.Drawing.Size(299, 38);
            this.BttRetirar.TabIndex = 4;
            this.BttRetirar.Text = "Retirar";
            this.BttRetirar.UseVisualStyleBackColor = true;
            this.BttRetirar.Click += new System.EventHandler(this.BttRetirar_Click);
            // 
            // BttTransferir
            // 
            this.BttTransferir.Location = new System.Drawing.Point(57, 229);
            this.BttTransferir.Name = "BttTransferir";
            this.BttTransferir.Size = new System.Drawing.Size(299, 32);
            this.BttTransferir.TabIndex = 5;
            this.BttTransferir.Text = "Transferir";
            this.BttTransferir.UseVisualStyleBackColor = true;
            this.BttTransferir.Click += new System.EventHandler(this.button1_Click);
            // 
            // BttEstadisticas
            // 
            this.BttEstadisticas.Location = new System.Drawing.Point(474, 85);
            this.BttEstadisticas.Name = "BttEstadisticas";
            this.BttEstadisticas.Size = new System.Drawing.Size(299, 36);
            this.BttEstadisticas.TabIndex = 6;
            this.BttEstadisticas.Text = "Estadisticas";
            this.BttEstadisticas.UseVisualStyleBackColor = true;
            this.BttEstadisticas.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(54, 42);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(307, 13);
            this.Titulo.TabIndex = 7;
            this.Titulo.Text = "Primero registre cuentas para poder hacer las otras operaciones";
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Estadisticas
            // 
            this.Estadisticas.AutoSize = true;
            this.Estadisticas.Location = new System.Drawing.Point(517, 42);
            this.Estadisticas.Name = "Estadisticas";
            this.Estadisticas.Size = new System.Drawing.Size(217, 13);
            this.Estadisticas.TabIndex = 8;
            this.Estadisticas.Text = "Consultar las estadisticas de las operaciones";
            this.Estadisticas.Click += new System.EventHandler(this.Estadisticas_Click);
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Location = new System.Drawing.Point(474, 159);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(0, 13);
            this.L.TabIndex = 9;
            // 
            // LTotalRetiros
            // 
            this.LTotalRetiros.AutoSize = true;
            this.LTotalRetiros.Location = new System.Drawing.Point(474, 172);
            this.LTotalRetiros.Name = "LTotalRetiros";
            this.LTotalRetiros.Size = new System.Drawing.Size(35, 13);
            this.LTotalRetiros.TabIndex = 10;
            this.LTotalRetiros.Text = "label2";
            // 
            // LMayorConsignaciones
            // 
            this.LMayorConsignaciones.AutoSize = true;
            this.LMayorConsignaciones.Location = new System.Drawing.Point(474, 185);
            this.LMayorConsignaciones.Name = "LMayorConsignaciones";
            this.LMayorConsignaciones.Size = new System.Drawing.Size(35, 13);
            this.LMayorConsignaciones.TabIndex = 11;
            this.LMayorConsignaciones.Text = "label3";
            // 
            // LTotalTransaciones
            // 
            this.LTotalTransaciones.AutoSize = true;
            this.LTotalTransaciones.Location = new System.Drawing.Point(474, 198);
            this.LTotalTransaciones.Name = "LTotalTransaciones";
            this.LTotalTransaciones.Size = new System.Drawing.Size(35, 13);
            this.LTotalTransaciones.TabIndex = 12;
            this.LTotalTransaciones.Text = "label4";
            // 
            // LClienteMayorConsignacion
            // 
            this.LClienteMayorConsignacion.AutoSize = true;
            this.LClienteMayorConsignacion.Location = new System.Drawing.Point(474, 211);
            this.LClienteMayorConsignacion.Name = "LClienteMayorConsignacion";
            this.LClienteMayorConsignacion.Size = new System.Drawing.Size(35, 13);
            this.LClienteMayorConsignacion.TabIndex = 13;
            this.LClienteMayorConsignacion.Text = "label5";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LClienteMayorConsignacion);
            this.Controls.Add(this.LTotalTransaciones);
            this.Controls.Add(this.LMayorConsignaciones);
            this.Controls.Add(this.LTotalRetiros);
            this.Controls.Add(this.L);
            this.Controls.Add(this.Estadisticas);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.BttEstadisticas);
            this.Controls.Add(this.BttTransferir);
            this.Controls.Add(this.BttRetirar);
            this.Controls.Add(this.BttConsignar);
            this.Controls.Add(this.BttRegistrar);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button BttRegistrar;
        private System.Windows.Forms.Button BttConsignar;
        private System.Windows.Forms.Button BttRetirar;
        private System.Windows.Forms.Button BttTransferir;
        private System.Windows.Forms.Button BttEstadisticas;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Estadisticas;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.Label LTotalRetiros;
        private System.Windows.Forms.Label LMayorConsignaciones;
        private System.Windows.Forms.Label LTotalTransaciones;
        private System.Windows.Forms.Label LClienteMayorConsignacion;
    }
}

