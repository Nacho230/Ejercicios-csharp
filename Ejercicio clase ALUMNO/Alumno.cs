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
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno
	{
		private string nombre;
		private string apellido;
		private int edad;
		private int legajo;
		private double nota;
		
		
			
		public Alumno()
		{
		}
		
		public Alumno(string nombre, string apellido, int edad, int legajo, double nota){
			
			this.nombre = nombre;
			this.apellido = apellido;
			this.edad = edad;
			this.legajo = legajo;
			this.nota = nota;
			
		}
		
		public void imprimir(){
			Console.WriteLine("Nombre y apellido: " + nombre +" "+ apellido +"\n Edad: " + edad + "\n Legajo: " + legajo + "\n Nota: " + nota);
		}
		
		public string Nombre{
			get{
				return nombre;
			}
			set{
				nombre = value;
			}
		}
		
		public string Apellido{
			get{
				return apellido;
			}
			set{
				apellido = value;
			}
		}
		
		public int Edad{
			get{
				return edad;
			}
			set{
				edad = value;
			}
		}
		
		public int Legajo{
			get{
				return legajo;
			}
			set{
				legajo = value;
			}
		}
		
		public double Nota{
			get{
				return nota;
			}
			set{
				nota = value;
			}
		}
		
		
		}
		
	}

