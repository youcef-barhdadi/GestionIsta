using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GestionIsta
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void btnSqlServer_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            SqlConnection con=null;
            string dataBase = DataBaseName.Text;
            string server = ServerNameTxt.Text;
            string conctionString = $@"Data Source={server};Initial Catalog={dataBase};Integrated Security=True";
            try
            {
                 con = new SqlConnection(conctionString);
                //progressBar1.Style = ProgressBarStyle.
                await  con.OpenAsync();
                MessageBox.Show("test goood");
                progressBar1.Visible = false;
              //  ConfigurationManager.ConnectionStrings.Add(new ConnectionStringSettings());


            }
            catch (Exception)
            {

                MessageBox.Show(con.State.ToString());
                progressBar1.Visible = false;

            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtfiles.Enabled = !checkBox1.Checked;
            btntext.Text = "create";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBosqlfile.Enabled = !radioButton1.Checked;
            groupBoxFile.Enabled = !radioButton1.Enabled;
            groupBoxsql.Enabled = true;
        }

        private void radioButtontextFile_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxsql.Enabled = !radioButtontextFile.Checked;
            groupBosqlfile.Enabled = !radioButtontextFile.Checked;
            groupBoxFile.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxsql.Enabled = !radioButton2.Checked;
            groupBoxFile.Enabled = !radioButton2.Enabled;
            groupBosqlfile.Enabled = true;
        }

        private void btntext_Click(object sender, EventArgs e)
        {
           
        }
    }
}
