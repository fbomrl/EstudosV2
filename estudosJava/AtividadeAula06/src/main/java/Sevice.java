public class Sevice {

    public static void main(String[]args) {

        System.out.println("----- CACHORRO -----");
        Cachorro c1 = new Cachorro();
        c1.setNome("Bruce");
        c1.diminuindoVelocidade();
        c1.andando();


        System.out.println("----- CACHORRO -----");
        Cachorro c2 = new Cachorro();
        c2.setNome("Filomena");
        c2.aumentandoVelocidade();
        c2.aumentandoVelocidade();
        c2.aumentandoVelocidade();
        c2.aumentandoVelocidade();
        c2.aumentandoVelocidade();
        c2.aumentandoVelocidade();
        c2.andando();
        c2.comendo();

        System.out.println("----- CACHORRO -----");
        Cachorro c3 = new Cachorro();
        c3.setNome("Thanos");
        c3.sentado();
        c3.comendo();

    }
}
