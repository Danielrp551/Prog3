
class Profesor extends MiembroPUCP{
	private TipoDedicacionDocente estado;
	
	public Profesor(String codigoPUCP,String nombre,String apellido,TipoDedicacionDocente estado){
		super(codigoPUCP,nombre,apellido);
		this.estado=estado;
	}
	
	public String consultarDatos(){
		return "Profesor: " + getCodigoPUCP()+ " - " + getNombre()
			+ " " + getApellido() + " " + estado + "\n" ;
	}
	
}