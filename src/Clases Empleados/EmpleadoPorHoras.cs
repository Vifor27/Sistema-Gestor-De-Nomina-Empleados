using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nomina.Clases_Empleados
{
    // Clase hija empleado por hora, hereda de clase padre Empleado
    public class EmpleadoPorHoras : Empleado
    {
        // Propiedades
        public decimal sueldoPorHora { get; set; }
        public int horasTrabajadas { get; set; }

        // Constructor
        public EmpleadoPorHoras(string primerNombre, string primerApellido, string numeroSeguroSocial, decimal sueldoPorHora, int horasTrabajadas)
           : base (primerNombre, primerApellido, numeroSeguroSocial)
        {
            this.sueldoPorHora = sueldoPorHora;
            this.horasTrabajadas = horasTrabajadas;
        }

        // Metodos sobrescritos
        public override decimal CalcularPagoSemanal()
        {
            if (horasTrabajadas <= 40)
                return sueldoPorHora * horasTrabajadas;
            else
                // Horas extras
                return (sueldoPorHora * 40) + (sueldoPorHora * 1.5m * (horasTrabajadas - 40));
        }

        public override string GenerarDetalle()
        {
            return $"-- Por Horas: {primerNombre} {primerApellido} | NSS: {numeroSeguroSocial} | Pago por hora {sueldoPorHora} | Horas: {horasTrabajadas} | Pago: {CalcularPagoSemanal():C}";
        }
    }


    }

