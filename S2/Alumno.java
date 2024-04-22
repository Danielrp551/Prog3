class Alumno extends MiembroPUCP{
	private double CRAEST;
	
	public Alumno(String codigoPUCP,String nombre,String apellido,double CRAEST){
		super(codigoPUCP,nombre,apellido);
		this.CRAEST=CRAEST;
	}

	@Override
	public String consultarDatos(){
		return "Alumno: " + getCodigoPUCP() + " - " + getNombre() +
				" " + getApellido() + " " + CRAEST + "\n";
	}

}