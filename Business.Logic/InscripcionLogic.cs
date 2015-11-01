using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class InscripcionLogic:BusinessLogic
    {
        InscripcionAdapter inscripcionData;

        public InscripcionLogic()
        {
            inscripcionData = new InscripcionAdapter();
        }

        public void GenerarInscripcion(AlumnoInscripcion ai)
        {
            inscripcionData.AddInscripcion(ai);
        }

        public DataTable DameInscripciones(int idUsr)
        {
            return inscripcionData.GetAll(idUsr);
        }
    }
}
