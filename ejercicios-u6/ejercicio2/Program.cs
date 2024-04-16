using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2. Se dispone de una lista de 5 sublistas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

                - El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
                - Informar cuántos grupos están formados por todos números ordenados de mayor a menor. */

            Console.WriteLine("Inicio del programa");

            int n, countNum, countImp, numGrupo, porcentaje, grupo = 0, mayor = 0;
            int mayorOrd, gruposOrd = 0;
            bool ordenado;

            for (int x = 0; x < 5; x++)
            {   
                countNum = 0;
                countImp = 0;

                ordenado = true;

                Console.WriteLine("--------- Lista numero: " + (x + 1) + (" ---------"));

                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                mayorOrd = n;

                while (n != 0)
                {
                    // PUNTO A.
                    countNum++;

                    if (n % 2 != 0)
                        countImp++;

                    // PUNTO B.
                    if ( n <= mayorOrd)
                        mayorOrd = n;
                    else
                        ordenado = false;

                    Console.WriteLine("Ingrese un numero: ");
                    n = int.Parse(Console.ReadLine());

                } // FIN DEL WHILE.

                // PUNTO A.
                porcentaje = (countImp * 100) / countNum;
                Console.WriteLine("El porcentaje de impares en la lista " + (x + 1) + " es: " + porcentaje + "%");

                if(porcentaje > mayor){
                    mayor = porcentaje;
                    grupo = x + 1;
                }

                // PUNTO B.
                if(ordenado){
                    gruposOrd++;
                    Console.WriteLine("La lista " + (x + 1) + " esta ORDENADA de mayor a menor");
                } else {
                    Console.WriteLine("La lista " + (x + 1) + " NO esta ORDENADA de mayor a menor");
                }


                Console.WriteLine("--------- Fin de la lista numero: " + (x + 1) + (" ---------"));

            } // FIN DEL FOR.

            Console.WriteLine("El grupo con mayor porcentaje de impares es el: " + grupo);

            Console.WriteLine("La cantidad de grupos ordenados son: " + gruposOrd);

            Console.WriteLine("Fin del programa");
        }
    }
}
