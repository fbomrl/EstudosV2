package com.example.Animals.model;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;


@Entity
@Data
@AllArgsConstructor
@NoArgsConstructor
public abstract class Animal {

    @Id @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;
    private String nome;
    private float tamanho;
    private float peso;
    private boolean nadador;
    private boolean voador;
    private boolean venenoso;

    public void podeNadar() {
    this.setNadador(false);
    }

    public void podeVoar() {
        this.setVoador(false);
    }

    public void possuiVeneno() {
        this.setVenenoso(false);
    }
}
