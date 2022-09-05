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

        private void Userdvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = Userdvg.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                UserModule userModule = new UserModule();
                userModule.textusename.Text = Userdvg.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.textFullname.Text = Userdvg.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.passtext.Text = Userdvg.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.textusename.Text = Userdvg.Rows[e.RowIndex].Cells[4].Value.ToString();

                userModule.savebtn.Enabled = false;
                userModule.updatebtn.Enabled = true;
                userModule.textusename.Enabled = false;
                userModule.ShowDialog();
                Loaduser();
            }
            else if (colName == "delete")
            {
                if(MessageBox.Show(" Are you certain on deleting this user?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand(" DELETE FROM userTable WHERE Phone LIKE '" + Userdvg.Rows[e.RowIndex].Cells[1].Value.ToString() + "' ", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record deleted successfully");
                }
            }
            Loaduser();

        }
    }
}
 