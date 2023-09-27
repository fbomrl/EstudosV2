public class App {

    public static void main(String[] args){

        Oculos oculos1 = new Oculos();
        oculos1.status();
        oculos1.grau = true;
        oculos1.sol = false;
        oculos1.cor = "Cinza";
        oculos1.tipo = "Infantil";

        System.out.println("=====================");

        Oculos oculos2 = new Oculos();
        oculos2.status();
        oculos2.grau = false;
        oculos2.sol = true;
        oculos2.cor = "Verde";
        oculos2.tipo = "Masculino";

        System.out.println("=====================");

        Oculos oculos3 = new Oculos();
        oculos3.status();
        oculos3.grau = false;
        oculos3.sol = true;
        oculos3.cor = "Preto";
        oculos3.tipo = "Feminono";


    }
}
