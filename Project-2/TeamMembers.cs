using System;
using System.Collections.Generic;

namespace Project_2
{
    public class TeamMembers
    {
        public List<User> userList = new List<User>();

        public TeamMembers(){
            userList.Add(new User(1, "John Locke"));
            userList.Add(new User(2, "Lev Tolstoy"));
            userList.Add(new User(3, "Jack London"));
            userList.Add(new User(4, "Adam Adam"));
            userList.Add(new User(5, "David Navarro"));
        }
    }
}
