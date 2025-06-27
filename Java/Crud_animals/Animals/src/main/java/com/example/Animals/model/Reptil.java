package com.example.Animals.model;

import jakarta.persistence.EnumType;
import jakarta.persistence.Enumerated;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
public class Reptil extends Animal{

    private String corEscama;

    public enum Ordem {
        TESTUDINES, SQUAMATA, CROCODYLIA, RHYNCHOCEPHALIA
    }
}
