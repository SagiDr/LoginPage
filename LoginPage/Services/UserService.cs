using LoginPage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage.Services
{
      internal class UsersList
      {
        public List<User> Users { get; private set; }
        public UsersList()
        {
            this.Users = new List<User>();
            FillList();
        }   

        private void FillList()
        {
            Users.Add(new User
            {
                userName = "Sagi",
                password = "0000"
            });

            Users.Add(new User
            {
                userName = "Sapir",
                password = "2345"
            });

            Users.Add(new User
            {
                userName = "Ofer",
                password = "5454"
            });

            Users.Add(new User
            {
                userName = "Nachom",
                password = "7677"
            });

            Users.Add(new User
            {
                userName = "Shalom",
                password = "8888"
            });
        }
      }
      internal class UserService
      {
        public UserService()
        {
            users = new UsersList().Users;
        }
        List<User> users;

        public bool IsUserExist(User check)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].userName == check.userName && users[i].password == check.password)
                {
                    return true;
                }
            }
            return false;
        }
      }
}
