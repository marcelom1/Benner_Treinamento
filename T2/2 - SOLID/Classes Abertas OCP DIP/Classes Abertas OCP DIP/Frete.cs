﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abertas_OCP_DIP
{
    public class Frete : IServicoDeEntrega
    {
        public double Para(string cidade)
        {
            
            if ("SAO PAULO".Equals(cidade.ToUpper()))
            {
                return 15;
            }
            return 30;
        }
    }
}
