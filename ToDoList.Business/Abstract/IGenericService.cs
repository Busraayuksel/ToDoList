using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Business.Abstract
{
    public interface IGenericService<T>
    {
        public List<T> GetAll();

        public T AddT(T t);

        public void UpdateT(int id, T t);

        public void DeleteT(int id);
    }
}
