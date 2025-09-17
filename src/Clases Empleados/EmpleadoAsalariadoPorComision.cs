using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nomina.Clases_Empleados
{
    // Clase hija empleado asalariado por comision, hereda de clase padre EmpleadoPorComision
    internal class EmpleadoAsalariadoPorComision : EmpleadoPorComision
    {
        // Propiedades
        public decimal salarioBase { get; set; }

        // Consctructor
        public EmpleadoAsalariadoPorComision(string primerNombre, string apellidoPaterno, string nss, decimal ventasBrutas, decimal tarifaComision, decimal salarioBase)
                      : base(primerNombre, apellidoPaterno, nss, ventasBrutas, tarifaComision)
        {
            this.salarioBase = salarioBase;
        }

        // Metodos sobrescritos
        public override decimal CalcularPagoSemanal()
        {
            // Salario base mas comisiones
            return salarioBase + (ventasBrutas * tarifaComision);
        }

        public override string GenerarDetalle()
        {
           return $"Asalariado mas comision: {primerNombre} {primerApellido} | NSS: {numeroSeguroSocial} | Ventas: {ventasBrutas:C} | Base: {salarioBase:C} | Pago: {CalcularPagoSemanal():C}";
        }
    }
}
