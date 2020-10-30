using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public class Banco
    {
        private static List<CuentaAhorros> cuentas = new List<CuentaAhorros>();
        public static double totalConsignaciones = 0;
        public static double totalRetiros = 0;
        public static double mayorConsignacion = 0;
        public static double totaltransacciones = 0;
        public static string clienteMAyorConsignacion = "";
        public static List<CuentaAhorros> Cuentas { get => cuentas; }



        public static bool CuentaExiste(double numeroDeCuenta)
        {
            foreach (CuentaAhorros cuenta in cuentas)
            {
                if (cuenta.NumeroDeCuenta == numeroDeCuenta)
                {
                    return true;
                }
                
            }
            return false;

        }
        
        
        public static void AñadirCuenta(CuentaAhorros cuenta)
        {
            cuentas.Add(cuenta);
        }
        public class Opciones
        {
            public static FrmMenu menu = new FrmMenu();
            public static FrmResgistrarCuenta registrar = new FrmResgistrarCuenta();
            public static FrmTransferir transferir = new FrmTransferir();
            public static FrmConsignar Consignar = new FrmConsignar();
            public static FrmRetirar Retiro = new FrmRetirar();

        }
        class BancoException : Exception
        {
            private String mensaje;
            public BancoException(String mensaje1)
            {
                mensaje = mensaje1;
            }

            public String GetMensaje()
            {
                return mensaje;
            }
        }

       

        class AccountNoExistsException : BancoException
        {
            public AccountNoExistsException(String mensaje) : base(mensaje)
            {
            }
        }
        
}
}
