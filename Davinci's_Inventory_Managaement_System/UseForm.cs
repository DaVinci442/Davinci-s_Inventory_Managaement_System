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

  
    public partial class UseForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Davinci\OneDrive\Documents\vinciDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public UseForm()
        {
            InitializeComponent();
            Loaduser();
        }

        private void UseForm_Load(object sender, EventArgs e)
        {

        }
        
        public void Loaduser()
        {
            int i = 0;
            Userdvg.Rows.Clear();
            cm = new SqlCommand(" SELECT * FROM userTable ", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                Userdvg.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void customerButtons1_Click(object sender, EventArgs e)
        {
            UserModule userModule = new UserModule();
            userModule.savebtn.Enabled = true;
            userModule.updatebtn.Enabled = false;
            userModule.ShowDialog();
        }
    }
}
