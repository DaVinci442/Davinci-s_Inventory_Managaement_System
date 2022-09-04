using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Davinci_s_Inventory_Managaement_System
{
    public partial class UserModule : Form
    {

        SqlConnection con= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Davinci\OneDrive\Documents\vinciDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm= new SqlCommand();
        public UserModule()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you certain on saving this user", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO userTable(username,fullname,password,phone)values(@Username,@Fullname,@Password,@Phone)", con);
                    cm.Parameters.AddWithValue("@Username", textusename.Text);
                    cm.Parameters.AddWithValue("@Fullname", textFullname.Text);
                    cm.Parameters.AddWithValue("@Password", passtext.Text);
                    cm.Parameters.AddWithValue("@Phone", textphone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User saved successfully.");
                    Clear();
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();

        }
        public void Clear()
        {
            textusename.Clear();
            textFullname.Clear();
            passtext.Clear();
            textphone.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
