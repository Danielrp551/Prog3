using System;

class Profesor{
	private string nombre;
	private double sueldo;
	private DateTime fechaNacimiento;
	
	public Profesor(string nombre,double sueldo){
		this.nombre=nombre;
		this.sueldo=sueldo;
		this.fechaNacimiento = new DateTime();
	}
	
	//Propiedades
	public string Nombre{
		get{
			return nombre;
		}
		set{
			this.nombre= value;
		}
	}
	
	public double Sueldo{
		get {
			return sueldo;
		}
		set{
			this.sueldo=sueldo;
		}
	}
}