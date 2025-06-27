public class Aula11 {

    public static void main(String[]args) {
        Visitante v1 = new Visitante();
        Aluno a1 = new Aluno();
        Bolsista b1 = new Bolsista();
        Professor p1 = new Professor();
        Tecnico t1 = new Tecnico();

        v1.setNome("Juvenal");
        v1.setIdade(28);
        v1.setSexo("M");
        System.out.println(v1.toString());

        a1.setNome("Cláudio");
        a1.setMatricula(1111);
        a1.setIdade(16);
        a1.setCurso("Informática");
        a1.setSexo("M");

        System.out.println(a1.toString());
        a1.pagarMensalidade();

        b1.setMatricula(1112);
        b1.setNome("Jubileu");
        b1.setBolsa(12.5f);
        b1.pagarMensalidade();
        System.out.println(b1.toString());
        b1.pagarMensalidade();

        p1.setNome("Maria");
        p1.setIdade(59);
        p1.setSexo("F");
        p1.setSalario(10000f);
        p1.setEspecialidade("Engenheira de TI Sênior");
        System.out.println(p1.toString());

    t1.setNome("Aldrovania");
    t1.setIdade(30);
    t1.setSexo("F");
    t1.setRegistroProfissional(13543);
        System.out.println(t1.toString());
    }
}
