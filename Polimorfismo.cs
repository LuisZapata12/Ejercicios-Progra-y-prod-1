
using System;

public class Polimorfismo 
{

	void Update()
	{

	}
	class hacha
	{
		private int Da�o;
		private double rareza;
		private double durabilidad;

		public hacha() { }

		public hacha(int e, double a, double p)
		{
			Da�o = e;
			rareza = a;
			durabilidad = p;
		}

		public int getda�o()
		{
			return Da�o;
		}

		public double getrareza()
		{
			return rareza;
		}

		public double getdurabilidad()
		{
			return durabilidad;
		}


	}
	//constructor 
	public class constructor
	{
		static int Main()
		{
			hacha hachamadera = new hacha(10, 5, 30);
			hacha hachadiamante = new hacha(85, 0.5, 100);

			Console.WriteLine("El da�o de la hacha nueva es " + hachamadera.getda�o());
			Console.WriteLine(" la durabilidad de la hacha nueva es " + hachamadera.getdurabilidad());
			Console.WriteLine("LA rareza de la hacha nueva es" + hachamadera.getrareza());
			return 0;
		}
	}
}
