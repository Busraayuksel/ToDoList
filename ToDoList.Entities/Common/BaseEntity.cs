using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Entities.Common
{
    public class BaseEntity
    {
        [Key] 
        public int Id { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; } = DateTime.Now;
    }
}
