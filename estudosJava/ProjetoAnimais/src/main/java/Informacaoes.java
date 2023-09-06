public class Informacaoes {
    public static void main(String[]args){

        Animal a1 = new Animal();
        Mamifero a2 = new Mamifero();
        Reptil a3 = new Reptil();
        Reptil a4 = new Reptil();
        Reptil a5 = new Reptil();
        Mamifero a6 = new Mamifero();
        Roedor a7 = new Roedor();

        a1.setNome("Humano");
        a1.setAltura(175f);
        a1.setPeso(165f);
        a1.setVoador(false);
        a1.setNadador(true);

        a2.setNome("Morcego");
        a2.setAltura(0.20f);
        a2.setPeso(2f);
        a2.setVoador(true);
        a2.setNadador(false);
        a2.setPorte("Pequeno");
        a2.setPelagem("Curta");

        a3.setNome("Jabuti");
        a3.setAltura(0.4f);
        a3.setPeso(20f);
        a3.setVoador(false);
        a3.setNadador(false);
        a3.setPossuiCarapaca(true);
        a3.setPossuiPatas(true);
        a3.setSeparacaoVentricular(false);
        a3.setVenenoso(false);

        a4.setNome("Jacaré");
        a4.setAltura(200f);
        a4.setPeso(80f);
        a4.setVoador(false);
        a4.setNadador(true);
        a4.setPossuiCarapaca(false);
        a4.setPossuiPatas(true);
        a4.setSeparacaoVentricular(true);
        a4.setVenenoso(false);

        a5.setNome("Dragão de Komodo");
        a5.setAltura(300f);
        a5.setPeso(90f);
        a5.setVoador(false);
        a5.setNadador(false);
        a5.setVenenoso(true);
        a5.setPossuiPatas(true);
        a5.setSeparacaoVentricular(false);
        a5.setPossuiCarapaca(false);

        a6.setNome("Orangotango");
        a6.setAltura(100f);
        a6.setPeso(100f);
        a6.setVoador(false);
        a6.setNadador(false);
        a6.setPorte("Grande");
        a6.setPelagem("Comprida");

        a7.setNome("Hamster");
        a7.setAltura(0.10f);
        a7.setPeso(0.1f);
        a7.setNadador(false);
        a7.setVoador(false);
        a7.setPorte("Pequeno");
        a7.setPelagem("Curto");
        a7.dentesSupIncisivos();


        a1.inf();
        a2.inf();
        a3.inf();
        a4.inf();
        a5.inf();
        a6.inf();
        a7.inf();




    }
}
