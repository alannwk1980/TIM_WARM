using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class UF
    {
        public UF(string nUF, string descUF, string particao)
        {
            NUF = nUF;
            DescUF = descUF;
            Particao = particao;
        }

        public string NUF { get; set; }
        public string DescUF { get; set; }
        public string Particao { get; set; }
    }
}
