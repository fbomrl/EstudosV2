public class Leitura {
    public static void main(String[] args){
        Pessoa[] p = new Pessoa[2];
        Livro[] l = new Livro[3];

        p[0] = new Pessoa("Fabio", 34, "M");
        p[1] = new Pessoa("Felipe", 32, "M");

        l[0] = new Livro("Peq. Manual Antiracista","Djamila Ribeiro",135,p[0]);
        l[1] = new Livro("Aprendendo Java", "José Silva", 300, p[1]);
        l[2] = new Livro("Java Avançado", "Maria Cândido", 800, p[0]);

        l[0].abrir();
        l[0].folhear(100);

        System.out.println(l[0].detalhes());
        System.out.println(l[1].detalhes());
        System.out.println(l[2].detalhes());
    }
}
