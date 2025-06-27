using System;

namespace _128_Exercicios_Fixacao.Entities.Exception
{
    class AccountException : ApplicationException
    {
        public AccountException(string message)
            : base(message)
        {

        }
    }
}
