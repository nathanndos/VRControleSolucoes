
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class Common
    {   
        public static List<string> get()
        {
            StreamReader sr = new StreamReader(@"ArqID.txt");
            string texto = "";
            List<string> srList = new List<string>();

            while ((texto = sr.ReadLine())!=null)
            {
                srList.Add(texto);
            }
            return srList;
        }
    }
}
