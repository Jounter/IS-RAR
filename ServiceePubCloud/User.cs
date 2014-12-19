using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ServiceePubCloud
{
    [DataContract]
    class User
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Salt { get; set; }

        public User()
        {
            this.Id = 0;
            this.Login = "";
            this.Name = "";
            this.Password = "";
        }

        public User(int id, string login, string name, string password)
        {
            this.Id = id;
            this.Login = login;
            this.Name = name;
            this.Password = password;
        }
        public User(User user)
        {
            this.Id = user.Id;
            this.Login = user.Login;
            this.Name = user.Name;
            this.Password = user.Password;

        }


    }
}
