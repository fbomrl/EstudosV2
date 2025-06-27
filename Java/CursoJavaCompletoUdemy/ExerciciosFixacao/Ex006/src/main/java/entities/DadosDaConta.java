package entities;

public class DadosDaConta {
    private int numeroConta;
    private String titularConta;
    private double saldoConta;

    public DadosDaConta(int numeroConta, String titularConta, double depositoInicial) {
        this.numeroConta = numeroConta;
        this.titularConta = titularConta;
        depositoConta(depositoInicial);

    }
    public DadosDaConta(int numeroConta, String titularConta) {

        this.numeroConta = numeroConta;
        this.titularConta = titularConta;
    }

    public String toString(){
        return "Número da Conta: "
                + numeroConta
                + ", Titular: "
                + titularConta
                + ", Saldo: R$ "
                + String.format("%.2f", saldoConta);
    }

    public void depositoConta(double saldoConta){
        this.saldoConta += saldoConta;
    }
    public void retiradaConta(double saldoConta){
        this.saldoConta -= saldoConta + 5;
    }

    public int getNumeroConta() {
        return numeroConta;
    }
    public String getTitularConta() {
        return titularConta;
    }
    public void setTitularConta(String titularConta) {
        this.titularConta = titularConta;
    }
    public double getSaldoConta() {
        return saldoConta;
    }
}
