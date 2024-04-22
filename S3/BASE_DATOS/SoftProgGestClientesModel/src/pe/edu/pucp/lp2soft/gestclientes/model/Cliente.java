/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2soft.gestclientes.model;

import pe.edu.pucp.lp2soft.rrhh.model.Persona;

/**
 *
 * @author Danielrp551
 */

public class Cliente extends Persona{
    private double lineaCredito;
    private Categoria categoria;

    public double getLineaCredito() {
        return lineaCredito;
    }

    public void setLineaCredito(double lineaCredito) {
        this.lineaCredito = lineaCredito;
    }

    public Categoria getCategoria() {
        return categoria;
    }

    public void setCategoria(Categoria categoria) {
        this.categoria = categoria;
    }
    
    
}
