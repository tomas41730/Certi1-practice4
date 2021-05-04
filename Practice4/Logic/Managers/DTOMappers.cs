using System;
using System.Collections.Generic;
using System.Text;
using UPB.Practice4.Logic.Models;

namespace UPB.Practice4.Logic.Managers
{
    static class DTOMappers
    {
        public static List<Group> MapGroups(List<Data.Models.Group> groups)
        {
            List<Group> mappedGroups = new List<Group>();
            foreach(Data.Models.Group g in groups)
            {
                mappedGroups.Add(new Group { 
                id = g.id,
                name = g.name,
                availableSlots = g.availableSlots
                });
            }
            return mappedGroups;
        }

        public static Data.Models.Group MapGroup(Group group)
        {
            Data.Models.Group _group = new Data.Models.Group
            {
                id = group.id,
                name = group.name,
                availableSlots = group.availableSlots
            };

            return _group;

        }
    }
}
