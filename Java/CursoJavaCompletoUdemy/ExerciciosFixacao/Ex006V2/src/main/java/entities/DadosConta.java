package entities;

public class DadosConta {
    private int numeroConta;
    private String titular;
    private double saldo;

    public DadosConta(int numeroConta, String titular, double depositoInicial) {
        this.numeroConta = numeroConta;
        this.titular = titular;
        depositoSaldo(depositoInicial);
    }

    public DadosConta(int numeroConta, String titular) {
        this.numeroConta = numeroConta;
        this.titular = titular;
    }

    public void depositoSaldo(double valor){
        this.saldo += valor;
    }
    public  void retiradaSaldo(double valor){
        this.saldo -= valor + 5.00; //5.00 é a taxa do saque.
    }

    public String toString() {
        return "Número da Conta: "
                + numeroConta
                + ", Titular: "
                + titular
                + ", Saldo R$ "
                + String.format("%.2f", saldo);
    }

    public int getNumeroConta() {
        return numeroConta;
    }

    public String getTitular() {
        return titular;
    }

    public void setTitular(String titular) {
        this.titular = titular;
    }

    public double getSaldo() {
        return saldo;
    }
}
