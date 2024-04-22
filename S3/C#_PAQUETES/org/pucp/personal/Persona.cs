using org.pucp.interfaces;

namespace org{
	namespace pucp{
		namespace personal{
			public class Persona : IConsultable{
				private string nombre;
				public Persona(string nombre){
					this.nombre=nombre;
				}
				public string Nombre{
					get{
						return nombre;
					}
					set{
						this.nombre=value;
					}
				}
				
				public virtual void imprimirDatos(){
					System.Console.WriteLine("Soy " 
						+ nombre);
				}
				public void otroMetodoImpresion(){
					System.Console.WriteLine("Otro metodo de impresion");
				}
			}	
		}
	}
}

