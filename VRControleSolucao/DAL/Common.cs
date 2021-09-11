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
        public static string get()
        {
            StreamReader sr = new StreamReader(@"ArqID.txt");
            return sr.ReadLine().ToString();
        }
    }
}
