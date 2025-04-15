/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 8/4/2025
 * Time: 13:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Primera_practica
{
	class Ejercicio1
	{
		public static void Main(string[] args)
		{
			
			string nomyape;
			int edad, dni;
			
			Console.WriteLine("Bienvenido a la aplicación que roba tus datos!");
			
			Console.WriteLine("Por favor, ingresa tu nombre y apellido: ");
			nomyape = Console.ReadLine();
			
			Console.WriteLine("Por favor, ingresa tu edad: ");
			edad = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Por favor, ingresa tu dni: ");
			dni = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Los datos ingresados son: \n" + "Nombre y apellido: " + nomyape + "\nEdad: " +
			                  edad + "\nDni: " + dni);
			
			Console.WriteLine("Presione cualquier tecla para continuar!");
			
			Console.ReadKey(true);
			
		}
	}
}