using System;
using BilleteraElectronicaLibreria;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilleteraElectronicaPrueba
{
    [TestClass]
    public class CuentaCorrientePrueba
    {
        [TestMethod]
        public void cuentaCorriente_aperturaCuentaConSaldoCero_saldoIgualCero()
        {
            //Arrange
            String numeroCuenta = "44445";
            String DNI = "45675789";
            Decimal saldoInicialEsperado = 0;
            Decimal saldoInicialActual;


            //do
            CuentaCorriente cuenta = new CuentaCorriente(numeroCuenta, DNI, 0);
            saldoInicialActual = cuenta.Saldo;

            //Assert
            Assert.AreEqual(saldoInicialEsperado, saldoInicialActual, "Error: El Saldo no es cero");
        }
    }
}
