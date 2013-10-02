using System;
using System.Collections;

namespace Prac3
{
	public class Funciones
	{
		public Hashtable tabla;

		public Funciones(){
			this.tabla=new Hashtable();
		}

		public void Menu(){
			Console.WriteLine("Bienvenido");
			for (int i=0; i<4; i++) {
				Persona p = new Persona();

				Console.Write("Ingrese su codigo: ");
				p.codigo = Console.ReadLine();
				Console.Write("Ingrese su nombre: ");
				p.nombre = Console.ReadLine();
				Console.Write("Ingrese su telefono: ");
				p.telefono = Console.ReadLine();
				Console.Write("Ingrese su facebook: ");
				p.facebook = Console.ReadLine();

				this.tabla.Add(p.codigo, p);
				Console.Clear();
			}
		}

		public void Editar ()
		{
			string akey;
			Persona pe;

			for (int n=0; n<2; n++) {
				IDictionaryEnumerator comp = this.tabla.GetEnumerator();
				pe=new Persona();
				Console.Clear();
				Console.WriteLine("Ingrese la llave a editar: ");
				akey=Console.ReadLine();

				if(!this.tabla.ContainsKey(akey)){ 
					Console.WriteLine("La llave " + akey + " no existe");
					Console.ReadKey();}

				while(comp.MoveNext()){

					pe = (Persona)(this.tabla[comp.Key]);

					if(akey == pe.codigo){
						Console.Write("Ingrese el nuevo nombre: ");
						pe.nombre = Console.ReadLine();
						Console.Write("Ingrese el nuevo telefono: ");
						pe.telefono = Console.ReadLine();
						Console.Write("Ingrese el nuevo facebook: ");
						pe.facebook = Console.ReadLine();
						break;
					}
				}
			}
		}

		public void Eliminar ()
		{
			string akey;
			Console.Clear();
			for (int n=0; n<2; n++) {
				Console.Write("Ingrese la llave a eliminar: ");
				akey=Console.ReadLine();

				if(!this.tabla.ContainsKey(akey)) Console.WriteLine("La llave " + akey + " no existe");
				this.tabla.Remove(akey);
			}
		}

		public void MostrarDatos ()
		{
			 
			IDictionaryEnumerator dict=this.tabla.GetEnumerator();
			Console.Clear();

     		 while ( dict.MoveNext() ){

				Persona p = new Persona();
				p= (Persona)(tabla[dict.Key]);
				Console.WriteLine("Codigo: {0}", p.codigo);
				Console.WriteLine("Nombre: {0}", p.nombre);
				Console.WriteLine("Telefono: {0}", p.telefono);
				Console.WriteLine("Facebook: {0}", p.facebook);
				Console.WriteLine("\n");

			}
		}
	}
}
