class Principal{
	public static void Main(string [] args){
		System.Console.WriteLine("Programa en C# .....");
	
		Profesor profesor = new Profesor("Manuel Tupia",2500);
		System.Console.WriteLine(profesor.Nombre + " - " + profesor.Sueldo);
	}
}