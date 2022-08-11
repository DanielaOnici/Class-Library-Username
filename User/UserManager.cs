namespace User
{
    public class UserManager
    {
        private string fileUsers;

        public UserManager()
        {
            fileUsers = @"C:\Folder\users.txt";

            try
            {
                if (!Directory.Exists(@"C:\Folder"))
                {
                    //When the directory doesn't exist, it is created
                    Directory.CreateDirectory(@"C:\Folder");
                }
                if (!File.Exists(fileUsers))
                {
                    //When the file doesn't exist, it is created
                    using (FileStream newFile = File.Create(fileUsers)) ;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }

        }
        public int GetNewId()
        {
            List<string> ids = new List<string>();
            FileStream fs = new FileStream(fileUsers, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string record;

            while (!sr.EndOfStream)
            {
                record = sr.ReadLine();
                ids.Add(record);
            }
            sr.Dispose();
            fs.Dispose();
            if (ids.Count > 0)
                return ids.Count + 1;
            else
                return 1;
        }

        public void AddNewUser(User user)
        {
            StreamWriter writer = new StreamWriter(fileUsers, append: true);
            writer.WriteLine(user.ToString());
            writer.Dispose();
        }

    }
}