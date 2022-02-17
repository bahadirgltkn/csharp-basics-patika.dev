using System;

namespace Project_2
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        public  User(int userId, string userName){
            this.UserId = userId;
            this.UserName = userName;
        }
    }
}