using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Tests
{
    [TestClass()]
    public class CuentaAhorrosTests
    {
        [TestMethod()]
        public void ConsignarTest()
        {
            Banco banco = new Banco();
            
            CuentaAhorros cuentaAhorrosPrueba1 = new CuentaAhorros(1, "primero", 12, 2000000);
            Banco.AñadirCuenta(cuentaAhorrosPrueba1);
            cuentaAhorrosPrueba1.Consignar(50000);
            double expected = 2050000;
            double result = cuentaAhorrosPrueba1.Saldo;
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void RetirarTest()
        {
            Banco banco = new Banco();

            CuentaAhorros cuentaAhorrosPrueba1 = new CuentaAhorros(1, "primero", 12, 2000000);
            Banco.AñadirCuenta(cuentaAhorrosPrueba1);
            cuentaAhorrosPrueba1.Retirar(1000000);
            double expected = 1000000;
            double result = cuentaAhorrosPrueba1.Saldo;
            Assert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void TransferirTest()
        {
            Banco banco = new Banco();

            CuentaAhorros cuentaAhorrosPrueba1 = new CuentaAhorros(1, "primero", 12, 200);
            Banco.AñadirCuenta(cuentaAhorrosPrueba1);
            CuentaAhorros cuentaAhorrosPrueba2 = new CuentaAhorros(2, "segundo", 32, 200);
            cuentaAhorrosPrueba1.Transferir(cuentaAhorrosPrueba2.NumeroDeCuenta, cuentaAhorrosPrueba1.NumeroDeCuenta, 100);
            double expected = 100;
            double result = cuentaAhorrosPrueba1.Saldo;
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void TransferirTest2()
        {
            Banco banco = new Banco();

            CuentaAhorros cuentaAhorrosPrueba1 = new CuentaAhorros(1, "primero", 12, 200);
            Banco.AñadirCuenta(cuentaAhorrosPrueba1);
            CuentaAhorros cuentaAhorrosPrueba2 = new CuentaAhorros(2, "segundo", 32, 200);
            cuentaAhorrosPrueba1.Transferir(cuentaAhorrosPrueba2.NumeroDeCuenta, cuentaAhorrosPrueba1.NumeroDeCuenta, 100);
            double expected = 300;
            double result = cuentaAhorrosPrueba2.Saldo;
            Assert.AreEqual(expected, result);
        }
    }
}