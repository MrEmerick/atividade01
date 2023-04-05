using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01.model
{
    public class Cliente
    {
        public Cliente(string nome, string cpf, string cidade)
        {
            if (cpf.Length != 11)
                throw new ArgumentException("CPF inválido!");

            Nome = nome;
            Cpf = cpf;
            Cidade = cidade;
        }
        public Cliente(string cidade)
        {

            Cidade = cidade;
 
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Cidade { get; private set; }
        

    }




}

