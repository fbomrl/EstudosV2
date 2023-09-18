package com.example.Animals.dao;

import com.example.Animals.model.Mamífero;
import org.springframework.data.jpa.repository.JpaRepository;

public interface MamiferoRepository extends JpaRepository<Mamífero, Integer> {
}
