package com.example.Animals.model;


import jakarta.persistence.Entity;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Mamífero extends Animal{
    private String porte;
    private String tamanhoPelagem;
    private String corPelagem;


}
