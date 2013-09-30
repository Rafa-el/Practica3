using System;
using System.Collections;

namespace Prac3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Funciones fun=new Funciones();

			fun.Menu();
			fun.Editar();
			//fun.Eliminar();
			fun.MostrarDatos();
		}
	}
}
