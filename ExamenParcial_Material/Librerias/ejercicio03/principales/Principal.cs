using Matematicas;
using System;
namespace Principales{
	class Principal{
		public static void Main(string[] args){
			Operacion op = new Operacion();
			int a = 10;
			int b = 5;
			int c = op.sumar(a,b);
			int d = op.restar(a,b);
			Console.WriteLine("El valor de a es: " + a);
			Console.WriteLine("El valor de b es: " + b);
			Console.WriteLine("La suma es: " + c);
			Console.WriteLine("La resta es: " + d);
		}
	}
}