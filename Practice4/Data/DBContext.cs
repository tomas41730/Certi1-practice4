using System;
using System.Collections.Generic;
using System.Text;
using UPB.Practice4.Data.Models;

namespace UPB.Practice4.Data
{
    public class DBContext
    {
        public List<Group> groupTable { get; set; }

        public DBContext()
        {
            groupTable = new List<Group>();
        }

        public List<Group> getAll()
        {
            return groupTable;
        }
        public Group add(Group group)
        {
            groupTable.Add(group);
            return group;
        }
    }
}
