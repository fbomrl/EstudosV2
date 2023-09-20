package com.example.Animals.model;

import jakarta.persistence.Entity;
import jakarta.persistence.EnumType;
import jakarta.persistence.Enumerated;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;


@Entity
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Anfibio extends Animal{

    private String corEscama;

    @Enumerated(EnumType.STRING)
    private Tipo tipo;

    public enum Tipo {
        ANURA, URODELA, GYMNOPHIONA
    }

}
