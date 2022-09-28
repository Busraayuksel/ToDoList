using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Common;

namespace ToDoList.Entities.Concrete
{
    public class Mission : BaseEntity
    {
        public bool IsCompleted { get; set; } = false;
        public string Text { get; set; }
        public bool IsStarred { get; set; } = false;
        public string? NoteText { get; set; }

        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
