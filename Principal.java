package pe.edu.pucp.gamesoft.server;

import java.rmi.registry.LocateRegistry;
import java.rmi.RemoteException;
import java.net.MalformedURLException;
import pe.edu.pucp.gamesoft.dao.GeneroDAO;
import pe.edu.pucp.gamesoft.mysql.GeneroMySQL;

import java.rmi.Naming;
import pe.edu.pucp.gamesoft.dao.VideojuegoDAO;
import pe.edu.pucp.gamesoft.mysql.VideojuegoMySQL;
public class Principal {
    /* Colocar sus datos personales
    * ------------------------------------------------
    * Nombre Completo:
    * Codigo PUCP:
    * ------------------------------------------------
    */
    public static void main(String[] args){
        String puerto = "1234";
        try{
            LocateRegistry.createRegistry(Integer.parseInt(puerto));        
            GeneroDAO daoGenero = new GeneroMySQL(Integer.parseInt(puerto));
            VideojuegoDAO daoVideojuego = new VideojuegoMySQL(Integer.parseInt(puerto));
            Naming.rebind("//127.0.0.1:1234/daoGenero", daoGenero);
            Naming.rebind("//127.0.0.1:1234/daoVideojuego", daoVideojuego);
            System.out.println("El servidor se ha inicializado...");
        }catch(NumberFormatException | MalformedURLException | RemoteException ex){
            System.out.println(ex.getMessage());
        }
    }
}
