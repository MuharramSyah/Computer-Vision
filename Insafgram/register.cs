using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace Insafgram
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        Form1 form1 = new Form1();
        bool validasiEmail;
        string DOB;
        private void submit_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please insert your data!");
                return;
            }
            if (!gendermale.Checked || genderfemale.Checked)
            {
                MessageBox.Show("Please choose your gender!");
                return;
            }

            int year = dateTimePicker1.Value.Year;
            int now = DateTime.Now.Year;

            int range = now - year;

            if (range >= 16)
            {
                check = false;
                MessageBox.Show("Your Age must be oldest than 16 years!");
                return;
            }
            
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Password not match!");
                keterangan.Text = "Password not match";
                check = false;
                return;
            }
            if (textBox2.Text.Length < 6)
            {
                MessageBox.Show("Your Password must be lenght than 6 characters");
            }
            if (textBox2.Text == "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "^[a-zA-Z0-9 ]"))
                {
                    check = false;
                    MessageBox.Show("Password Must be Alphanumeric");
                    return;
                }
                MessageBox.Show("Please insert your email!");
                return;
            }
            if (!textBox1.Text.Contains('@') && !textBox1.Text.Contains('.'))
            {
                check = false;
                MessageBox.Show("Email must be contains @ and .");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "@.*\\w(\\.)"))
            {
                check = false;
                MessageBox.Show(". must be after @");
                return;
            }
            if (!checkBox1.Checked)
            {
                check = false;
                MessageBox.Show("Please agree term and condition!");
                return;
            }
            if (check == true)
            {
                //insertData();
                readFileText();
                writeFileText();
                this.Hide();
                form1.Show();
            }
        }
        string path = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True; Connect Timeout = 30";
        void insertData()
        {
            try
            {
                SqlConnection con = new SqlConnection(path);
                SqlCommand cmd = new SqlCommand("insert into Account values(@email,@password,@gender,@date)",con);
                cmd.Parameters.AddWithValue("@email",textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                if (gendermale.Checked)
                {
                    cmd.Parameters.AddWithValue("@gender", "Male");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@gender", "Female");
                }
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Register Successfull!");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }
        public void readFileText()
        {
            try
            {
                validasiEmail = true;
                int lineCount = 0;
                var list = new List<string[]>();
                string line;
                StreamReader sr = new StreamReader("file.txt");
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line.Split('/'));
                    lineCount++;
                }
                for (int i = 0; i < lineCount; i++)
                {
                    if (textBox1.Text.CompareTo(list[i][0]) == 0)
                    {
                        validasiEmail = false;
                        MessageBox.Show("Email has Already!");
                    }
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void writeFileText()
        {
            try
            {
                string path = "file.txt";
                string word;
                if (validasiEmail == true)
                {
                    if (gendermale.Checked)
                    {
                        word = textBox1.Text + "/" + textBox2.Text + "/" + "Male" + "/" + dateTimePicker1.Text + Environment.NewLine;
                    }
                    else
                    {
                        word = textBox1.Text + "/" + textBox2.Text + "/" + "Female" + "/" + dateTimePicker1.Text + Environment.NewLine;
                    }
                    File.AppendAllText(path,word);
                    string readText = File.ReadAllText(path);
                    Console.WriteLine(readText);
                    MessageBox.Show("Register Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
