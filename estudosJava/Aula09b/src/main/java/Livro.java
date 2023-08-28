public class Livro implements Publicacao{
    private String titulo;
    private String autor;
    private int totPaginas;
    private int pagAtual;
    private boolean aberto;
    private Pessoa leitor;

    public String detalhes() {
        return "------------------" +
                "\nLivro{" +
                "titulo = '" + titulo + '\'' +
                ",\n autor = '" + autor + '\'' +
                ",\n totPaginas = " + totPaginas +
                ", pagAtual = " + pagAtual +
                ",\n aberto = " + aberto +
                ", leitor = '" + leitor.getNome()+ '\'' +
                ", Idade = '" + leitor.getIdade()+ '\'' +
                ", sexo = '" + leitor.getSexo()+ '\'' +
                '}';
    }

    public Livro(String titulo, String autor, int totPaginas, Pessoa leitor) {
        this.titulo = titulo;
        this.autor = autor;
        this.totPaginas = totPaginas;
        this.pagAtual = 0;
        this.aberto = false;
        this.leitor = leitor;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public String getAutor() {
        return autor;
    }

    public void setAutor(String autor) {
        this.autor = autor;
    }

    public int getTotPaginas() {
        return totPaginas;
    }

    public void setTotPaginas(int totPaginas) {
        this.totPaginas = totPaginas;
    }

    public Pessoa getLeitor() {
        return leitor;
    }

    public void setLeitor(Pessoa leitor) {
        this.leitor = leitor;
    }

    @Override
    public void abrir() {
        this.aberto = true;

    }

    @Override
    public void fechar() {
        this.aberto = false;
    }

    @Override
    public void folhear(int pagAtual) {
        if(pagAtual > this.totPaginas){
            this.pagAtual = 0;
        }else {
            this.pagAtual = pagAtual;
        }

    }

    @Override
    public void avancarPag() {
        this.pagAtual++;
    }

    @Override
    public void voltarPag() {
        this.pagAtual--;
    }
}

