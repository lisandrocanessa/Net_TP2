using Data.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class CursoLogic:BusinessLogic
    {
        CursoAdapter CursoData;
        public CursoLogic()
        {
            CursoData = new CursoAdapter();
        }

        public DataTable DameCursos(int idCom)
        {
            return CursoData.GetAll(idCom);
        }

        public DataTable DameCursosAInscribir(int idPlan)
        {
            return CursoData.GetCursosAInscribir(idPlan);
        }
    }
}
