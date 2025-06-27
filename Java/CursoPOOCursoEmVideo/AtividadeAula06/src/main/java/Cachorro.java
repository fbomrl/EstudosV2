public class Cachorro implements Controlador {

    private boolean postura;
    private int passada;
    private String nome;
    private boolean acordado;

    public Cachorro() {
        this.passada = 0;
        this.acordado = true;
    }

    private boolean getPostura() {
        return postura;
    }

    private void setPostura(boolean postura) {
        this.postura = postura;
    }

    private int getPassada() {
        return passada;
    }

    private void setPassada(int passada) {
        this.passada = passada;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public boolean getAcordado() {
        return acordado;
    }

    public void setAcordado(boolean acordado) {
        this.acordado = acordado;
    }

    @Override
    public void emPé() {
        if (this.getAcordado() && this.getPostura() && this.passada == 00) {
            System.out.println("O cachorro " + this.nome + " está parado em pé.");
        } else if (this.getPostura() && this.passada <= 50) {
            System.out.println("O cachorro " + this.nome + " está andando em pé.");
        } else {
            System.out.println("O cachorro " + this.nome + " não consegue correr em pé.");
        }
    }

    @Override
    public void sentado() {
        if (this.getAcordado() && this.getPostura() == false && this.passada == 0) {
            System.out.println("O cachorro " + this.nome + " está sentado.");
        } else {
            emPé();
        }
    }

    @Override
    public void aumentandoVelocidade() {
        if (this.getAcordado()) {
            this.setPassada(getPassada() + 10);
        } else if (this.getPassada() > 100) {
            System.out.println("O cachorro" + this.nome + " não consegue alcançar essa velocidade.");
        } else {
            System.out.println("Cachorro" + this.nome + " está dormindo!");
        }
    }

    @Override
    public void diminuindoVelocidade() {
        if (this.getAcordado()) {
            this.setPassada((getPassada() - 10));
        } else {
            System.out.println("O Cachorro" + this.nome + " está dormindo.");
        }
    }

    @Override
    public void andando() {
        if (this.getPassada() > 0 && this.getPassada() <= 50) {
            System.out.println("O cachorro " + this.nome + " está andando!");
        } else if (this.getPassada() > 50 && this.getPassada() <= 100) {
            correndo();
        } else if (this.getPassada() == 0) {
            parado();
        } else {
            System.out.println("Cachorro " + this.nome + " não consegue correr a essa velocidade.");
        }
    }

    @Override
    public void correndo() {
        if (this.getPassada() > 50 && this.getPassada() <= 100) {
            System.out.println("O cachorro " + this.nome + " está correndo!");
        } else if (getPassada() > 0 && getPassada() <= 50) {
            andando();
        } else if (getPassada() == 0) {
            parado();
        } else {
            System.out.println("Cachorro " + this.nome + " não consegue correr a essa velocidade.");
        }

    }

    @Override
    public void parado() {
        if (this.getPassada() == 0) {
            System.out.println("O cachorro " + this.nome + " está parado!");
        } else if (this.getPassada() > 0 && getAcordado()) {
            andando();
        } else if (this.getAcordado() && getPassada() < 50 && getPassada() <= 100) {
            correndo();
        } else {
            System.out.println("Cachorro " + this.nome + " não consegue correr a essa velocidade.");
        }
    }

    @Override
    public void comendo() {
        if (this.passada == 0 && this.getPostura() == false) {
            System.out.println("O cachorro " + this.nome + " está comendo.");
        } else {
            System.out.println("O cachorro " + this.nome + " não está comendo.");
        }
    }
}
