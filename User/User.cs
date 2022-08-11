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

        public User(int id, string username, string password, DateTime dateCreated)
        {
            id = Id;
            username = Username;
            password = Password;
            dateCreated = DateCreated;

            //The username can't be null/empty or be a space
            if (String.IsNullOrEmpty(username.Trim()))
                throw new ArgumentNullException("Username can't be empty.");

            //Created a regex to accept minimum 6 characters and must contain a letter, a digit and a punctuation symbol
            Regex validPassword = new Regex(@"^(?=.*[0-9])(?=.*[a-zA-Z])(?=.*[!()–[{}\]:;',?/~^]).{6,}$");

            //The password must follow the minimum requirements of the regex
            if (!validPassword.IsMatch(password.Trim()))
                throw new ArgumentException("Password must contain a letter, a digit, a punctuation symbol and have at least 6 characters.");

            if (dateCreated > DateTime.Today)
                throw new ArgumentException("Can't be in the future");

        }

        public override string ToString()
        {
            return $"{id}; {username}; {password}; {dateCreated}";
        }
    }
}
