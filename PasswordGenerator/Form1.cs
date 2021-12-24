using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        public static string digits = "012345678901234567890"; //we double the digits to make them more fair 
        public static string lowerCase = "abcdefghijlmnopqrstuvwxyz";
        public static string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string extra = "!@#$%^&*(){}:?><.-=_+~";
        public static string password = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //the default options are set on load
            DoubleBuffered = true;
            passLength.Text = "12";
            upperBox.Checked = true;
            lowerBox.Checked = true;
            digitsBox.Checked = true;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                password = null;
                long length = long.Parse(passLength.Text);
                string dictionary = null;

                //checks for user defined options
                if (upperBox.Checked) { dictionary = dictionary + upperCase; }
                if (lowerBox.Checked) { dictionary = dictionary + lowerCase; }
                if (extraBox.Checked) { dictionary = dictionary + extra; }
                if (digitsBox.Checked) { dictionary = dictionary + digits; }
                if (dictionary == null) { MessageBox.Show("Select at least one option"); goto end; }

                Random rnd = new Random();

                for (int i = 0; i < length; i++)
                {
                    password = password + dictionary[rnd.Next(0, dictionary.Length)];
                }

                resultBox.Text = password;
            }

            catch (FormatException)
            {
                MessageBox.Show("Input a valid password length");
            }
        end:;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(password);
        }
    }
}
