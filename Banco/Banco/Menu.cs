using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FrmMenu : Form
    {
        

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Banco.Opciones.transferir.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            L.Text = "El numero total de consignaciones fue: " + Banco.totalConsignaciones.ToString();
            LTotalRetiros.Text = "El numero total de retiros fue: " + Banco.totalRetiros.ToString();
            LTotalTransaciones.Text = "El numero total de transacciones fue: " + Banco.totaltransacciones.ToString();
            LClienteMayorConsignacion.Text = "El cliente con la mayor consignacion fue: " + Banco.clienteMAyorConsignacion.ToString();
            LMayorConsignaciones.Text = "La mayor consignacion fue: " + Banco.mayorConsignacion.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Estadisticas_Click(object sender, EventArgs e)
        {

        }

        private void BttConsignar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Banco.Opciones.Consignar.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void BttRegistrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Banco.Opciones.registrar.Show();
        }

        private void BttRetirar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Banco.Opciones.Retiro.Show();
        }
    }
}
