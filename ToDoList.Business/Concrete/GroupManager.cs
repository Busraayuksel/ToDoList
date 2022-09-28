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
    public class GroupManager : IGroupService
    {
        GroupDal groupDal = new GroupDal();
        public Group AddT(Group t)
        {
            return groupDal.TAdd(t);
        }

        public void DeleteT(int id)
        {
            groupDal.TDelete(id);
        }

        public List<Group> GetAll()
        {
            return groupDal.GetAll();
        }

        public void UpdateT(int id, Group t)
        {
            groupDal.TUpdate(id, t);    
        }
    }
}
