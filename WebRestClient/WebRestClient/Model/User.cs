using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRestClient.Model
{
    public partial class User
    {
        private long id;
        private long uid;
        private string name;
        private string password;
        private string tel;
        private string address;
        public User(User user)
        {
            this.id = 2019302110281;
            this.uid = 2019302110281;
            this.name = user.name;
            this.password = user.password;
            this.tel = user.tel;
            this.address = user.address;
        }
        public User()
        {

        }
        public User(long id, long uid, string name, string password, string tel, string address)
        {
            this.id = id;
            this.uid = uid;
            this.name = name;
            this.password = password;
            this.tel = tel;
            this.address = address;

        }
        public long Id { get => id; set => id = value; }
        public long Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
    }
}