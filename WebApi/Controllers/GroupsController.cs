using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Business.Concrete;
using ToDoList.Entities.Concrete;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        GroupManager groupManager = new GroupManager();

        [HttpGet("get-allgroup")]
        public List<Group> getAllGroup()
        {
            return groupManager.GetAll();
        }
        [HttpPost("add-group")]
        public Group AddGroup(Group group)
        {
            return groupManager.AddT(group);
        }

    }
}
