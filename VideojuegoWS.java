package pe.edu.pucp.gamesoft.services;

import jakarta.jws.WebMethod;
import jakarta.jws.WebParam;
import jakarta.jws.WebService;
import java.net.MalformedURLException;
import java.rmi.RemoteException;
import java.rmi.Naming;
import java.rmi.NotBoundException;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.dao.VideojuegoDAO;
import pe.edu.pucp.gamesoft.model.Videojuego;

/* Colocar sus datos personales
* ------------------------------------------------
* Nombre Completo:
* Codigo PUCP:
* ------------------------------------------------
*/

@WebService(serviceName = "VideojuegoWS", targetNamespace = "http://services.gamesoft.pucp.edu.pe/")
public class VideojuegoWS {
    
    private VideojuegoDAO daoVideojuego;
    
    @WebMethod(operationName = "insertarVideojuego")
    public int insertarVideojuego(@WebParam(name = "videojuego") Videojuego videojuego) {
        int resultado = 0;
        try{
            daoVideojuego = (VideojuegoDAO) Naming.lookup("//127.0.0.1:1234/daoVideojuego");
            resultado = daoVideojuego.insertar(videojuego);
        }catch(MalformedURLException | NotBoundException | RemoteException ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarVideojuegosPorNombre")
    public ArrayList<Videojuego> listarVideojuegosPorNombre(@WebParam(name = "nombre") String nombre) {
        ArrayList<Videojuego> videojuegos = new ArrayList<>();
        try{
            daoVideojuego = (VideojuegoDAO) Naming.lookup("//127.0.0.1:1234/daoVideojuego");
            videojuegos = daoVideojuego.listarPorNombre(nombre);
        }catch(MalformedURLException | NotBoundException | RemoteException ex){
            System.out.println(ex.getMessage());
        }
        return videojuegos;
    }
    
    @WebMethod(operationName = "obtenerVideojuegoPorId")
    public Videojuego obtenerVideojuegoPorId(@WebParam(name = "idVideojuego") int idVideojuego) {
        Videojuego videojuego = null;
        try{
            daoVideojuego = (VideojuegoDAO) Naming.lookup("//127.0.0.1:1234/daoVideojuego");
            videojuego = daoVideojuego.obtenerPorId(idVideojuego);
        }catch(MalformedURLException | NotBoundException | RemoteException ex){
            System.out.println(ex.getMessage());
        }
        return videojuego;
    }
}