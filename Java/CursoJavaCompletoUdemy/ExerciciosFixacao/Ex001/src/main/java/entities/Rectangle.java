package entities;

public class Rectangle {
    public double width;
    public double height;

    public double area(){
        return width * height;
    }

    public double perimeter(){
        return 2 * (width + height);
    }
    public double diagonal(){
        double lado = width * height;
        return Math.sqrt(Math.pow(width, 2) + Math.pow(height, 2));
    }

    @Override
    public String toString() {
        return "AREA = "
                + String.format("%.2f", area()) +
                "\nPERIMETER = "
                + String.format("%.2f", perimeter()) +
                "\nDIAGONAL = "
                + String.format("%.2f", diagonal());
    }
}
