using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaHerencia
{
    public class EmpleadoBaseMasComision2 : EmpleadoPorComision
    {
        private decimal salarioBase;
        public EmpleadoBaseMasComision2(string nombre, string apellido, string nss, decimal tarifa, decimal venta) : base(nombre, apellido, nss, tarifa, venta)

        {
            salarioBase = salario;
        }

        public decimal SalarioBase { get { return salarioBase; } set { salarioBase = (value <0 } }
    }
}
