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
    public class PlanLogic : BusinessLogic
    {
        PlanAdapter PlanData;

        public PlanLogic()
        {
            PlanData = new PlanAdapter();
        }

        public Plan GetOne(int id)
        {
            return PlanData.GetOne(id);
        }

        public DataTable GetAll()
        {
            return PlanData.GetAll();
        }

        public void AddPlan(Plan p)
        {
            PlanData.Add(p);
        }
    }
}
