using System;
using System.Collections.Generic;
using System.Text;
using UPB.Practice4.Data;
using UPB.Practice4.Logic.Models;

namespace UPB.Practice4.Logic.Managers
{
    public class GroupManager
    {
        private readonly DBContext dbContext;
        
        public GroupManager()
        {
            dbContext = new DBContext();
        }

        public List<Group> getAll()
        {
            return DTOMappers.MapGroups(dbContext.getAll());
        }

        public Group createGroup(Group group)
        {
            dbContext.add(DTOMappers.MapGroup(group));
            return group;
        }
    }
}
