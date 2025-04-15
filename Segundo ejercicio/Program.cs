/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 8/4/2025
 * Time: 23:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Segundo_ejercicio
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			 * Analice la siguiente porción de código para calcular la sumatoria de 1 a 10.
			 * ¿Cuál es el error? ¿Qué hace realmente? ¿Cómo se resuelve?
			 * 
			 * La porción de codigo brindada para calcular la sumatoria de 1 a 10 está mal planteada, para que funcione
			 * se debe quitar el punto y coma al final de la sentencia while para que funcione.
			 * La porción de codigo realiza una suma mientras i sea menor o igual a 10
			 * 
			 */
			
		
			
			int sum=0; 
			int i=1;
			
			while (i<=10) //---> Sin punto y coma
			{
				sum += i++;
				Console.WriteLine(sum);
				
			}
			
			//Console.WriteLine(sum);
			
			
			Console.ReadKey(true); // ---> Agregado por mi
			
			
			
			
			
			
			
			
		}
	}
}