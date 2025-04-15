/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 8/4/2025
 * Time: 14:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nomyape1, nomyape2;
			int edad1, edad2;
			
			Console.WriteLine("Bienvenido, vamos a determinar quien es mayor!");
			
			Console.WriteLine("Por favor, ingresa un nombre y apellido: ");
			nomyape1 = Console.ReadLine();
			
			Console.WriteLine("Por favor, ingresa una edad: ");
			edad1 = int.Parse(Console.ReadLine());
			
			//********************************************************
			
			Console.WriteLine("Por favor, ingresa otro nombre y apellido: ");
			nomyape2 = Console.ReadLine();
			
			Console.WriteLine("Por favor, ingresa otra edad: ");
			edad2 = int.Parse(Console.ReadLine());
			
			if (edad1 > edad2) {
				
				Console.WriteLine("El mayor es: " + nomyape1 + " con " + edad1 + " años");
				
			}
			else{
				Console.WriteLine("El mayor es: " + nomyape2 + " con " + edad2 + " años");
			}
			
			Console.WriteLine("Presiona cualquier tecla para continuar!");
			Console.ReadKey(true);
			
		}
	}
}