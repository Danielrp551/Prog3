/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.softprog.rrhh.mysql;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.rrhh.model.Area;
import pe.edu.pucp.softprog.rrhh.dao.AreaDAO;
import java.sql.Connection;
import java.sql.Statement;
import java.sql.DriverManager;
import pe.edu.pucp.lp2soft.config.DBManager;
/**
 *
 * @author Danielrp551
 */


public class AreaMySQL implements AreaDAO {

    private Connection con;
    private Statement st;
    
    @Override
    public int insertar(Area area) {
        int resultado = 0;
        
        try{
            //Registar un driver conexion
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Realizamos la conexion
            con = DriverManager.getConnection(
                    DBManager.url,DBManager.user,DBManager.password);
            
            String sql = "INSERT INTO area(nombre,activo) "
                    + "VALUES('" + area.getNombre()  + "',1)";
            
            st = con.createStatement();
            resultado = st.executeUpdate(sql);
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }

    @Override
    public int modificar(Area area) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int id_area) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Area> listarTodas() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
