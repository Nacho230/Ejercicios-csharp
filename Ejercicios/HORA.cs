/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 15/4/2025
 * Time: 15:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicios
{
	/// <summary>
	/// Description of HORA.
	/// </summary>
	public class HORA
	{
		
		private int hora;
		private int minuto;
		private int segundo;
		
		public HORA(){
			/*Constructor vacio*/
		}
		
		public HORA(int hora, int minuto, int segundo){
			
			this.hora = hora;
			this.minuto = minuto;
			this.segundo = segundo;
			
		}
		
		public void imprimir(){
			Console.WriteLine(hora + " HORAS, " + minuto + " MINUTOS Y " + segundo +" SEGUNDOS");
		}
		
		
	}
}
