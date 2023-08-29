public class Dados {
    public static void main(String[] args) {

        Pessoa[] pessoa = new Pessoa[4];
        Clube[] clube = new Clube[4];

        pessoa[0] = new Pessoa("Maxim Tsigalko", "Bielorussia",18, 170f, 68f);
        pessoa[1] = new Pessoa("Julius Agahowa", "Nigéria",21, 182f, 74f);
        pessoa[2] = new Pessoa("Fabio Silva","Brasil", 34, 168f, 73f);
        pessoa[3] = new Pessoa("Felipe Silva", "Brasil", 32, 173f, 71f);

        clube[0] = new Clube("Dinamo Moscou", pessoa[0]);
        clube[1] = new Clube("Shakhtar Donestk", pessoa[1]);
        clube[2] = new Clube("Rangers Glasgow", pessoa[2]);
        clube[3] = new Clube("Rangers Glasgow", pessoa[3]);

        clube[0].plenasCondicoes();
        clube[0].fazerJogos();
        clube[0].fazerGols();
        clube[0].fazerGols();
        clube[0].fazerGols();
        clube[0].darAssistencias();
        System.out.println(clube[0].detalhes());
        System.out.println(clube[1].detalhes());
        System.out.println(clube[2].detalhes());

    }
}
