using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_03_ByteBank
{
    public class Cliente
    {
        public string Nome { get; set; }
        private string _cpf;
        public string Profissao { get; set; }

        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                //Espaço reservado para a implementação da validação do CPF
                _cpf = value;
            }
        }
    }
}
