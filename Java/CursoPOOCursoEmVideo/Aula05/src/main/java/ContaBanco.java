public class ContaBanco {

    public int numConta;
    protected String tipo;
    private String dono;
    private float saldo;
    private boolean status;

    public ContaBanco() {
        this.setSaldo(0f);
        this.setStatus(false);

    }

    public void estadoAtual() {
        System.out.println("--------------------");
        System.out.println("---CONTA BANCÁRIA---");
        System.out.println("Cliente: " + this.getDono());
        System.out.println("N Conta: " + this.getNumConta());
        System.out.println("Tipo: " + this.getTipo());
        System.out.println("Saldo: R$ " + this.getSaldo());
        System.out.println("Status: " + this.getStatus());

    }

    public void abrirConta(String tipoConta) {
        this.setTipo(tipoConta);
        this.setStatus(true);

        if (tipoConta == "CC"){
            this.setSaldo(50);
            System.out.println("Conta Aberta com Sucesso! ");
        } else if (tipoConta == "CP"){
            this.setSaldo(150);
            System.out.println("Conta Aberta com Sucesso! ");
        }
    }

    public void fecharConta(){
        if (this.getSaldo() > 0){
            System.out.println("Conta não pode ser fechada porque ainda tem dinheiro.");
        }else if (this.getSaldo() < 0){
            System.out.println("Conta não pode ser fechada pois tem débito.");
        }else {
            this.setStatus(false);
            System.out.println("Conta fechada com sucesso!");
        }
    }
    public void depositar(float valor){
        if (this.status == true) {
            this.setSaldo(this.getSaldo() + valor);
            System.out.println("Deposito realizado na conta de "+ this.getDono());
        } else {
            System.out.println("Impossível depositar em uma conta fechada!");
        }
    }

    public void sacar(float valor){
        if (this.status == true) {
            if (this.getSaldo() >= valor) {
                this.setSaldo(this.getSaldo() - valor);
                System.out.println("Saque realizado na conta de" + this.getDono());
            } else {
                System.out.println("Saldo Insuficiente para saque");
            }
        } else {
            System.out.println("Impossível sacar de uma conta fechada!");
        }
    }

    public void pagarMensal(){
        int valor = 0;
        if (this.getTipo() == "CC") {
            valor = 12;
        } else if (this.getTipo() == "CP") {
            valor = 20;
        }

        if (this.getStatus() == true){
            this.setSaldo(this.getSaldo() - valor);
            System.out.println("Mensalidade paga com sucesso por " + this.getDono());
        } else {
            System.out.println("Impossível pagar uma conta fechada!");
        }
    }


    public int getNumConta() {
        return numConta;
    }

    public void setNumConta(int numConta) {
        this.numConta = numConta;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public String getDono() {
        return dono;
    }

    public void setDono(String dono) {
        this.dono = dono;
    }

    public float getSaldo() {
        return saldo;
    }

    public void setSaldo(float saldo) {
        this.saldo = saldo;
    }

    public boolean getStatus() {
        return status;
    }

    public void setStatus(boolean status) {
        this.status = status;
    }
}
