/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 15/4/2025
 * Time: 15:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio_clase_ALUMNO
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Alumno al = new Alumno("Ignacio", "Quiroga", 20, 12345678, 10);
			
			al.imprimir();
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}