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
    @Enumerated(EnumType.STRING)
    private Nadador nadador = Nadador.NAO;
    @Enumerated(EnumType.STRING)
    private Voador voador = Voador.NAO;
    @Enumerated(EnumType.STRING)
    private Veneno veneno = Veneno.NAO;

    public enum Nadador {
        SIM, NAO
    }
    public enum Voador {
        SIM, NAO
    }
    public enum Veneno {
        SIM, NAO
    }
}
