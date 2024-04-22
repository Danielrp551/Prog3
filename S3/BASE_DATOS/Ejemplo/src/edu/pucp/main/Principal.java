/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.pucp.main;

/**
 *
 * @author Danielrp551
 */
import edu.pucp.model.Persona;

public class Principal {
    public static void main(String[] args){
        Persona p = new Persona();
        p.setNombre("Daniel Gotto");
        System.out.println(p.getNombre());
    }
}
