/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 9/4/2025
 * Time: 00:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio_4_practica_2
{
	class Program
	{
		public static void Main(string[] args)
			
			/*
			 * Haga un programa de aplicación que lea por consola una sucesión de palabras que 
			* termina con la palabra vacía. Imprima el porcentaje de palabras que comienzan con ‘s’, 
			* la longitud de cada palabra leída y el promedio de caracteres por palabra. 
			* Ayuda: si st es una variable de tipo string, st.Length devuelve la cantidad de caracteres del string
			* 
			 */ 
			
		{
			string palabra;
			int palabrasConS = 0;
			int cantPalabras = 0;
			int totalCaracteres = 0;
			double porcentaje, promedio;
			
			Console.WriteLine("Ingresa una palabra: ");
			palabra = Console.ReadLine().ToLower();
			
			while (palabra != "") {
				
				
					if (palabra[0] == 's') {
						
						palabrasConS++;
				}
				
				
				
				Console.WriteLine("La longitud de la palabra " + palabra + " es: " + palabra.Length);
				
				totalCaracteres += palabra.Length;
				cantPalabras++;
				
				Console.WriteLine("Ingresa una palabra: ");
				palabra = Console.ReadLine().ToLower();
				
				
			}
			
			porcentaje = (double) palabrasConS * 100 / cantPalabras;
			promedio = (double) totalCaracteres / cantPalabras;
			
			
			//Console.WriteLine("Cantidad de palabras que comienzan con 's': " + palabrasConS);
			Console.WriteLine("Porcentaje de palabras que comienzan con 's': " + porcentaje + "%");
			Console.WriteLine("Promedio de caracteres por palabra: " + promedio);
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}