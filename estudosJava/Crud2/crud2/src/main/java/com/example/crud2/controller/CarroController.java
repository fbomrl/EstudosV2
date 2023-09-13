package com.example.crud2;

import lombok.AllArgsConstructor;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@AllArgsConstructor
public class CarroController {


    CarroRepository repository;

    @GetMapping("/carro")
    public List<Carro> getAllCarros() {

        return repository.findAll();
    }

    @GetMapping("/carro/{id}")
    public Carro getCarroById(@PathVariable Long id){
        return repository.findById(id).orElse(null);
    }

    @PostMapping("/carro")
    public Carro saveCarro(@RequestBody Carro carro) {
        return repository.save(carro);
    }

    @DeleteMapping("/carro/{id}")
    public void deleteCarro(@PathVariable Long id) {
        repository.deleteById(id);
    }


}
