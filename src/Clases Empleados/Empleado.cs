using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nomina
{   
    // Clase abstracta base para Empleado
    public abstract class Empleado
    {
        // Propiedades
        public string primerNombre { get; set; }
        public string primerApellido { get; set; }
        public string numeroSeguroSocial { get; set; }

        // Constructor
        protected Empleado (String primerNombre, String primerApellido, string numeroSeguroSocial)
        {
            this.primerNombre = primerNombre;
            this.primerApellido = primerApellido;
            this.numeroSeguroSocial = numeroSeguroSocial;
        }

        // Metodos base
        public abstract decimal CalcularPagoSemanal();
        public abstract string GenerarDetalle();

    }


}
