package com.example.crud.domain.product;


import jakarta.persistence.*;
import lombok.*;

@Table(name="product")
@Entity(name="product")
@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor

public class Product {

    @Id @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    private String name;

    private Integer price_in_cents;

    public Product(RequestProduct requestProduct){
        this.name =requestProduct.name();
        this.price_in_cents = requestProduct.price_in_cents();
    }

}
