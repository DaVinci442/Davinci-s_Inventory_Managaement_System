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
    public partial class customerButtons : PictureBox
    {
        public customerButtons()
        {
            InitializeComponent();
        }

        private Image NormalImage;
        private Image HoverImage;

        public Image ImageNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }
        }

        public Image HoverNormal
        {
            get { return HoverImage; }
            set { HoverImage = value; }
        }

        private void customerButtons_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }

        private void customerButtons_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }
}
