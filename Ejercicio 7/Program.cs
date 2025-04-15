/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 8/4/2025
 * Time: 14:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio_7
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			/*
			 * Implemente un programa de aplicación que permita al usuario ingresar por consola una sucesión de números
				que finaliza con un 0. Informar al final del proceso cuál es 
				la cantidad total de números ingresados y el porcentaje de números mayores a 10 de la sucesión.
			 */
			
			Console.WriteLine("Bienvenido, vamos a ingresar una sucesion de numeros!");
			
			int num;
			int porcentaje10 = 0;
			int aux = 0;
			
			Console.WriteLine("Ingresa un numero: ");
			num = int.Parse(Console.ReadLine());
			
			
			while (num != 0) {
				
				aux++;
				
				if (num > 10) {
					
					porcentaje10++;
				}
				
				
				Console.WriteLine("Ingresa otro numero: ");
				num = int.Parse(Console.ReadLine()); 
				
				
			}
			
			Console.WriteLine("La cantidad de numeros ingresados son: " + aux);
			Console.WriteLine("La cantidad de numeros mayor a 10 ingresados son: " + (porcentaje10 * 100 / aux) + "%");
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}