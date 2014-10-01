using System;
namespace productos
{
	public class Tienda
	{
		private Libro libro;
		private Dvd dvd;
		
		public Tienda ()
		{
			this.libro = new Libro();
			this.dvd = new Dvd();
		}
		
		public void captura(){
			this.capturaLibro();
			Console.Clear();
			this.capturaDvd();
		}
		
		private void capturaLibro(){
			Console.WriteLine("Captura de Libro");
			Console.WriteLine("Dame el titulo");
			this.libro.titulo = Console.ReadLine();
			Console.WriteLine("Dame el autor");
			this.libro.autor = Console.ReadLine();
			Console.WriteLine("Dame el precio:");
			this.libro.precio = double.Parse(Console.ReadLine());
			Console.WriteLine("Dame el código");
			this.libro.codigo = Console.ReadLine();
		}
		
		private void capturaDvd(){
			Console.WriteLine("Captura de DVD");
			Console.WriteLine("Dame el titulo");
			this.dvd.titulo = Console.ReadLine();
			Console.WriteLine("Dame el año");
			this.dvd.anio = int.Parse(Console.ReadLine());
			Console.WriteLine("Dame el precio:");
			this.libro.precio = double.Parse(Console.ReadLine());
			Console.WriteLine("Dame el código");
			this.libro.codigo = Console.ReadLine();
		}
	}
}

