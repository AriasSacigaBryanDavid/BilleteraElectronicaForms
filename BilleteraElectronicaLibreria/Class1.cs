using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilleteraElectronicaLibreria
{
 
    public class CuentaCorriente
    {
        private String numeroCuenta;
        private String DNI;
        private Decimal saldo;

        //Todo_revisar si es necesario set

        public decimal Saldo { get => saldo; set => saldo = value; }

        public CuentaCorriente()
        {
            
        }
        public CuentaCorriente(String numeroCuenta,String DNI,Decimal saldo)
        {
            this.numeroCuenta = numeroCuenta;
            this.DNI = DNI;
            this.Saldo = saldo;
        }

     
    }
}
