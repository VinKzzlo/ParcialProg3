using Matematicas;
using System;
namespace Pincipales{
	public class Principal{
	
		public static void Main(String[] args){
			Operacion op = new Operacion();
			int a = 10;
			int b = 5;
			int c = op.sumar(a,b);
			int d = op.restar(a,b);
		
			Console.WriteLine("El resultado de a+b es:" + c);
			Console.WriteLine("El resultado de a-b es:" + d);
		}
		
	}
}
	
