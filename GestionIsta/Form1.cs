using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionIstaLibrary.Controllers;
using GestionIstaLibrary;
using GestionIstaLibrary.Model;
using System.IO;
using System.Configuration;
using GestionIsta.View;

namespace GestionIsta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // panel1.Controls.Add(new AdminVeiw());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool Verifer()
        {
            if (txtUserName.Text == "")
            {
                return false;
            }
            if(txtPassword.Text=="")
            {
                return false;
            }
            return true;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
  
            if (Verifer())
            {
                UserModel model=  GestionIstaLibrary.GlobalConfig.dataconnction.GetUser(txtUserName.Text, txtPassword.Text);
                if (model != null)
                {
                    Program.User = model;

                    MainFormcs f = new MainFormcs();
                    f.Show();

                }
                else
                {
                    MessageBox.Show("a");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form2 f = new Form2();
            if (f.ShowDialog() == DialogResult.Cancel)
                this.Enabled = true;
        }
        #region Design
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            p.Image = Image.FromFile(@"../../Images/icons8_Eye.ico");
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            p.Image = Image.FromFile(@"../../Images/c.ico");
            txtPassword.UseSystemPasswordChar = true;
        }
        #endregion
    }
}
