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
            string content = txtbPhrase.Text.Trim();
            listOfPhrases.Add(content);
            txtbPhrase.Clear();
        }

        private void btnShowAllPhrases_Click(object sender, EventArgs e)
        {
            string[] allPhrases = new string[listOfPhrases.Count];

            for(int i = listOfPhrases.Count - 1; i >= 0; i--)
            {
                allPhrases[(listOfPhrases.Count - 1) - i] = Regex.Replace(listOfPhrases[i], @"\p{P}", "");
            }

            for (int i = 0; i < allPhrases.Length; i++)
            {
                rtxtbPhrases.AppendText($"{i}: {allPhrases[i]}\n");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbId.Enabled = false;
        }

        public bool newIdClicked = false;

        private void btnGetNewId_Click(object sender, EventArgs e)
        {
            newIdClicked = true;
            rtxtbInfo.Clear();
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
            rtxtbInfo.Clear();

            if (newIdClicked == false)
            {
                rtxtbInfo.AppendText("Please, select Get New ID first");
            }
            else
            {
                User.User myUser = new(id, username, password, dateTime);
                rtxtbInfo.AppendText(myUser.messages);

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