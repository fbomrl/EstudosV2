package com.example.Animals.model;

import jakarta.persistence.Entity;
import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Pattern;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;


@Entity
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Anfibio extends Animal{
    private String cor;

    @Override
    public void ordem() {
        switch(this.getSelecao()) {
            case 1: this.setOrdem("Anura");
            break;
            case 2: this.setOrdem("Urodela");
            break;
            case 3: this.setOrdem("Gymnophiona");
            break;
            case 0: this.setOrdem("Desconhecido");
        }
    }


}
