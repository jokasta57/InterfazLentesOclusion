using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controldeexperimento
{
    class IOFiles
    {
        public static void Write(string mensaje, string ruta)
        {
            string salida = "";
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(mensaje);
                sw.Close();
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
        }

        public static List<string> Read(string ruta)
        {
            List<string> salida = new List<string>();
            StreamReader sr = new StreamReader(ruta);
            try
            {
                while (sr.Peek() > -1)
                {
                    string linea = sr.ReadLine();
                    if (!linea.Equals(""))
                    {
                        salida.Add(linea);
                    }
                }
            }
            catch (Exception e)
            {
                salida.Clear();
                salida.Add(e.Message);
                return salida;
            }
            return salida;
        }
    }
}
