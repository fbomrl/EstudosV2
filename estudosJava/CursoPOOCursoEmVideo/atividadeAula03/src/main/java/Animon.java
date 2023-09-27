public class Animon {

    public String name;
    public String superpower;
    private boolean genero;
    private int equip;

    public void status() {
        System.out.println("Animon conhecido por: "+ this.name);
        System.out.println("Que tem o poder de "+ this.superpower);
        System.out.println("Que é do gênero " + this.genero);
        System.out.println("Que é equipado com um(a) " + this.equip);
    }

    public void genGen() {
            System.out.println("Homem" + this.genero);
    }

    public void equipamento() {
            System.out.println("Espada" + this.equip);
    }

}
