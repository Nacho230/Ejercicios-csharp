/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 8/4/2025
 * Time: 14:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			 * Escriba un programa de aplicación que imprima en la consola todos los números impares 
			 * del intervalo [40,352] que además sean múltiplos de 3.
			 */
			Console.WriteLine("Bienvenido, repasaremos los numeros impares y multiplos de 3 en el intervalo de 40 a 352");
			
			for (int i = 40; i < 352; i++) {
				
				if ( (i%2 != 0) && (i%3 == 0) ) {
					Console.WriteLine(i);
				}
				
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}