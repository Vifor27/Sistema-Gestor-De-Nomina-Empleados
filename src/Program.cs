using Sistema_de_Nomina.Clases_Empleados;

namespace Sistema_de_Nomina
{
    internal class Program
    {
        // Metodo Main
        static void Main(string[] args)
        {
            // Lista Empleado y variable para logica del menu
            List<Empleado> empleados = new List<Empleado>();
            int opc;


            // Menu
            do
            {

                Console.Clear();
                Console.WriteLine("------- Gestor de nomina -------");
                Console.WriteLine("1. Agregar empleado.");
                Console.WriteLine("2. Ver reporte empleados.");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                // Asegurarse de que se haya ingresado un numero y partir en cuanto a este
                if (int.TryParse(Console.ReadLine(), out opc))
                {
                    switch (opc)
                    {
                        case 1:
                            AgregarEmpleado(empleados);
                            break;

                        case 2:
                            VerReporte(empleados);
                            break;

                    }
                }

                else
                {

                    Console.WriteLine("Asegurese de ingresar un numero, por favor...\n");
                    Console.ReadKey();
                    Console.Clear();
                }


            } while (opc != 3);
        }


        // Metodos
        static void AgregarEmpleado(List<Empleado> empleados)
        {
            // Variable para guardar el tipo
            int tipo;
            
            do
            {

                // Menu para elegir el tipo

                Console.Clear();
                Console.WriteLine("-- Seleccione tipo de empleado --");
                Console.WriteLine("1. Asalariado");
                Console.WriteLine("2. Por Horas");
                Console.WriteLine("3. Por Comisión");
                Console.WriteLine("4. Asalariado por Comisión");
                Console.WriteLine("5. Volver al menu principal");
                Console.Write("Opción: ");

                // Validar entrada
                if (!int.TryParse(Console.ReadLine(), out tipo))
                {
                    Console.WriteLine("Asegúrese de ingresar un número válido...");
                    Console.ReadKey();
                    continue;
                }

                // Opcion para volver al menu
                if (tipo == 5)
                {
                    return;
                }

                // Validar que sea un tipo válido
                if (tipo < 1 || tipo > 4)
                {
                    Console.WriteLine("\nOpcion no valida, intente de nuevo");
                    Console.ReadKey();
                    continue;
                }

                // Mandar datos basicos del empleado a la consola (Solo despues de elegir el tipo de empleado)
                // Console.Clear();

                Console.Write("\nPrimer nombre: ");
                string primerNombre = Console.ReadLine();

                Console.Write("Primer apellido: ");
                string primerApellido = Console.ReadLine();

                Console.Write("Número de seguro social: ");
                string numeroSeguroSocial = Console.ReadLine();


                switch (tipo)
                {

                    // Empleado asalariado, crea una instancia de la clase y la añade a la lista
                    case 1:

                        Console.Write("Ingrese salario semanal (RD$): ");
                        decimal salario = decimal.Parse(Console.ReadLine());
                        empleados.Add(new EmpleadoAsalariado(primerNombre, primerApellido, numeroSeguroSocial, salario));
                        break;

                    // Empleado por hora, crea instancia de la clase y la añade a la lista
                    case 2:

                        Console.Write("Ingrese sueldo por hora (RD$): ");
                        decimal sueldoHora = decimal.Parse(Console.ReadLine());
                        Console.Write("Ingrese horas trabajadas: ");
                        int horas = int.Parse(Console.ReadLine());
                        empleados.Add(new EmpleadoPorHoras(primerNombre, primerApellido, numeroSeguroSocial, sueldoHora, horas));
                        break;

                    // Empleado por comision, crea instancia de la clase y la añade a la lista
                    case 3:

                        Console.Write("Ingrese cantidad de ventas brutas: ");
                        decimal ventas = decimal.Parse(Console.ReadLine());
                        Console.Write("Ingrese la tarifa de comisión: ");
                        decimal tarifa = decimal.Parse(Console.ReadLine());
                        empleados.Add(new EmpleadoPorComision(primerNombre, primerApellido, numeroSeguroSocial, ventas, tarifa));
                        break;

                    // Empleado asalariado por comision, crea una instancia de la clase y la añade a la lista
                    case 4:

                        Console.Write("Ingrese salario base (RD$): ");
                        decimal baseSalario = decimal.Parse(Console.ReadLine());
                        Console.Write("Ingrese cantidad de ventas brutas: ");
                        decimal ventas2 = decimal.Parse(Console.ReadLine());
                        Console.Write("Ingrese tarifa de comisión: ");
                        decimal tarifa2 = decimal.Parse(Console.ReadLine());
                        empleados.Add(new EmpleadoAsalariadoPorComision(primerNombre, primerApellido, numeroSeguroSocial, ventas2, tarifa2, baseSalario));
                        break;



                }

                Console.WriteLine("\n-- Empleado agregado correctamente -- ");
                Console.ReadKey();

            } while (true);
        }

        static void VerReporte(List<Empleado> empleados)
        {
            Console.Clear();
            Console.WriteLine("-- Reporte Semanal de Pagos --\n");

            if (empleados.Count == 0)
            {
                Console.Write("No hay empleados registrados.");
                Console.ReadKey();
                return;
            }

            foreach (var emp in empleados)
            {
                Console.WriteLine(emp.GenerarDetalle());

            }

            Console.ReadKey();


        }
    }
}
