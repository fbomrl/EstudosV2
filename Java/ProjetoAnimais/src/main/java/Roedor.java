public class Roedor extends Mamifero{
    private boolean quatroIncisivosSup;


    public void dentesSupIncisivos(){
        this.quatroIncisivosSup = true;
    }

    public boolean isQuatroIncisivosSup() {
        return quatroIncisivosSup;
    }

    public void setQuatroIncisivosSup(boolean quatroIncisivosSup) {
        this.quatroIncisivosSup = quatroIncisivosSup;
    }
}
