using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sviteriExamen.Models
{
    public class UserLib
    {
        List<User> users = new List<User>();    
        public UserLib() { 
            this.users.Add(new User { Id="1", UserName= "estudiante2024", Password= "uisrael2024" });
            this.users.Add(new User { Id="1", UserName= "examen1", Password= "parcial1" });
            this.users.Add(new User { Id="1", UserName= "SantiagoViteri", Password= "2024" });
        }

        public User login(String userName, String pass)
        {
            return this.users.FirstOrDefault(x => x.UserName == userName && x.Password==pass);
        }
    }

    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
