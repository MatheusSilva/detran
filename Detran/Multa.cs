using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using System.Threading.Tasks;

namespace Detran
{
    /// <summary>classe Multa da camada Modelo</summary>
    public class Multa
	{
        public int Codigo { get; set; }
        public string Infracao { get; set; }
        public int Pontos { get; set; }
        public string Penalidade { get; set; }
        public double Valor { get; set; }
	}
}
