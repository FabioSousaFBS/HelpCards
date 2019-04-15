using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpCards
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public string Municipio { get; set; }
        public string Provedor { get; set; }
        public string Situacao { get; set; }
        public string Problema { get; set; }
        public string Solucao { get; set; }
        public DateTime DataAbertura { get; set; }
    }
}
