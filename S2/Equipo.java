import java.util.ArrayList;

class Equipo{
	private String nombre;
	private String interes;
	private ArrayList<Miembro> miembros;
	private EQuipu equipu;
	
	public Equipo(String nombre,String interes){
		this.nombre=nombre;
		this.interes=interes;
	}
	
	public void setMiembros(ArrayList<Miembro> miembros){
		this.miembros=miembros;
	}
	
	public ArrayList<Miembro> getMiembros(){
		return miembros;
	}
	
	
}