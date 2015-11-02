using Data.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class DocenteCursoLogic:BusinessLogic
    {
        DocenteCursoAdapter DocenteCursoData;
        public DocenteCursoLogic()
        {
            DocenteCursoData = new DocenteCursoAdapter();
        }

        public DataTable DameCursosDocente(int idDocente)
        {
            return DocenteCursoData.GetAll(idDocente);
        }

        public void AgregarDocenteACurso(Entities.DocenteCurso dc)
        {
            DocenteCursoData.Insert(dc);
        }
    }
}
