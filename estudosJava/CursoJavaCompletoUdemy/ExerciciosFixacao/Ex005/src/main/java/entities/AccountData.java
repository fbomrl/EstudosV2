package entities;

public class AccountData {
    private int account;
    private String name;
    private double value;

    public AccountData(int account, String name) {
        this.account = account;
        this.name = name;
    }

    public AccountData(int account, String name, double initialDeposit) {
        this.account = account;
        this.name = name;
        depositValue(initialDeposit);
    }

    public void depositValue(double value) {
        this.value += value;
    }

    public void withdrawValue(double value) {
        this.value -= value + 5.00;

    }

    public String toString() {
        return "Account "
                + account
                + ", Holder: "
                + name
                + ", Balance: $ "
                + String.format("%.2f", value);
    }

    public int getAccount() {
        return account;
    }
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public double getValue() {
        return value;
    }
}
