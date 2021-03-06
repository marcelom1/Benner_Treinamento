﻿using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
     public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando Diretor");

        }

        public override double GetBonificacao()
        {
            return salario *0.5;
        }
        public override void AumentarSalario()
        {
            salario *= 1.15;
        }

        public bool Autenticar(string senha)
        {
            return true;
        }
    }
}
