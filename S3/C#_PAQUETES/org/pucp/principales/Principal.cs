using org.pucp.investigadores;
using org.pucp.personal;

namespace org{
	namespace pucp{
		namespace principales{
			public class Principal{
				public static void Main(string [] args){
					Persona p = new Persona("Hugito");
					Investigador i = new Investigador("Daniel","Dota3");
					
					p.Nombre = "Jorge";
					//p.setNombre("Jorge");
					
					p.imprimirDatos();
					i.imprimirDatos();
				}
			}
		}
	}
}

