public class Principal {
    public static void main(String[]args){

        Pessoa p1 = new Pessoa();
        Aluno p2 = new Aluno();
        Professor p3 = new Professor();
        Funcionario p4 = new Funcionario();

        p1.setNome("Pedro");
        p1.setSexo("M");
        p1.setIdade(14);

        p2.setNome("Maria");
        p2.setIdade(18);
        p2.setSexo("F");
        p2.setCurso("Informática");

        p3.setNome("Cláudio");
        p3.setSexo("M");
        p3.setIdade(34);
        p3.setSalario(2500.75f);

        p4.setNome("Fabiana");
        p4.setSexo("F");
        p4.setIdade(28);
        p4.setSetor("Estoque");

        System.out.println(p1.toString());
        System.out.println(p2.toString());
        System.out.println(p3.toString());
        System.out.println(p4.toString());

    }
}
