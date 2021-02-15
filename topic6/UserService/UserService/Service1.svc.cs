using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace UserService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        Random random = new Random();
        List<User> userList = new List<User>();

        public Service1()
        {
            User user1 = new User(1, "Fred", true, 92000, GetSomeRandomScores(random));
            User user2 = new User(2, "Wilma", false, 45000, GetSomeRandomScores(random));
            User user3 = new User(3, "Barney", true, 70000, GetSomeRandomScores(random));
            User user4 = new User(4, "Betty", false, 30000, GetSomeRandomScores(random));
            User user5 = new User(5, "Pebbles", true, 20, GetSomeRandomScores(random));
            User user6 = new User(6, "BamBam", false, 20, GetSomeRandomScores(random));

            userList.Add(user1);
            userList.Add(user2);
            userList.Add(user3);
            userList.Add(user4);
            userList.Add(user5);
            userList.Add(user6);
        }


        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public UserDTO GetAllUsers()
        {
            UserDTO userDTO = new UserDTO();
            userDTO.MessageCode = 1;
            userDTO.MessageText = "Everybody is here";
            userDTO.UserList = userList;
            return userDTO;
        }

        public UserDTO GetUserById(string id)
        {
            UserDTO userDTO = new UserDTO();
            List<User> returnTheseUsers = userList.Where(x => x.Id.Equals(Int32.Parse(id))).ToList();
            
            if(returnTheseUsers.Count > 0)
            {
                userDTO.UserList = returnTheseUsers;
                userDTO.MessageCode = returnTheseUsers.Count;
                userDTO.MessageText = "The people who have '" + id + "' as their id";
            } else
            {
                userDTO.UserList = returnTheseUsers;
                userDTO.MessageCode = -1;
                userDTO.MessageText = "User does not exist";
            }

            return userDTO;
        }

        public UserDTO GetUserByName(string name)
        {
            UserDTO userDTO = new UserDTO();
            List<User> returnTheseUsers = userList.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();

            userDTO.UserList = returnTheseUsers;
            userDTO.MessageCode = returnTheseUsers.Count;
            userDTO.MessageText = "The people who have '" + name + "' in their name";
            return userDTO;
        }





        private static List<int> GetSomeRandomScores(Random r)
        {
            List<int> listOfScores = new List<int>();
            listOfScores.Add(r.Next(100));
            listOfScores.Add(r.Next(100));
            listOfScores.Add(r.Next(100));
            return listOfScores;
        }
    }
}
