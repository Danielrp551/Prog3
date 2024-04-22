/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2soft.main;

import pe.edu.pucp.lp2soft.gestclientes.model.Cliente;
import pe.edu.pucp.lp2soft.rrhh.model.Area;
import pe.edu.pucp.lp2soft.rrhh.model.Empleado;
import pe.edu.pucp.softprog.rrhh.dao.AreaDAO;
import pe.edu.pucp.softprog.rrhh.mysql.AreaMySQL;

/**
 *
 * @author Danielrp551
 */
public class Principal {
    public static void main(String [] args){
        /*
        Empleado empleado = new Empleado();
        empleado.setNombre("Chacal");
        Area area = new Area();
        area.setNombre("Doteros");
        Cliente cliente = new Cliente();
        cliente.setNombre("Daniel Gotto");
        System.out.println(empleado.getNombre() + " es empleado de " + 
                cliente.getNombre());
        */
        
        Area area = new Area("Recursos Inhumanos");
        AreaDAO daoArea = new AreaMySQL();
        int resultado = daoArea.insertar(area);
        if(resultado != 0){
            System.out.println("Se ha registrado con exito");
        }else{
            System.out.println("Ha ocurrido un error");
        }
    }
}
