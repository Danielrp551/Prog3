package pe.edu.pucp.gamesoft.config;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DBManager {
    /*Coloque sus datos de conexión*/
    private Connection con;
    private String url = "jdbc:mysql://lab14-prog3-mydb.crffq6kdudcu.us-east-1.rds.amazonaws.com:3306/laboratorio14";
    private String user = "user_lab14";
    private String password = "pass1234??@";
    private static DBManager dbManager;
    
    public static DBManager getInstance(){
        if(dbManager == null){
            createInstance();
        }
        return dbManager;
    }
    
    public Connection getConnection(){
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.
                getConnection(url,user,password);
        }catch(ClassNotFoundException | SQLException ex){
            System.out.println(ex.getMessage());
        }
        return con;
    }
    
    private static void createInstance(){
        if(dbManager == null){
            dbManager = new DBManager();    
        }
    }
}