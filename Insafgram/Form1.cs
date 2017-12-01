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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool statusLogin = false;
        mainMenu menu = new mainMenu();
        string path = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True; Connect Timeout = 30";
        private void Sign_Click(object sender, EventArgs e)
        {
            readFileText();
            if (statusLogin == true)
            {
                this.Hide();
                menu.Show();
                statusLogin = false;
            }
        }
        private void readFileText()
        {
            try
            {
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
                    if ((textBox1.Text.CompareTo(list[i][0]) == 0) && (textBox2.Text.CompareTo(list[i][1]) == 0))
                    {
                        statusLogin = true;
                    }
                }
                if (statusLogin == true)
                {
                    MessageBox.Show("Login Successfull!");
                    
                }
                else
                {
                    MessageBox.Show("Email or Password invalid!");
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void loginViaDatabase()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Input Email or Password");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(path);
                SqlCommand cmd = new SqlCommand("Select * from Account where email=@email and password=@password", con);
                cmd.Parameters.AddWithValue("@email", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);

                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Login Successfull");
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            register reg = new register();
            reg.Show();
        }
    }
}
