using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nomina
{
    // Clase empleado asalariado, hereda de clase padre empleado
    public class EmpleadoAsalariado : Empleado
    {
        // Propiedades
        public decimal salarioSemanal { get; set; }

        // Constructor
        public EmpleadoAsalariado (string primerNombre, string primerApellido, string numeroSeguroSocial, decimal salarioSemanal) 
            : base (primerNombre, primerApellido, numeroSeguroSocial)
        {
            this.salarioSemanal = salarioSemanal;
        }

        // Metodos sobrescritos
        public override decimal CalcularPagoSemanal()
        {
            // El empleado asalariado siempre cobra lo mismo
            return salarioSemanal;
        }

        public override string GenerarDetalle()
        {
            return $"Asalariado: {primerNombre} {primerApellido} | NSS: {numeroSeguroSocial} | Pago: {CalcularPagoSemanal():C}";
        }


    }
}
