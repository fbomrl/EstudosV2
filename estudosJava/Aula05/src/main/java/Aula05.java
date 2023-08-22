public class Aula05 {
    public static void main(String[]args) {

        ContaBanco conta01 = new ContaBanco();
        conta01.setDono("Bruce Meireles");
        conta01.setNumConta(141516);
        conta01.abrirConta("CC");
        conta01.depositar(100);

        ContaBanco conta02 = new ContaBanco();
        conta02.setDono("Filomena Melão Meireles");
        conta02.setNumConta(245259);
        conta02.abrirConta("CP");
        conta02.depositar(500);
        conta02.sacar(100);


        conta01.estadoAtual();
        conta02.estadoAtual();


    }
}
