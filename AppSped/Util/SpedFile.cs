using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSped.Util
{
    public class SpedFile
    {
        
        string Arquivo;

        public SpedFile(string arquivo)
        {
            Arquivo = arquivo;
        }


        public List<string> ReadSped()
        {
            List<string> Lines = new List<string>();

            string line;

            try
            {

                StreamReader sr = new StreamReader(this.Arquivo);
                
                line = sr.ReadLine();
                
                while (line != null)
                {
                    line = sr.ReadLine();
                }

                sr.Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return Lines;
        }
    }
}