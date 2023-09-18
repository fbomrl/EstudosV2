package com.example.Animals.dao;

import com.example.Animals.model.Peixe;
import org.springframework.data.jpa.repository.JpaRepository;

public interface PeixeRepository extends JpaRepository <Peixe, Integer> {
}
