﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.valor * 0.1;
        }
    }
}
