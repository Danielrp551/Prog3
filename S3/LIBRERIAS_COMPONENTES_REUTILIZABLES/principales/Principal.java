package principales;

//import matematicas.Operacion;

public class Principal{
	public static void main(String[] args){
		matematicas.Operacion op1 = new matematicas.Operacion();
		System.out.println(op1.sumar(1,4));
		System.out.println(op1.restar(4,6));
		op1.imprimir("GA GA GA");
	}
}