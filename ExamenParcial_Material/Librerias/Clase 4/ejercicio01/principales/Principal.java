package principales;
import matematicas.Operacion;
class Principal{
	public static void main(String[] args){
		Operacion op = new Operacion();
		int a = 10;
		int b = 5;
		int c = op.sumar(a,b);
		int d = op.restar(a,b);
		System.out.println("El valor de a es: " + a);
		System.out.println("El valor de b es: " + b);
		System.out.println("La suma es: " + c);
		System.out.println("La resta es: " + d);
	}
}