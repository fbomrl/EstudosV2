package com.example.Animals.dao;

import com.example.Animals.model.Ave;
import org.springframework.data.jpa.repository.JpaRepository;

public interface AveRepository extends JpaRepository <Ave, Integer> {
}
