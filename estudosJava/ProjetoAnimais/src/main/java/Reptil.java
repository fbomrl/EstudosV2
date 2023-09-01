public class Reptil extends Animal{
    private boolean venenoso;
    private boolean possuiCarapaca;
    private boolean possuiPatas;
    private boolean separacaoVentricular;


    public void tipoCaracteristicas() {
        if(this.possuiCarapaca ==  true && this.separacaoVentricular ==  false && this.venenoso == false && this.possuiPatas == true){
            System.out.println("Esse réptil é um Testudinata (tartarugas/cagados/jabutis).");
        } else if (this.separacaoVentricular == true && this.venenoso == false && this.possuiPatas == true){
        System.out.println("Esse réptil é um crocodiliano (Crocodilos, Jacarés e Gaviais).");
    } else if (this.separacaoVentricular == false && this.possuiCarapaca == false) {
            System.out.println("Esse rétil é um Squamata (Lagartos e Cobras).");
        } else {
            System.out.println("Esse rétil é um Rhynchocephalia (tuarara).");
        }
        }

    public boolean getVenenoso() {
        return venenoso;
    }

    public void setVenenoso(boolean venenoso) {
        this.venenoso = venenoso;
    }

    public boolean getPossuiCarapaca() {
        return possuiCarapaca;
    }

    public void setPossuiCarapaca(boolean possuiCarapaca) {
        this.possuiCarapaca = possuiCarapaca;
    }

    public boolean getPossuiPatas() {
        return possuiPatas;
    }

    public void setPossuiPatas(boolean possuiPatas) {
        this.possuiPatas = possuiPatas;
    }

    public boolean getSeparacaoVentricular() {
        return separacaoVentricular;
    }

    public void setSeparacaoVentricular(boolean separacaoVentricular) {
        this.separacaoVentricular = separacaoVentricular;
    }
}
