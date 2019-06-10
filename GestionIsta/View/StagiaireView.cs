using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionIstaLibrary;
using GestionIstaLibrary.Model;
namespace GestionIsta.View
{
    public partial class StagiaireView : UserControl
    {
        List<StagiaireModel> list;
        public StagiaireView()
        {
            InitializeComponent();
         list= GlobalConfig.dataconnction.GetAllStagiaire();

            dataGridView1.DataSource = list;
        }

        private void buttonRoaded1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                dataGridView1.DataSource = list.Where(x => x.PersonID == Convert.ToInt16(textBox4.Text)).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
