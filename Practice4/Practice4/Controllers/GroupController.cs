using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UPB.Practice4.Logic.Models;
using UPB.Practice4.Logic.Managers;

namespace Practice4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        private readonly GroupManager groupManager;    
        public GroupController()
        {
            groupManager = new GroupManager();
        }
        [HttpGet]
        public List<Group> GetGroups()
        {
            return groupManager.getAll();
        }
        [HttpPost]
        
        public Group CreateGroup([FromBody] Group group)
        {
            return groupManager.
        }
    }
}
