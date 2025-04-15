/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 15/4/2025
 * Time: 12:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;



namespace Ejercicio_5_practica_2
{
	class Program
	{
		public static void Main(string[] args)
			
		{
			/*
			 * Implemente un programa de aplicación que simule el funcionamiento de una calculadora que permita al usuario
realizar las cuatro operaciones elementales e imprimir el resultado de la operación. Para ello el programa principal
(MAIN) debe mostrar un menú de opciones con cada una de las operaciones, luego de seleccionar la operación el
programa pide ingresar dos números y para realizar la operación solicitada invoca a la función correspondiente.
Luego de obtenido el resultado, el programa principal lo imprime.
El usuario debe poder realizar tantas operaciones como desee hasta seleccionar una opción de salida.
Observación: el MAIN es quien pide los datos e informa los resultados. Cada operación se resuelve con una
función que es invocada desde el MAIN. Los datos deben pasarse como parámetros. En el caso de la operación de
división el MAIN debe verificar que pueda llevarse a cabo (que el denominador sea no nulo) antes de invocar a la
función.
			 */
			
			Console.WriteLine("Bienvenido a la primer calculadora que calcula");
			Console.WriteLine("Ingrese una opcion: ");
			Console.WriteLine("CALCULADORA \n" +
			                  "1. Para sumar \n" +
			                  "2. Para restar \n" +
			                  "3. Para multiplicar \n" +
			                  "4. Para dividir \n" +
			                  "5. Para salir!");
			
			double num1, num2;
			int opc;
			opc = int.Parse(Console.ReadLine());
			
			while (opc != 5) {
				
				switch (opc) {
					case 1:
						
						Console.WriteLine("OPCION SUMAR");
						Console.WriteLine("Ingrese el primer numero");
						num1 = double.Parse(Console.ReadLine());
						Console.WriteLine("Ingrese el segundo numero");
						num2 = double.Parse(Console.ReadLine());
						
						Console.WriteLine("El resultado de la suma es: " + (sumar(num1,num2) ) );
						
						
						break;
						
					case 2:
						Console.WriteLine("OPCION RESTAR");
						Console.WriteLine("Ingrese el primer numero");
						num1 = double.Parse(Console.ReadLine());
						Console.WriteLine("Ingrese el segundo numero");
						num2 = double.Parse(Console.ReadLine());
						
						Console.WriteLine("El resultado de la resta es: " + restar(num1,num2));
						break;
						
					case 3:
						Console.WriteLine("OPCION MULTIPLICAR");
						Console.WriteLine("Ingrese el primer numero");
						num1 = double.Parse(Console.ReadLine());
						Console.WriteLine("Ingrese el segundo numero");
						num2 = double.Parse(Console.ReadLine());
						
						Console.WriteLine("El resultado de la multiplicacion es: " + multiplicar(num1,num2));
						break;
						
					case 4:
						Console.WriteLine("OPCION DIVIDIR");
						Console.WriteLine("Ingrese el primer numero");
						num1 = double.Parse(Console.ReadLine());
						Console.WriteLine("Ingrese el segundo numero");
						num2 = double.Parse(Console.ReadLine());
						
						if ( (num1 == 0) || (num2 == 0) ) {
							
							Console.WriteLine("No se puede dividir por cero, tarado.");
						}else{
							
							Console.WriteLine("El resultado de la division es: " + dividir(num1,num2));
						}
						break;
						
						
					default:
						Console.WriteLine("Ingresá un valor del 1 al 5, pelotu");
						break;
						
				}
				
				Console.WriteLine("Ingrese una opcion: ");
				Console.WriteLine("CALCULADORA \n" +
				                  "1. Para sumar \n" +
				                  "2. Para restar \n" +
				                  "3. Para multiplicar \n" +
				                  "4. Para dividir \n" +
				                  "5. Para salir!");
				opc = int.Parse(Console.ReadLine());
				
				
			}
			Console.WriteLine("Cerrando calculadora...");
			Console.ReadKey(true);
		}
		
		
		/* Funciones: */
		
		static double sumar(double n1, double n2){
			
			return n1 + n2;
			
		}
		
		static double restar(double n1, double n2){
			return n1-n2;
		}
		
		static double multiplicar(double n1, double n2){
			return n1*n2;
		}
		
		static double dividir(double n1, double n2){
			
			return n1/n2;
		}
		
			
	}
}



	

		



