public class Clube implements Estatistica{
    private String clube;
    private int jogos;
    private int gols;
    private int assistencias;
    private boolean ativo;
    private Pessoa jogador;

    public Clube(String clube, Pessoa jogador) {
        this.clube = clube;
        this.ativo = false;
        this.jogador = jogador;
        this.jogos = 0;
        this.gols = 0;
        this.assistencias = 0;
    }

    public String detalhes() {
        return  "--------------------------" +
                "\nEstatisticas pelo Clube{" +
                "\nCLUBE = " + clube + '\'' +
                ", \nJOGADOR = " + jogador.getNome() +
                ", \nIDADE = " + jogador.getIdade()+
                ", \nJ = " + jogos +
                ", \nG = " + gols +
                ", \nA = " + assistencias +
                ", \nATIVO = " + ativo +
                '}';
    }

    public String getClube() {
        return clube;
    }

    public void setClube(String clube) {
        this.clube = clube;
    }

    public int getJogos() {
        return jogos;
    }

    public void setJogos(int jogos) {
        this.jogos = jogos;
    }

    public int getGols() {
        return gols;
    }

    public void setGols(int gols) {
        this.gols = gols;
    }

    public int getAssistencias() {
        return assistencias;
    }

    public void setAssistencias(int assistencias) {
        this.assistencias = assistencias;
    }

    public boolean getAtivo() {
        return ativo;
    }

    public void setAtivo(boolean ativo) {
        this.ativo = ativo;
    }

    public Pessoa getJogador() {
        return jogador;
    }

    public void setJogador(Pessoa jogador) {
        this.jogador = jogador;
    }

    @Override
    public void plenasCondicoes() {
        this.ativo = true;
    }

    @Override
    public void lesionado() {
        this.ativo = false;
    }

    @Override
    public void fazerJogos() {
        if(this.ativo = true) {
            this.setJogos(getJogos() + 1);
        }

    }

    @Override
    public void fazerGols() {
        if(this.ativo = true){
            this.setGols(getJogos() + 1);
        }
    }

    @Override
    public void darAssistencias() {
        if(this.ativo = true) {
            this.setAssistencias(getAssistencias() + 1);
        }

    }
}
