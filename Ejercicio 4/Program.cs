/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 8/4/2025
 * Time: 14:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			 * Escriba un programa de aplicación que solicite al usuario que ingrese un número de mes (1 a 12) 
			* 	e imprima el nombre del mes correspondiente. Si el valor ingresado no 
				está en ese rango debe imprimir “Mes inválido” . Utilice la sentencia switch.
			 */
			
			Console.WriteLine("Vamos a nombrar los meses del año!");
			
			int opc;
			
			Console.WriteLine("Ingrese un numero del 1 al 12 UNICAMENTE");
			opc = int.Parse(Console.ReadLine());
			
			switch (opc)
        {
            case 1:
                Console.WriteLine("El mes n°1 es Enero");
                break;
            case 2:
                Console.WriteLine("El mes n°2 es Febrero");
                break;
            case 3:
                Console.WriteLine("El mes n°3 es Marzo");
                break;
            case 4:
                Console.WriteLine("El mes n°4 es Abril");
                break;
            case 5:
                Console.WriteLine("El mes n°5 es Mayo");
                break;
            case 6:
                Console.WriteLine("El mes n°6 es Junio");
                break;
            case 7:
                Console.WriteLine("El mes n°7 es Julio");
                break;
            case 8:
                Console.WriteLine("El mes n°8 es Agosto");
                break;
            case 9:
                Console.WriteLine("El mes n°9 es Septiembre");
                break;
            case 10:
                Console.WriteLine("El mes n°10 es Octubre");
                break;
            case 11:
                Console.WriteLine("El mes n°11 es Noviembre");
                break;
            case 12:
                Console.WriteLine("El mes n°12 es Diciembre");
                break;
            default:
                Console.WriteLine("Número incorrecto. Ingrese un número del 1 al 12.");
                break;
        }
		
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}