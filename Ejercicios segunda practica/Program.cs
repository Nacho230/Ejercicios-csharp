/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 8/4/2025
 * Time: 23:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicios_segunda_practica
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			 * ¿Cuál es el problema del código siguiente y cómo se soluciona? Qué valores imprime?
			 * El problema del codigo es definir a la variable i previo al bucle for, en el cual se
			 * instancia la variable i, provocando una redundancia. Lo solucioné comentando "int i = 0".
			 * Imprime los numeros del 1 al 10.
			 */
			//int i=0;
			
			for(int i=1; i<=10;) {
				Console.WriteLine(i++);
			}
			Console.ReadKey();
		}
	}
}
	
	
	
	
	
	
	
	
	
	