package pe.edu.pucp.gamesoft.mysql;

import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.dao.GeneroDAO;
import pe.edu.pucp.gamesoft.model.Genero;
import java.rmi.server.UnicastRemoteObject;
import java.sql.Connection;
import java.sql.CallableStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import pe.edu.pucp.gamesoft.config.DBManager;

public class GeneroMySQL extends UnicastRemoteObject implements GeneroDAO{

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    public GeneroMySQL(int puerto) throws RemoteException{
        super(puerto);
    }
    
    @Override
    public ArrayList<Genero> listarTodos() throws RemoteException {
        ArrayList<Genero> generos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_GENEROS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Genero genero = new Genero();
                genero.setIdGenero(rs.getInt("id_genero"));
                genero.setNombre(rs.getString("nombre"));
                generos.add(genero);
            }
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(SQLException ex){System.out.println(ex.getMessage());}
        }
        return generos;
    }
    
}
