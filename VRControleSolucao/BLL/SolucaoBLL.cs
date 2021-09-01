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
        public static void getLast()
        {
            Solucao.IdSolucoes = SolucaoDAL.getLast();
        }
        public static DataTable getDataTable()
        {
            return SolucaoDAL.getData();
        }
    }
}
