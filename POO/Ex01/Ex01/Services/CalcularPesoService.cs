using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Services
{
    internal class CalcularPesoService
    {

        public decimal CalcularPesoTotal(decimal peso, int quantidade)
        {
            return peso * quantidade;

        }
    }
}
