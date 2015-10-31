using Data.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ComisionLogic:BusinessLogic
    {
        ComisionAdapter ComisionData;
        public ComisionLogic()
        {
            ComisionData = new ComisionAdapter();
        }
        public DataTable DameComisiones(int idPlan)
        {
            return ComisionData.GetAll(idPlan);
        }
    }
}
