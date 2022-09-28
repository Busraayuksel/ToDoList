using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.DataAccess;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAccess.Abstract
{
    public interface IMissionDal : IEntityRepository<Mission> 
    {
        
    }
}
