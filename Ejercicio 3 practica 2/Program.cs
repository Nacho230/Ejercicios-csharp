/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 8/4/2025
 * Time: 23:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio_3_practica_2
{
	class Program
	{
		public static void Main(string[] args)
			
			/*
			 * Escriba un programa de aplicación que lea 2 palabras y determine si son palíndromos entre ellas. 
				* (Ej: “abbccd” y “dccbba” son palíndromos). 
			 */
			
		{
			Console.WriteLine("Bienvenido, palabras palindromos");
			
			string palabra1, palabra2;
			int longitud, aux;
			bool booleano = false;
			
			Console.WriteLine("Ingresa una palabra");
			palabra1 = Console.ReadLine();
			
			Console.WriteLine("Ingresa otra palabra");
			palabra2 = Console.ReadLine();
			
			
			if (palabra1.Length == palabra2.Length) {
				
				longitud = palabra1.Length;
				aux = longitud-1;
				
				for (int i = 0; i < longitud; i++) {
					
					if (palabra1[i] != palabra2[aux]) {
						
					}
					
				}
				
				
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}