using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionIsta.View;

namespace GestionIsta
{
    public partial class MainFormcs : Form
    {
        bool IsCollapsed ;
        int panleWidth;
        public MainFormcs()
        {
            InitializeComponent();
            labelUserFullName.Text = Program.User.FullName;
            panleWidth = panelLeft.Width;
            IsCollapsed = false;
            if (Program.User.IsAdmin)
            {
                panelCon.Controls.Add(new AdminVeiw());
                panelMain.Controls.Add(new FormateurView());
                panelMain.Controls[0].Dock = DockStyle.Fill;
            }
            else
            {
                panelCon.Controls.Add(new ReglureUser());
                 // panelCon.Controls[0].Dock = DockStyle.Fill;
            }
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed)
            {
                panelLeft.Width += 10;
                if (panelLeft.Width >= panleWidth)
                {
                    timer1.Stop();
                    this.Refresh();
                    IsCollapsed = false;
                    pictureBoxLogo.Visible =true;
                }

            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 80)
                {
                    timer1.Stop();
                    this.Refresh();
                    IsCollapsed = true;
                    pictureBoxLogo.Visible = false;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labeltome.Text = DateTime.Now.Hour + " : " + DateTime.Now.Minute;
        }
    }
}
