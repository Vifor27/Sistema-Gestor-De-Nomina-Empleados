using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nomina.Clases_Empleados
{   
    // Clase hija empleado por comisiones, hereda de clase padre Empleado
    public class EmpleadoPorComision : Empleado
    {
        // Propiedades
        public decimal ventasBrutas { get; set; }
        public decimal tarifaComision { get; set; }

        // Constructor
        public EmpleadoPorComision(string primerNombre, string primerApellido, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision)
          : base(primerNombre, primerApellido, numeroSeguroSocial)
        {
            this.ventasBrutas = ventasBrutas;
            this.tarifaComision = tarifaComision;
        }

        // Metodos sobrescritos
        public override decimal CalcularPagoSemanal()
        {
            // Por cada venta, obtiene una comision
            return ventasBrutas * tarifaComision;

        }

        public override string GenerarDetalle()
        {
            return $"-- Por Comisión: {primerNombre} {primerApellido} | NSS: {numeroSeguroSocial} | Ventas: {ventasBrutas} | Pago: {CalcularPagoSemanal():C}";
        }
    }
}
