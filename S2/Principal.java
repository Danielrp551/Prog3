import java.util.ArrayList;

class Principal{
	public static void main(String [] args){
		//Creamos el objeto EQuipu
		EQuipu objEQuipu = new EQuipu(); 
		
		//Creamos los equipos
		Equipo eq1 = new Equipo("HCI-DUXAIT","Interes en temas de interaccion Humano-Computador");
		Equipo eq2 = new Equipo("Equipo 2","Interes 2");
		Equipo eq3 = new Equipo("Equipo 3","Interes 3");
		Equipo eq4 = new Equipo("Equipo 4","Interes 4");
		
		//Agregamos los equipos al EQuipu
		//eq1.setEquipu(objEQuipu);
		objEQuipu.setEquipos(new ArrayList<>());
		
		objEQuipu.getEquipos().add(eq1);
		objEQuipu.getEquipos().add(eq2);
		objEQuipu.getEquipos().add(eq3);
		objEQuipu.getEquipos().add(eq4);
		
		//Miembros del Equipo 1
		Alumno alumno = new Alumno("20092475","Juan","Perez",68.3);
		Alumno alumno2 = new Alumno("20096969","Viviana","Sinplata",61.3);
		
		Profesor profesor1 = new Profesor("46891","Andrea","Montenegro",TipoDedicacionDocente.TC);
		
		//Asignamos los miembros al equipo 1
		eq1.setMiembros(new ArrayList<Miembro>());
		
		eq1.getMiembros().add(alumno);
		eq1.getMiembros().add(alumno2);
		eq1.getMiembros().add(profesor1);
		
		String reporte = objEQuipu.consultarMiembrosDeEquipo(0);
		
		System.out.println(reporte);
	}
	
	
}