abstract class MiembroPUCP extends Miembro implements Consultable{
	private String codigoPUCP;
	
	public MiembroPUCP(String codigoPUCP,String nombre,String apellido){
		super(nombre,apellido);
		this.codigoPUCP=codigoPUCP;
	}
	
	public abstract String consultarDatos();
	
	public String getCodigoPUCP(){
		return codigoPUCP;
	}
	
}