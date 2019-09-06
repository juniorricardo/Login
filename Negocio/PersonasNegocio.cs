using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Data;

namespace Negocio
{
    public class PersonasNegocio
    {
        public void AgregarPersona(Persona objPersona)
        {
            if (new PersonasDatos().ExisteDni(objPersona.Dni))
            {
                throw new Exception("La persona ya existe en la base de datos");
            }
            else
            {
                new PersonasDatos().AgregarPersona(objPersona);
            }
        }

        public DataTable ListarPersonasDS()
        {

            return new PersonasDatos().ListarPersonaDS();

        }

        public void ActualizarPersonasDs(DataTable dataSource)
        {
            new PersonasDatos().ActualizarPersonasDs(dataSource);
        }
    }
}
