using DrinkApp.DataAccess;
using DrinkApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkApp.Controls
{
    public class GroupController
    {
        GroupDataAccess gDA;
        PersonController pCL;

        public GroupController()
        {
            gDA = new GroupDataAccess();
            pCL = new PersonController();
        }

        public IEnumerable<Group> GetAllGroups()
        {
            return gDA.Groups;
        }

        public void InsertGroup(Group group)
        {
            gDA.InsertGroup(group);
        }

        public void DeleteGroup(Group g)
        {
            pCL.DeletePersonByGroupId(g.Id);
            gDA.DeleteGroup(g);
        }

        public void DeleteGroupTable()
        {
            gDA.DeleteGroupTable();
        }
    }
}
