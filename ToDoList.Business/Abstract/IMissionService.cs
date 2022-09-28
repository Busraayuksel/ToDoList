using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete;

namespace ToDoList.Business.Abstract
{
    public interface IMissionService 
    {
        public List<Mission> GetAll();

        public Mission AddMission(Mission mission);

        public void UpdateMission(int id, Mission mission);

        public void DeleteMission(int id);
    }

}
