using System;
using System.Text;
namespace OrderProject.Entities
{
    public class Client
    {
        public String name { get; set; }
        public String email { get; set; }
        public DateTime birthday { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthday)
        {
            this.name = name;
            this.email = email;
            this.birthday = birthday;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Client: ");
            str.Append(this.name);
            str.Append(" ");
            str.Append("(" + this.birthday.ToString("dd/MM/yyy") + ")");
            str.Append(" - ");
            str.Append(this.email);

            return str.ToString();
        }
    }
}
