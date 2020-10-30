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
    public partial class FrmConsignar : Form
    {
        ControlValidaciones validacion = new ControlValidaciones();
        public FrmConsignar()
        {
            InitializeComponent();
        }

        private void BttRegresarConsignar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Banco.Opciones.menu.Visible = true;

        }
        private void FormConsignacionLoad(object sender, EventArgs e)
        {

        }
        private void ConsignarFormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void TxtValorConsignar_TextChanged(object sender, EventArgs e)
        {

        }
        private void BttConsignarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroCuenta = int.Parse(TxtNumeroCuentaConignar.Text);
                double valorConsignar = double.Parse(TxtValorConsignar.Text);
                if (Banco.CuentaExiste(numeroCuenta))
                {
                    foreach (CuentaAhorros cuenta in Banco.Cuentas)
                    {
                        if (cuenta.NumeroDeCuenta == numeroCuenta)
                        {
                            cuenta.Consignar(valorConsignar);
                            Banco.totalConsignaciones += 1;
                            Banco.totaltransacciones += 1;
                            MessageBox.Show("Transaccion exitosa");
                        }

                    }
                }
            }catch (AccountNoExistException ex)
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
            finally
            {
                TxtNumeroCuentaConignar.Clear();
                
            }
        }
       


    }
}
