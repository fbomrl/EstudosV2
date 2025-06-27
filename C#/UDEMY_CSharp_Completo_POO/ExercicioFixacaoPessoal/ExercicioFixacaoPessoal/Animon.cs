namespace ExercicioFixacaoPessoal
{
    class Animon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Power { get; private set; }

        public Animon(int id, string name, string type, double power)
        {
            Id = id;
            Name = name;
            Type = type;
            Power = power;
        }

        public void StrengthBoost(double power)
        {
            Power += Power * power / 100.00;
        }

        public void StrengthReduction(double power)
        {
            Power -= Power * power / 100.00;
        }

        public override string ToString()
        {
            return "#"
                + Id
                + ", "
                + Name
                + ", "
                + Type
                + ", "
                + Power
                + ".";
        }
    }
}