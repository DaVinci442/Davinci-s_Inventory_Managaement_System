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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == false)
                textPass.UseSystemPasswordChar = true;

            else
                textPass.UseSystemPasswordChar = false;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application","Confirm",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textname.Clear();
            textPass.Clear();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
