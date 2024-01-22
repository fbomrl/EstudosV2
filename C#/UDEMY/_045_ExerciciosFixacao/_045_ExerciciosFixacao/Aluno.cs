namespace _045_ExerciciosFixacao
{
    internal class Aluno
    {
        public string Nome;
        public double notaA;
        public double notaB;
        public double notaC;

        public double NotaFinal()
        {
            return notaA + notaB + notaC;
        }
        public bool Aprovado()
        {
            if (NotaFinal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}