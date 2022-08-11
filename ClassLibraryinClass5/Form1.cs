using System.Linq;
using System.Text.RegularExpressions;

namespace ClassLibraryinClass5
{
    public partial class Form1 : Form
    {
        public List<string> listOfPhrases = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSavePhrase_Click(object sender, EventArgs e)
        {
            //Storing each content of the txtbox into a list
            string content = txtbPhrase.Text.Trim();
            listOfPhrases.Add(content);

            //Clearing the txtbox
            txtbPhrase.Clear();
        }

        private void btnShowAllPhrases_Click(object sender, EventArgs e)
        {
            string[] allPhrases = new string[listOfPhrases.Count];

            //Including each content of the list reversed in an array
            for(int i = listOfPhrases.Count - 1; i >= 0; i--)
            {
                allPhrases[(listOfPhrases.Count - 1) - i] = Regex.Replace(listOfPhrases[i], @"\p{P}", "");
            }

            //Showing the array content with the index
            for (int i = 0; i < allPhrases.Length; i++)
            {
                rtxtbPhrases.AppendText($"{i}: {allPhrases[i]}\n");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Disabling the txtbox for ID
            txtbId.Enabled = false;
        }

        public bool newIdClicked = false;

        private void btnGetNewId_Click(object sender, EventArgs e)
        {
            newIdClicked = true;
            //Clearing the richtextbox
            rtxtbInfo.Clear();

            //Calling the method to create new ID
            User.UserManager myUserManager = new();
            txtbId.Text = myUserManager.GetNewId().ToString();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            User.UserManager myUserManager = new();
            int id = int.Parse(txtbId.Text);
            string username = txtbUsername.Text.Trim();
            string password = txtbPassword.Text.Trim();
            DateTime dateTime = dateTimePicker.Value.Date;

            //Clearing the richtextbox
            rtxtbInfo.Clear();

            //If the user doesn't click the Create New Id first a message is shown
            if (newIdClicked == false)
            {
                rtxtbInfo.AppendText("Please, select Get New ID first");
            }
            else
            {
                User.User myUser = new(id, username, password, dateTime);
                rtxtbInfo.AppendText(myUser.messages);

                //When no error is shown a user is added
                if(rtxtbInfo.Text == "")
                {
                    myUser.Id = id;
                    myUser.Username = username;
                    myUser.Password = password;
                    myUser.DateCreated = dateTime;
                    myUserManager.AddNewUser(myUser);
                    rtxtbInfo.AppendText("User added succesfully!");
                }
            }
        }
    }
}