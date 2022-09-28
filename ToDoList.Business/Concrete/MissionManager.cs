﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Business.Abstract;
using ToDoList.DataAccess.Concrete;
using ToDoList.Entities.Concrete;

namespace ToDoList.Business.Concrete
{
    public class MissionManager : IMissionService
    {

        MissionDal missionDal = new MissionDal();

        public Mission AddT(Mission t)
        {
            return missionDal.TAdd(t);  
        }

        public void DeleteT(int id)
        {
            missionDal.TDelete(id);
        }

        public List<Mission> GetAll()
        {
            return missionDal.GetAll();
        }

        public void UpdateT(int id, Mission t)
        {
            missionDal.TUpdate(id, t);  
        }
    }
}
