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
    public partial class FrmTransferir : Form
    {
        public FrmTransferir()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BttTransferirCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroCuentaOrigen = int.Parse(TxtNumeroCuentaOrigen.Text);
                int numeroCuentaDestino = int.Parse(TxtNumeroCuentaDestino.Text);
                double valorTransferir = int.Parse(TxtMontoTransferir.Text);
                foreach (CuentaAhorros cuenta in Banco.Cuentas)
                {
                    if (cuenta.NumeroDeCuenta == numeroCuentaOrigen)
                    {
                        cuenta.Transferir(numeroCuentaDestino, numeroCuentaOrigen, valorTransferir);
                        Banco.totalConsignaciones += 1;
                        Banco.totaltransacciones += 1;
                        MessageBox.Show("Transaccion exitosa");
                    }

                }
            }
            catch (AccountNoExistException ex)
            {
                MessageBox.Show(ex.GetMensaje());
            }
            catch (FormatException)
            {
                MessageBox.Show("Campos vacios, por favor diligencie cuenta");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Cuenta ingresada no permitida, por favor ingrese una correcta");
            }
            catch (AmountInsufficientException ex)
            {
                MessageBox.Show(ex.GetMensaje());
            }
            finally
            {
                TxtNumeroCuentaOrigen.Clear();
                TxtNumeroCuentaDestino.Clear();
                TxtMontoTransferir.Clear();
            }
        }

        private void BttRegresarTransferir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Banco.Opciones.menu.Visible = true;
        }
    }
}
