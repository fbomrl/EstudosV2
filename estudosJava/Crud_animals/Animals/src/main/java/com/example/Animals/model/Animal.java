package com.example.Animals.model;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;


@Entity
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Animal {

    @Id @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;
    private String nome;
    private float tamanho;
    private float peso;
    private boolean nadador;
    private boolean voador;
    private boolean venenoso;

    public void podeNadar() {
        this.nadador = false;
    }

    public void podeVoar() {
        this.nadador = false;
    }

    public void possuiVeneno() {
        this.venenoso = false;
    }



}
