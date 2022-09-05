using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Davinci_s_Inventory_Managaement_System
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
           
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelMain.Controls.Add(childForm);  
                panelMain.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
             
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new UseForm());
        }
    }
}
