using System.Collections.Generic;

namespace OneHundredQuestions_ASP.Net.Models
{
    public class EndUser
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Username { get; private set; }
        private string Password { get; set; }
        public string AssociateUsername { get; set; }
        public List<Answer> Answers { get; set; }
        public string Role { get; private set; }
        public int Enabled { get; private set; }

        public EndUser(string name, string username, string password, string associateUsername = "Not Assigned")
        {
            Name = name;
            Username = username;
            Password = password;
            AssociateUsername = associateUsername;
            Password = password;
            Role = "person";
            Enabled = 1;

        }
    }
}