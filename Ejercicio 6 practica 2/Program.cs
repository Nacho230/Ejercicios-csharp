/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 15/4/2025
 * Time: 13:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio_6_practica_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			 * Defina una función que reciba una palabra y retorne en un vector la cantidad de veces 
* 				que aparece cada vocal en dicha palabra. 
			 */
			
			Console.WriteLine("Ingrese una palabra: ");
			string palabra = Console.ReadLine();
			vocales(palabra);
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		/* Funciones */
		
		static string[] vocales(string pal){
			
			
			
			for (int i = 0; i < pal.Length; i++) {
				
			}
			
		}
	}
}