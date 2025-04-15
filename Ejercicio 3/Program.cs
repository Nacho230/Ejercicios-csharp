/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 8/4/2025
 * Time: 14:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			 * Escriba un programa de aplicación que calcule la suma de dos números reales introducidos por 
* 				teclado y muestre el resultado en la consola.
				Ayuda: utilice double.Parse(st) para obtener el valor real del string st. 
			 */
			Console.WriteLine("Bienvenido, vamos a ingresar numeros reales");
			
			
			double num1, num2, suma;
			
			Console.WriteLine("Ingresa el primer numero con coma: ");
			num1 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Ingresa el segundo numero con coma: ");
			num2 = double.Parse(Console.ReadLine());
			
			
			suma = num1 + num2;
			
			Console.WriteLine("El resultado de la suma es: " + suma);
			
			
			Console.WriteLine("Tocá cualquier cosa para que se cierre el programa boludo");
			Console.ReadKey(true);
			
			
			
		}
	}
}