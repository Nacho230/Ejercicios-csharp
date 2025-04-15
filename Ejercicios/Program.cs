/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 15/4/2025
 * Time: 15:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace Ejercicios
{
	class Program
	{
		public static void Main(string[] args)
		{
			/* CLASE HORA TP FIRMINA */
			
			HORA h = new HORA(23,30,15);
			h.imprimir();
			
			Console.ReadKey(true);
		}
	}
}