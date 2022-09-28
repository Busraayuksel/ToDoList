using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Business.Concrete;
using ToDoList.Entities.Concrete;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MissionsController : ControllerBase
    {
        MissionManager missionManager = new MissionManager();
        [HttpGet("getMissions")]
        public List<Mission> GetAllMissions()
        {
            return missionManager.GetAll();
        }
        // adding new mission
        [HttpPost("add-mission")]
        public Mission AddMission(Mission mission)
        {
            return missionManager.AddMission(mission);
        }

        // update mission
        [HttpPut("update-mission")]
        public void UpdateMission(int id, Mission mission)
        {
            mission.Id = id;
            missionManager.UpdateMission(id, mission);
        }

        // delete mission
        [HttpDelete("delete-mission")]

        public void DeleteMission(int id)
        {
            missionManager.DeleteMission(id);
        }
    }
}
