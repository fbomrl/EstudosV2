package com.example.Animals.model;

import jakarta.persistence.Entity;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Data
@NoArgsConstructor
@AllArgsConstructor
public class Ave extends Animal{
    private String corPena;
    private String tipoBico;

    @Override
    public void podeNadar() {
    }

    @Override
    public void podeVoar() {
    }

    @Override
    public void possuiVeneno() {
    }
}

