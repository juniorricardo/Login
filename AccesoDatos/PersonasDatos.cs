using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class PersonasDatos
    {
        public void AgregarPersona(Persona persona)
        {

            ProgramacionNetDSTableAdapters.PersonasTableAdapter da = new ProgramacionNetDSTableAdapters.PersonasTableAdapter();

            da.AgregarUsuario(persona.Dni, persona.Nombre, persona.Apellido, persona.Direccion, persona.Edad.ToString());

        }

        public bool ExisteDni(int Dni)
        {
            ProgramacionNetDSTableAdapters.PersonasTableAdapter da = new ProgramacionNetDSTableAdapters.PersonasTableAdapter();

            int count = (int)da.VerificarDni(Dni);

            return (count > 0);
        }

        public void ActualizarPersonasDs(DataTable dataSource)
        {
            new ProgramacionNetDSTableAdapters.PersonasTableAdapter().Update((ProgramacionNetDS.PersonasDataTable)dataSource);
        }

        public DataTable ListarPersonaDS()
        {

            return new ProgramacionNetDSTableAdapters.PersonasTableAdapter().GetData();

        }
    }
}
