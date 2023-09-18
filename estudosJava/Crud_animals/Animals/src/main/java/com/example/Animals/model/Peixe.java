package com.example.Animals.model;

import jakarta.persistence.Entity;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Peixe extends Animal{
    private String grupo;
    private String corEscama;
    private String agua;

    @Override
    public void podeNadar() {
        this.setNadador(true);
    }

    @Override
    public void podeVoar() {

    }

    @Override
    public void possuiVeneno() {

    }
}
