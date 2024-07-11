package pe.edu.pucp.gamesoft.mysql;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.gamesoft.config.DBManager;
import pe.edu.pucp.gamesoft.dao.VideojuegoDAO;
import pe.edu.pucp.gamesoft.model.Clasificacion;
import pe.edu.pucp.gamesoft.model.Genero;
import pe.edu.pucp.gamesoft.model.Videojuego;

public class VideojuegoMySQL extends UnicastRemoteObject implements VideojuegoDAO{

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    public VideojuegoMySQL(int puerto) throws RemoteException{
        super(puerto);
    }
    
    @Override
    public int insertar(Videojuego videojuego) throws RemoteException {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_VIDEOJUEGO(?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_videojuego", java.sql.Types.INTEGER);
            cs.setString("_nombre", videojuego.getNombre());
            cs.setInt("_fid_genero", videojuego.getGenero().getIdGenero());
            cs.setDate("_fecha_lanzamiento", new java.sql.Date(videojuego.getFechaLanzamiento().getTime()));
            cs.setDouble("_costo_desarrollo", videojuego.getCostoDesarrollo());
            cs.setBytes("_foto", videojuego.getFoto());
            cs.setString("_clasificacion",videojuego.getClasificacion().toString());
            cs.executeUpdate();
            resultado = cs.getInt("_id_videojuego");
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(SQLException ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Videojuego> listarPorNombre(String nombre) throws RemoteException {
        ArrayList<Videojuego> videojuegos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_VIDEOJUEGOS_POR_NOMBRE(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Videojuego videojuego = new Videojuego();
                videojuego.setIdVideojuego(rs.getInt("id_videojuego"));
                videojuego.setNombre(rs.getString("nombre_videojuego"));
                videojuego.setClasificacion(Clasificacion.valueOf(rs.getString("clasificacion")));
                videojuego.setGenero(new Genero());
                videojuego.getGenero().setIdGenero(rs.getInt("id_genero"));
                videojuego.getGenero().setNombre(rs.getString("nombre_genero"));
                videojuegos.add(videojuego);
            }
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(SQLException ex){System.out.println(ex.getMessage());}
        }
        return videojuegos;
    }

    @Override
    public Videojuego obtenerPorId(int idVideojuego) throws RemoteException {
        Videojuego videojuego = new Videojuego();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call OBTENER_VIDEOJUEGO_POR_ID(?)}");
            cs.setInt("_id_videojuego", idVideojuego);
            rs = cs.executeQuery();
            if(rs.next()){
                videojuego.setIdVideojuego(rs.getInt("id_videojuego"));
                videojuego.setNombre(rs.getString("nombre_videojuego"));
                videojuego.setClasificacion(Clasificacion.valueOf(rs.getString("clasificacion")));
                videojuego.setGenero(new Genero());
                videojuego.getGenero().setIdGenero(rs.getInt("id_genero"));
                videojuego.getGenero().setNombre(rs.getString("nombre_genero"));
                videojuego.setCostoDesarrollo(rs.getDouble("costo_desarrollo"));
                videojuego.setFechaLanzamiento(rs.getDate("fecha_lanzamiento"));
                videojuego.setFoto(rs.getBytes("foto"));
            }
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(SQLException ex){System.out.println(ex.getMessage());}
        }
        return videojuego;
    }
    
}