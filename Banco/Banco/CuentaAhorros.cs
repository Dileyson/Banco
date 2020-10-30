using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaAhorros
    {
        
            private static int numeroDeCuenta;
            private static String nombreTitular;
            private static double identificacionTitular;
            private static double saldo;


            public CuentaAhorros(int numeroCuenta, string nombre, double identificacion, double saldoA)
            {
                numeroDeCuenta = numeroCuenta;
                nombreTitular = nombre;
                identificacionTitular = identificacion;
                saldo = saldoA;
            }

            public int NumeroDeCuenta { get => numeroDeCuenta; set => numeroDeCuenta = value; }
            public String NombreTitular { get => nombreTitular; set => nombreTitular = value; }
            public double IdentificacionTitular { get => identificacionTitular; set => identificacionTitular = value; }
            public double Saldo { get => saldo; set => saldo = value; }




            public  void Consignar(double valor)
            {
                if (Banco.CuentaExiste(numeroDeCuenta))
                {
                    saldo += valor;
                }else
                {
                    AccountNoExistException ex = new AccountNoExistException("No existe el número de cuenta ingresado");
                    throw ex;
                }

                
            }

            public void Retirar(double valor)
            {
                if (Banco.CuentaExiste(NumeroDeCuenta))
                {
                    saldo -= valor;
                }
                else
                {
                    AccountExistException ex = new AccountExistException("No existe el número de cuenta ingresado");
                    throw ex;
                }
            }

            public void Transferir(int cuentaDestino, int cuentaOrigen, double valor)
            {
                List<CuentaAhorros> cuentas = Banco.Cuentas;
                foreach (CuentaAhorros cuentaO in cuentas)
                {
                    if (cuentaOrigen == cuentaO.NumeroDeCuenta)
                    {
                        if (cuentaO.Saldo >= valor)
                        {
                            foreach (CuentaAhorros cuentaD in cuentas)
                            {
                                if (cuentaDestino == cuentaD.NumeroDeCuenta)
                                {
                                    cuentaD.Saldo += valor;
                                }
                                else
                                {
                                    AccountNoExistException ex = new AccountNoExistException("No existe el número de cuenta ingresado");
                                    throw ex;
                                }
                            }   
                            cuentaO.Saldo -= valor;
                        }
                        else
                        {
                            AmountInsufficientException ex = new AmountInsufficientException("No dispone de saldo para hacer esta transaccion");
                        }

                    }
                    else
                    {
                    AccountNoExistException ex = new AccountNoExistException("No existe el número de cuenta ingresado");
                    throw ex;
                }
                }
            }

        
    }

         class CuentaAhorrosException : Exception
    {
        private String Mensaje;
        public CuentaAhorrosException(String mensaje)
        {
            Mensaje = mensaje;
        }

        public String GetMensaje()
        {
            return Mensaje;
        }
    }

    class AccountNoExistException : CuentaAhorrosException
    {
        public AccountNoExistException(String mensaje) : base(mensaje)
        {
        }
    }

    class AccountExistException : CuentaAhorrosException
    {
        public AccountExistException(String mensaje) : base(mensaje)
        {
        }
    }

    class AmountInsufficientException : CuentaAhorrosException
    {
        public AmountInsufficientException(String mensaje) : base(mensaje)
        {
        }
    }

    class NegativeAmountException : CuentaAhorrosException
    {
        public NegativeAmountException(String mensaje) : base(mensaje)
        {
        }
    }
    }

