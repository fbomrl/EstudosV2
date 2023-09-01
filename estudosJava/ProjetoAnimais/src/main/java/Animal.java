import jdk.swing.interop.SwingInterOpUtils;

public class Animal {
    private String nome;
    private float peso;
    private float altura;
    private boolean voador;
    private boolean nadador;

    public void inf(){
        System.out.println("======================= ");
        System.out.println(" ========ANIMAL======= ");
        System.out.println("Nome: " + nome);
        System.out.println("Peso: " + peso);
        System.out.println("Altura: " + altura);
        System.out.println("Voador: " + voador );
        System.out.println("Nadador: " + nadador);

            if (this instanceof Reptil) {
                ((Reptil) this).tipoCaracteristicas();
            } else if (this instanceof Mamifero) {
                Mamifero mamifero = (Mamifero) this;
                System.out.println("Porte: " + mamifero.getPorte());
                System.out.println("Pelagem: " + mamifero.getPelagem());
            }

    }



    public void velocidadeVoo(){
        if(this.voador == true){
            System.out.println("A(o) " + this.getNome() + "  pode voar!");
        }
    }

    public void velocidadenado(){
        if(this.nadador ==  true){
            System.out.println("A(o) "+ this.getNome() + " pode nadar!");
        }
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public float getPeso() {
        return peso;
    }

    public void setPeso(float peso) {
        this.peso = peso;
    }

    public float getAltura() {
        return altura;
    }

    public void setAltura(float altura) {
        this.altura = altura;
    }

    public boolean getVoador() {
        return voador;
    }

    public void setVoador(boolean voador) {
        this.voador = voador;
    }

    public boolean getNadador() {
        return nadador;
    }

    public void setNadador(boolean nadador) {
        this.nadador = nadador;
    }
}
