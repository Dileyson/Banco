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
    public partial class FrmRetirar : Form
    {
        public FrmRetirar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valorRetirar = double.Parse(TxtValorRetirar.Text);
                int numeroCuenta = int.Parse(TxtNumeroCuentaRetirar.Text);
                if (Banco.CuentaExiste(numeroCuenta))
                {
                    foreach (CuentaAhorros cuenta in Banco.Cuentas)
                    {
                        if (cuenta.NumeroDeCuenta == numeroCuenta)
                        {
                            cuenta.Retirar(valorRetirar);
                            Banco.totalRetiros += 1;
                            Banco.totaltransacciones += 1;
                            MessageBox.Show("Transaccion exitosa");
                        }

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
                TxtNumeroCuentaRetirar.Clear();
                TxtValorRetirar.Clear();
            }

        }

        private void TxtValorRetirar_TextChanged(object sender, EventArgs e)
        {

        }

        private void LValorRetirar_Click(object sender, EventArgs e)
        {

        }

        private void BttRegresarRetirar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Banco.Opciones.menu.Visible = true;
        }
    }
}
