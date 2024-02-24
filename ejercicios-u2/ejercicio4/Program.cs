using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 4
            /* Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% 
            sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por 
            un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            - SUELDO FIJO: $15000
            - 5% DE COMISION SOBRE EL TOTAL FACTURADO
            */

            // Step 0 - Crear 2 variables.
            float totalFacturado, comisión, sueldoTotal;

            // Valores constantes.
            const float sueldoFijo = 15000;
            const float porcentajeComision = 0.05F; // Usamos el prefijo F, sino lo toma como un valor "double". 

            // Step 1 - Pedir el total facturado.
            Console.WriteLine("Ingrese el total facturado del empleado");
            totalFacturado = float.Parse(Console.ReadLine());

            // Step 2 - Calcular el sueldo total.
            comisión = totalFacturado * porcentajeComision;
            sueldoTotal = sueldoFijo + comisión;

            // Step 3 - Mostrar el resultado.
            Console.WriteLine("El sueldo total a cobrar es: $" + sueldoTotal);
        }
    }
}
