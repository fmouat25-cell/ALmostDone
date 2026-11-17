using System.Diagnostics.Eventing.Reader;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text.Json;

namespace NEA_Music_Managment_and_reccomendation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserInfo.json");
        private string password;
        private string username;

        private void Form2_Load(object sender, EventArgs e)
        {
            Passwordbox.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool containsspecialChar = false;
            username = UsernameBox.Text;
            password = Passwordbox.Text;
            for (int i = 0; i < password.Length; i++)
            {
                if (!Char.IsLetterOrDigit(password[i]))
                {
                    containsspecialChar = true;
                    break;
                }
            }
            if (username.IsWhiteSpace() | password.IsWhiteSpace())
            {
                label4.Text = "Error, please enter a valid input";  // In the future may add it so a character requirment is needed especially for password
            }
            else if (username.Length < 8)
            {
                label4.Text = "Your Username must contain 8 characters";
            }
            else if(password.Length < 8)
            {
                label4.Text = "Your password must contain 8 characters";
            }
            

            else if (containsspecialChar == false)
            {
                label4.Text = "Your password must contain a special character";
            }

                
            else
            {
                UserInfo info = new UserInfo
                {
                    Username = username,
                    Password = password
                };
                string data = JsonSerializer.Serialize(info);
                List<UserInfo> userlist = new List<UserInfo>();
                string Existing = File.ReadAllText(filepath);
                //Converts from Json format to a regular string 
                userlist = JsonSerializer.Deserialize<List<UserInfo>>(Existing);
                userlist.Add(info);
                //Makes the c# string list into json format that can then be uploaded to the Json document
                string correct = JsonSerializer.Serialize(userlist);
                File.WriteAllText(filepath, correct);
                this.Close();



            }




        }

        public class UserInfo
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }

}
