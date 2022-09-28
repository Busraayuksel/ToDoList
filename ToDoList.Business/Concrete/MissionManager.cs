using System;
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

        public Mission AddMission(Mission mission)
        {
            return missionDal.TAdd(mission);
        }

        public void DeleteMission(int id)
        {
            missionDal.TDelete(id);
        }

        public List<Mission> GetAll()
        {
            return missionDal.GetAll();
        }

        public void UpdateMission(int id, Mission mission)
        {
           missionDal.TUpdate(id, mission);
        }
    }
}
