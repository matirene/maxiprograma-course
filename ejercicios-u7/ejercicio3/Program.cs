using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
            Mostrar el resultado en pantalla. Ejemplo:
                CADENA FUENTE: “La mar estaba serena"
                CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
                CADENA RESULTADO: “Li mir estibi sereni" */

            char[] frase = new char[31];
            char letra, letraActual, letraNueva;
            int indice;

            // Solicitamos la frase y la guardamos.
            Console.WriteLine("Ingrese la frase, letra por letra.");
            letra = char.Parse(Console.ReadLine());

            int countChar = 0;

            while (letra != '.' && countChar < 30)
            {
                frase[countChar] = letra;
                letra = char.Parse(Console.ReadLine());
                countChar++;  
            }
            frase[countChar] = '\0';

            Console.Write("La frase ingresada es: ");
            indice = 0;
            while (frase[indice] != '\0')
            {
                Console.Write(frase[indice]);
                indice++;
            }
        
            // Solicitamos las letras.
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese la letra a reemplazar:");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra reemplazante:");
            letraNueva = char.Parse(Console.ReadLine());

            //Modificamos la frase.
            indice = 0;
            while (frase[indice] != '\0')
            {
                if(frase[indice] == letraActual)
                    frase[indice] = letraNueva;

                indice++;
            }

            Console.Write("La nueva frase es: ");
            indice = 0;
            while (frase[indice] != '\0')
            {
                Console.Write(frase[indice]);
                indice++;
            }
        }
    }
}
