using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsharpBigHomework.Models
{
    //name=email password sex age HistoryList<Post> FavorList<Post>
    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }
        public List<string> FavorList { get; set; }
        public string Password { get; set; }

        public User()
        {

        }

        public User(string name, char sex, string password)
        {
            this.UserId = Guid.NewGuid().ToString();
            this.Name = name;
            this.Sex = sex;
            this.Password = password;
        }
    }
}
