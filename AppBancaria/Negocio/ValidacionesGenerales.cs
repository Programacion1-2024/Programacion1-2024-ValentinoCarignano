using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ValidacionesGenerales
    {
        public static bool DocumentoValido(string DNI)
        {
            bool response = true;

            if(String.IsNullOrWhiteSpace(DNI) || DNI.Length > 8)
            {
                response = false;
            }

            foreach(char digit in DNI)
            {
                if(!char.IsNumber(digit))
                {
                    response = false;
                }
            }

            return response;
        }

        public static bool NombreValido(string nombre)
        {
            bool response = true;

            if (String.IsNullOrWhiteSpace(nombre) || nombre.Length > 25)
            {
                response = false;
            }

            return response;
        }
    }
}
