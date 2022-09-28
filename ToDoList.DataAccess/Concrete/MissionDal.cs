using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.DataAccess.EntityFrameWork;
using ToDoList.DataAccess.Abstract;
using ToDoList.DataAccess.Contexts;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAccess.Concrete
{
    public class MissionDal : EfEntityRepositoryBase<Mission,ApplicationDbContext>, IMissionDal
    {
    }
}
