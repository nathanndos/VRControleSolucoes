using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Solucao
    {
        public static int IdSolucoes { private get; set; }
        public int _idSolucao { get; private set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Solucao()
        {
            IdSolucoes++;
            _idSolucao = IdSolucoes;
        }
        public Solucao(int codigo)
        {
            _idSolucao = codigo;
        }
    }
}
