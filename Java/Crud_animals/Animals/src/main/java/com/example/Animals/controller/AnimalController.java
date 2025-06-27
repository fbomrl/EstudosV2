package com.example.Animals.controller;

import com.example.Animals.dao.*;
import com.example.Animals.model.*;
import lombok.AllArgsConstructor;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@AllArgsConstructor
public class AnimalController {

    AnimalRepository animalRepository;
    MamiferoRepository mamiferoRepository;
    PeixeRepository peixeRepository;
    AveRepository aveRepository;
    AnfibioRepository anfibioRepository;

    @GetMapping("/animal")
    public List<Animal> getAllAnimais() {
        return animalRepository.findAll();
    }
    @GetMapping("/mamifero")
    public List<Mamífero> getAllMamiferos() {
        return mamiferoRepository.findAll();
    }
    @GetMapping("/peixe")
    public List<Peixe> getAllPeixes() {
        return peixeRepository.findAll();
    }
    @GetMapping("/ave")
    public List<Ave> getAllAves() {
        return aveRepository.findAll();
    }
    @GetMapping("/anfibio")
    public List<Anfibio> getAllAnfibios() {
        return anfibioRepository.findAll();
    }

    @GetMapping("/mamifero/{id}")
    public Mamífero findMamiferoById (@PathVariable  Integer id) {
        return mamiferoRepository.findById(id).orElse(null);
    }

    @PostMapping("/mamifero")
    public Mamífero saveMamifero(@RequestBody Mamífero mamifero) {
        return mamiferoRepository.save(mamifero);
    }

    @PostMapping("/peixe")
    public Peixe savePeixe(@RequestBody Peixe peixe) {
        return peixeRepository.save(peixe);
    }

    @PostMapping("/ave")
    public Ave saveAve (@RequestBody Ave ave) {
        return aveRepository.save(ave);
    }

    @PostMapping("/anfibio")
    public Anfibio saveAnfibio(@RequestBody Anfibio anfibio) {
        return anfibioRepository.save(anfibio);
    }

    @DeleteMapping("mamifero/{id}")
    public void deleteMamiferoById (@PathVariable Integer id) {
        mamiferoRepository.deleteById(id);
    }

    @DeleteMapping("peixe/{id}")
    public void deletePeixeById (@PathVariable Integer id) {
        peixeRepository.deleteById(id);
    }

    @DeleteMapping("/ave/{id}")
    public void deleteAveById(@PathVariable Integer id) {
        aveRepository.deleteById(id);
    }

    @DeleteMapping("anfibio/{id}")
    public void deleteAnfibioById(@PathVariable Integer id){
        anfibioRepository.deleteById(id);
    }





}
