using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class OperaçãoFinanceiraException :Exception
    {
        public OperaçãoFinanceiraException()
        {

        
        }

        public OperaçãoFinanceiraException (string frase) : base(frase)
        {

        }

        public OperaçãoFinanceiraException(string frase, Exception excecaoInterna) : base(frase, excecaoInterna)
        {

        } 


    }
}
