package paqueteC;
import paqueteA.paqueteB.*;
public class ClaseC{
	public double promedio(int a, int b){
		ClaseB cb = new ClaseB();
		return cb.sumar(a,b);
	}
}