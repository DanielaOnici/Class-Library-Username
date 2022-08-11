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

        private void btnGetNewId_Click(object sender, EventArgs e)
        {
            User.UserManager myUserManager = new User.UserManager();
            txtbId.Text = myUserManager.GetNewId().ToString();
        }
    }
}