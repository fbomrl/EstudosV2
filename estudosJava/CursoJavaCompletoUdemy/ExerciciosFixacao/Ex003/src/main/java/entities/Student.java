package entities;

public class Student {
    public String name;
    public double nota1;
    public double nota2;
    public double nota3;

    public double somaNotas(){
        return nota1 + nota2 + nota3;
    }
    public Double passouOuNao(){
        if(somaNotas() <= 60.0) {
            return 60.0 - somaNotas();
        } else {
            return 0.0;
        }
    }
}
