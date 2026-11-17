using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;
namespace NEA_Music_Managment_and_reccomendation
{
    public partial class Form1 : Form
    {
        
        string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserInfo.json");
        //Creates strings that can be accessed anywhere within the main class
        public string LoggedInUsername { get; private set; }
        private string password;
        private string username;
        private static Form2 createaccount;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createaccount = new Form2();
            Passwordbox.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            username = UsernameBox.Text;
            password = Passwordbox.Text;
            //Creates an array of info that is equal to the users login info
            UserInfo info = new UserInfo
            {
                Username = username,
                Password = password
            };
            //Converts the array in a string called data that is now in Json formula
            string data = JsonSerializer.Serialize(info);
            string value = File.ReadAllText(filepath);
            Form3 MainPage = new Form3(username);
            if (File.Exists(filepath))
            {
                List<UserInfo> UsersandPword = new List<UserInfo>();
                UsersandPword = JsonSerializer.Deserialize<List<UserInfo>>(value);
                bool valid = false;
                // loops to check if the data inputted is contained with the json file

                for (int i = 0; i < UsersandPword.Count; i++)
                {
                    if (username == UsersandPword[i].Username && password == UsersandPword[i].Password) // Fetches all the Info from the Json file and either outputs the Username if.Username is used or Password if .Password is used
                    {
                        valid = true;
                    }

                }
                if (valid == true)
                {
                    string userfilename = username + "'sFile.json";
                    if (File.Exists(userfilename))
                    {
                        LoggedInUsername = username;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        FileInfo inf = new FileInfo
                        {
                            Username = username,
                            Rates = new List<Ratings>()
                        };

                        List<FileInfo> fileinf = new List<FileInfo> { inf };
                        string Serial = JsonSerializer.Serialize<List<FileInfo>>(fileinf);
                        File.WriteAllText(userfilename, Serial);


                    }
                    



                }
                else
                {
                    label4.Text = "Incorrect Username Or Password";
                }



            }
        }

        private void Passwordbox_TextChanged(object sender, EventArgs e)
        {

        }
        public class UserInfo
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        public class FileInfo
        {
            public string Username { get; set; }
            public List<Ratings> Rates { get; set; } = new List<Ratings>();
 
        }
        public class Ratings
        {
            public string Hash { get; set; }
            public Double Rate { get; set; }
        }



        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //changes over to the other form
            createaccount.Show();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
