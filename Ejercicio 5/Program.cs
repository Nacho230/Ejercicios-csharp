/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 8/4/2025
 * Time: 14:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			 * Escriba un programa de aplicación que lea por teclado una secuencia de números 
				* y que imprima el valor máximo, el valor mínimo de dicho conjunto y el valor promedio.
			 */
			
			Console.WriteLine("Bienvenido, vamos a ingresar numeros!");
			
			double num;
			double valorMinimo = 9999999;
			double valorMaximo = 0;
			double suma = 0;
			double valorPromedio = 0;
			
			for (int i = 0; i < 10; i++) {
				
				Console.WriteLine("Ingresa un numero:");
				num = double.Parse(Console.ReadLine());
				
				suma = num+suma;
			
				if (num > valorMaximo) {
					
					valorMaximo = num;
				}
				
				if (num < valorMinimo) {
					
					valorMinimo = num;
				}
				
				valorPromedio = suma / (i+1);
				
				//Console.WriteLine(i);
			}
			
			
			Console.WriteLine("El valor maximo es: " + valorMaximo);
			Console.WriteLine("El valor minimo es: " + valorMinimo);
			Console.WriteLine("El valor promedio es: " + valorPromedio);

	
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}