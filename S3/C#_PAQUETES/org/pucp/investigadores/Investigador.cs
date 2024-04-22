using org.pucp.interfaces;
using org.pucp.personal;

namespace org{
	namespace pucp{
		namespace investigadores{
			public class Investigador : Persona, IConsultable{
				private string especialidad;
				public Investigador(string nombre,
						string especialidad) : base(nombre){
					this.especialidad=especialidad;
				}
				public override void imprimirDatos(){
					System.Console.WriteLine("Soy " + Nombre+ " " + 
						especialidad);
					base.otroMetodoImpresion();
				}

			} 
		}
	}
}

