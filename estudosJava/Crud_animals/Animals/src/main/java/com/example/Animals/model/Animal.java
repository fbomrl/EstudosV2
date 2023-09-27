package com.example.Animals.model;

import jakarta.persistence.*;
import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Pattern;
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
    @NotNull(message = "Campo nome é Obrigatório!")
    @Pattern(regexp = "^[A-Z]+(.)*", message = "Campo Nome deve iniciar com letra maiúscula!")
    private String nome;
    private float tamanho;
    private float peso;
    @Pattern(regexp = "^[A-Z]+(.)*", message = "Campo Nome deve iniciar com letra maiúscula!")
    private String alimentacao;
    @Pattern(regexp = "^[A-Z]+(.)*", message = "Campo Nome deve iniciar com letra maiúscula!")
    private String habitat;
    private String ordem;
    private Integer selecao;
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

    public void ordem() {
        this.setOrdem("Desconhecido");
    }
}
