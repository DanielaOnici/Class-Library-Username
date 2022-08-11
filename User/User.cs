using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User
{
    public class User
    {
        private string username, password;
        private int id;
        private DateTime dateCreated;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }

        public string messages;

        public User(int id, string username, string password, DateTime dateCreated)
        {
            id = Id;
            username = Username;
            password = Password;
            dateCreated = DateCreated;

            //The username can't be null/empty or be a space
            if (username == "" || username == null)
                messages += "Username can't be empty.\n";

            //Created a regex to accept minimum 6 characters and must contain a letter, a digit and a punctuation symbol
            Regex validPassword = new Regex(@"^(?=.*[0-9])(?=.*[a-zA-Z])(?=.*[!()–[{}\]:;',?/~^]).{6,}$");

            //The password must follow the minimum requirements of the regex
            if (!validPassword.IsMatch(password))
                messages += "Password must contain a letter, a digit, a punctuation symbol and have at least 6 characters.\n";

            //The date time can't be in the future
            if (dateCreated > DateTime.Today)
                messages += "Date can't be in the future.\n";
        }

        public override string ToString()
        {
            return $"{id}; {username}; {password}; {dateCreated}";
        }
    }
}
