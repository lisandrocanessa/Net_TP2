using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;
using System.Data;

namespace Business.Logic
{
    public class MateriaLogic : BusinessLogic
    {
        MateriaAdapter MateriaData;

        public MateriaLogic()
        {
            MateriaData = new MateriaAdapter();
        }

        public DataTable GetAll(int idplan)
        {
            return MateriaData.GetAll(idplan);
        }

        public Materia GetOne(int idMateria)
        {
            return MateriaData.GetOne(idMateria);
        }

        public void Delete(int id)
        {
            MateriaData.Delete(id);
        }

        public void Save(Materia MateriaActual)
        {
            MateriaData.Save(MateriaActual);
        }
    }
}
