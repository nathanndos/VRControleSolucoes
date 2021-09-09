using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using VRControleSolucao.UI;
using System.Data;

namespace BLL
{
    class SolucaoBLL
    {
        public static void save(Solucao solucao)
        {
                SolucaoDAL.add(solucao);
        }
        public static void update(int codigo, string nome, string descricao)
        {
            Solucao solucao = new Solucao(codigo, nome, descricao);
            SolucaoDAL.update(solucao);
        }
        public static void getLast()
        {
            Solucao.IdSolucoes = SolucaoDAL.getLast();
        }
        public static DataTable getDataTable()
        {
            return SolucaoDAL.getData();
        }
        public static DataTable consultaNome(string name, bool tipoNome)
        {
            if (tipoNome == true)
            {
                return SolucaoDAL.consultNome(name);
            }
            return SolucaoDAL.consultCodigo(int.Parse(name));
        }
        public static Solucao get(int codigo)
        {
            return SolucaoDAL.get(codigo);
        }
    }
}
