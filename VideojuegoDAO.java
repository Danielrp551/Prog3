package pe.edu.pucp.gamesoft.dao;
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.model.Videojuego;

public interface VideojuegoDAO extends Remote{
    int insertar(Videojuego videojuego) throws RemoteException;
    ArrayList<Videojuego> listarPorNombre(String nombre) throws RemoteException;
    Videojuego obtenerPorId(int idVideojuego) throws RemoteException;
}