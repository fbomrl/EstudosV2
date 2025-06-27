package util;

public class CurrencyConverter {



    public  static double converter(double dollarPrice, double dollarQuantity){
        double realSemTaxa = dollarQuantity/(1.00/dollarPrice);
        double realComTaxa = 6 * realSemTaxa / 100;

        return  dollarQuantity/(1.00/dollarPrice) + realComTaxa;
    }

}
