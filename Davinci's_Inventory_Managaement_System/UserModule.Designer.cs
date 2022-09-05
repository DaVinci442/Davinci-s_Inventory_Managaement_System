namespace Davinci_s_Inventory_Managaement_System
{
    partial class UserModule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.customerButtons1 = new Davinci_s_Inventory_Managaement_System.customerButtons();
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.textusename = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textFullname = new System.Windows.Forms.TextBox();
            this.Fullname = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.textphone = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButtons1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.customerButtons1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 39);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.White;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(416, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(23, 17);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 8;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // customerButtons1
            // 
            this.customerButtons1.BackColor = System.Drawing.Color.Transparent;
            this.customerButtons1.HoverNormal = ((System.Drawing.Image)(resources.GetObject("customerButtons1.HoverNormal")));
            this.customerButtons1.Image = ((System.Drawing.Image)(resources.GetObject("customerButtons1.Image")));
            this.customerButtons1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButtons1.ImageNormal")));
            this.customerButtons1.Location = new System.Drawing.Point(935, 7);
            this.customerButtons1.Name = "customerButtons1";
            this.customerButtons1.Size = new System.Drawing.Size(37, 28);
            this.customerButtons1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButtons1.TabIndex = 1;
            this.customerButtons1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Module";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Location = new System.Drawing.Point(55, 87);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(58, 13);
            this.Username.TabIndex = 6;
            this.Username.Text = "Username:";
            // 
            // textusename
            // 
            this.textusename.Location = new System.Drawing.Point(121, 84);
            this.textusename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textusename.Name = "textusename";
            this.textusename.Size = new System.Drawing.Size(252, 20);
            this.textusename.TabIndex = 5;
            this.textusename.TextChanged += new System.EventHandler(this.textusename_TextChanged);
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(121, 157);
            this.passtext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(252, 20);
            this.passtext.TabIndex = 7;
            this.passtext.UseSystemPasswordChar = true;
            this.passtext.TextChanged += new System.EventHandler(this.passtext_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Location = new System.Drawing.Point(57, 160);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 13);
            this.Password.TabIndex = 8;
            this.Password.Text = "Password:";
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.savebtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(121, 242);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(58, 28);
            this.savebtn.TabIndex = 9;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Blue;
            this.updatebtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(200, 242);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 28);
            this.updatebtn.TabIndex = 9;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(295, 242);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 28);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // textFullname
            // 
            this.textFullname.Location = new System.Drawing.Point(121, 120);
            this.textFullname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textFullname.Name = "textFullname";
            this.textFullname.Size = new System.Drawing.Size(252, 20);
            this.textFullname.TabIndex = 5;
            this.textFullname.TextChanged += new System.EventHandler(this.textFullname_TextChanged);
            // 
            // Fullname
            // 
            this.Fullname.AutoSize = true;
            this.Fullname.BackColor = System.Drawing.Color.Transparent;
            this.Fullname.Location = new System.Drawing.Point(55, 123);
            this.Fullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(55, 13);
            this.Fullname.TabIndex = 6;
            this.Fullname.Text = "Full name:";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.BackColor = System.Drawing.Color.Transparent;
            this.Phone.Location = new System.Drawing.Point(55, 197);
            this.Phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(41, 13);
            this.Phone.TabIndex = 11;
            this.Phone.Text = "Phone:";
            this.Phone.Click += new System.EventHandler(this.label2_Click);
            // 
            // textphone
            // 
            this.textphone.Location = new System.Drawing.Point(121, 194);
            this.textphone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textphone.Name = "textphone";
            this.textphone.Size = new System.Drawing.Size(252, 20);
            this.textphone.TabIndex = 10;
            this.textphone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UserModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 303);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.textphone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.Fullname);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textFullname);
            this.Controls.Add(this.textusename);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserModule";
            this.Load += new System.EventHandler(this.UserModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButtons1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private customerButtons customerButtons1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label Fullname;
        private System.Windows.Forms.Label Phone;
        public System.Windows.Forms.Button savebtn;
        public System.Windows.Forms.Button updatebtn;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.TextBox textusename;
        public System.Windows.Forms.TextBox passtext;
        public System.Windows.Forms.TextBox textFullname;
        public System.Windows.Forms.TextBox textphone;
    }
}