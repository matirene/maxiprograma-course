using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:

                        i5 (1)	    i7 (2)	     i9 (3)
            8 RAM (1)	USD 800	    USD 900	    USD 1200
            16 RAM (2)	USD 900	    USD 1000	USD 1400
            32 RAM (3)	USD 1000	USD 1400	USD 2000

            Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un 
            costo  adicional de USD 300. Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no 
            (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.
            */

            int opcP, opcMR, opcD, monto;

            Console.WriteLine("Ingrese la opcion del procesador elegido: ");
            opcP = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la opcion de la memoria ram elegida: ");
            opcMR = int.Parse(Console.ReadLine());
            Console.WriteLine("Queres extender el tamaño del disco? 1-Si 2-No");
            opcD = int.Parse(Console.ReadLine());

            monto = 0;

            switch(opcP){
                case 1:
                switch(opcMR){
                    case 1:
                        monto = 800;
                        break;
                    case 2:
                        monto = 900;
                        break;
                    case 3:
                        monto = 1000;
                        break;
                }
                break;
                case 2:
                    switch(opcMR){
                    case 1:
                        monto = 900;
                        break;
                    case 2:
                        monto = 1000;
                        break;
                    case 3:
                        monto = 1400;
                        break;
                }
                break;
                case 3:
                    switch(opcMR){
                    case 1:
                        monto = 1200;
                        break;
                    case 2:
                        monto = 1400;
                        break;
                    case 3:
                        monto = 2000;
                        break;
                }
                break;
            }

            if (opcD == 1){
                monto += 300;
            }
            
            Console.WriteLine("El monto final es: " + monto);
        }
    }
}
