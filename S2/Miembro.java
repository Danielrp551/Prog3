import java.util.Date;

abstract class Miembro{
	private static int correlativo = 0;
	private int idMiembro;
	private String nombre;
	private String apellido;
	private Date fechaNacimiento;
	private String direccion;
	private String email;
	private char sexo;
	
	public Miembro(){
		
	}
	
	public Miembro(String nombre,String apellido){
		this.idMiembro = correlativo++;
		this.nombre=nombre;
		this.apellido=apellido;
	}
		
	public String getNombre(){
		return nombre;
	}
	public String getApellido(){
		return apellido;
	}
}