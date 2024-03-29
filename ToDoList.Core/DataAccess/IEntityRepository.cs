﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Common;

namespace ToDoList.Core.DataAccess
{
    public interface IEntityRepository<TEntity> where TEntity : BaseEntity , new()
    {
        public List<TEntity> GetAll();
        public TEntity TAdd(TEntity entity);

        public void TUpdate(int id, TEntity entity);

        public void TDelete(int id);
    }
}
