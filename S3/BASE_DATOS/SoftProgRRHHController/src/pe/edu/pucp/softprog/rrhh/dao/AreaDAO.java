/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.softprog.rrhh.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.rrhh.model.Area;

/**
 *
 * @author Danielrp551
 */

public interface AreaDAO {
    int insertar(Area area);
    int modificar(Area area);
    int eliminar (int id_area);
    ArrayList<Area> listarTodas();
}
