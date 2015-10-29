using Data.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class EspecialidadLogic:BusinessLogic
    {
        EspecialidadAdapter EspecialidadData;

        public EspecialidadLogic()
        {
            EspecialidadData = new EspecialidadAdapter();
        }
        public DataTable DameEspecialidades()
        {
            return EspecialidadData.GetAll();
        }
    }
}
