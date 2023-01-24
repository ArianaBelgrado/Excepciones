using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class Alumno
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value.Trim().Length < 1 || value.Trim().Length > 50)
                {
                    throw new Exception("El nombre no puede estar vacio o superra los 50 caracteres.");
                }

                nombre = value.Trim();
            }
        }
    }
}
