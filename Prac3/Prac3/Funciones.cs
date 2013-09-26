using System;

namespace Prac3
{
	public class Funciones
	{
		Tabla dat=new Tabla();
		public Funciones ()
		{
		}
		public void Menu(){
			int n=0;
			Console.WriteLine("Bienvenido");
			for (int i=0; i<4; i++) {
				Console.Write("Ingrese su codigo: ");
				dat.tabla.Add(n,Console.ReadLine()); 
				n++;
				Console.Write("Ingrese su nombre: ");
				dat.tabla.Add(n,Console.ReadLine());
				n++;
				Console.Write("Ingrese su telefono: ");
				dat.tabla.Add(n,Console.ReadLine());
				n++;
				Console.Write("Ingrese su facebook: ");
				dat.tabla.Add(n,Console.ReadLine());
				n++;
				Console.Clear();
			}
		}

		public void MostrarDatos(){
			Console.Clear();
			int p=0;
			for (int i=0; i<4; i++) {
				Console.Write("Codigo: ");
				Console.WriteLine((string)(dat.tabla[p]));
				p++;
				Console.Write("Nombre: ");
				Console.WriteLine((string)(dat.tabla[p]));
				p++;
				Console.Write("Telefono: ");
				Console.WriteLine((string)(dat.tabla[p]));
				p++;
				Console.Write("Facebook: ");
				Console.Write((string)(dat.tabla[p]));
				p++;
				Console.WriteLine("\n\n");
			}
		}
	}
}
