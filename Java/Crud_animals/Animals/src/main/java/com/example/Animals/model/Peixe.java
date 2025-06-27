package com.example.Animals.model;

import jakarta.persistence.Entity;
import lombok.AllArgsConstructor;
import lombok.Data;

@Entity
@Data
@AllArgsConstructor
public class Peixe extends Animal{
    private String grupo;
    private String corEscama;
    private String agua;

    public Peixe() {
        setNadador(Nadador.SIM);
    }
}