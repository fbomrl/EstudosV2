namespace _142_Inversao_Controle_Injecao_dependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SEM INTERFACE
            //Na situação de não ter implementado a Interface...Aula 139/140...
            //Acoplamento forte;
            //A classe RentalService (exercício anterior) conhece a dependência concreta;
            //Se a classe concreta mudar, é preciso mudar a classe RentalService;
            #endregion

            #region COM INTERFACE
            //Acoplamento fraco;
            //A classe RentalService não conhece a dependência concreta;
            //Se a classe concreta mudar, a classe RentService não muda nada;
            #endregion

            #region INVERSÃO DE CONTROLE
            //    Inversão de controle
            //Padrão de desenvolvimento que consiste em retirar da classe a responsabilidade de instanciar suas dependências;

            //    Injeção de dependência
            //É uma forma de realizar a inversão de controle: um componente externo instancia a dependência, que é injetada no no;
            //"pai". Pode ser implementada de várias formas:
            //-Construtor;
            //-Objeto instanciação(builder / factory);
            //- Container / framework;
            #endregion

        }
    }
}
