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
    public partial class FrmResgistrarCuenta : Form
    {
        Banco banco = new Banco();
        ControlValidaciones validacion = new ControlValidaciones();

        public FrmResgistrarCuenta()
        {
            InitializeComponent();
        }

        private void LNumeroDeCuenta_Click(object sender, EventArgs e)
        {

        }

        private void LIdentificacion_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BttRegresarRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Banco.Opciones.menu.Visible = true;
            
        }

        private void BttRegistrar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numeroCuenta = random.Next(1, 100); 
            try
            {
                String nombre = (TxtNombreTitular.Text);
                double identificacion = double.Parse(TxtIdentificacion.Text);
                double saldo = double.Parse(TxtSaldo.Text); 
                
                if (saldo >= 2000000)
                {
                    saldo = (saldo* 0.05) + saldo;
                }

                CuentaAhorros nuevaCuenta = new CuentaAhorros(numeroCuenta, nombre, identificacion, saldo);
                int contador = 0;
                if (Banco.Cuentas.Count== 0)
                {
                    Banco.AñadirCuenta(nuevaCuenta);
                    TxtNombreTitular.Clear();
                    TxtIdentificacion.Clear();
                    TxtSaldo.Clear();
                    MessageBox.Show("Registro Exitoso, su numero de cuenta es: " + numeroCuenta);
                    contador = 0;
                }
                else
                {
                    while(contador < Banco.Cuentas.Count)
                    {
                        
                        if (nuevaCuenta.IdentificacionTitular == Banco.Cuentas[contador].IdentificacionTitular)
                        {
                            
                            throw new AccountExistException("El usuario ya esta registrado");

                        }
                        else
                        {
                            Banco.AñadirCuenta(nuevaCuenta);
                            TxtNombreTitular.Clear();
                            TxtIdentificacion.Clear();
                            TxtSaldo.Clear();
                            MessageBox.Show("Registro Exitoso " + numeroCuenta);
                                                    }
                        contador++;
                    }
                    contador = 0;

                }

            }
            catch (AccountExistException ex)
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
                TxtNombreTitular.Clear();
                TxtIdentificacion.Clear();
                TxtSaldo.Clear();
            }
        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
