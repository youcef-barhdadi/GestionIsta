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

namespace GestionIsta.View
{
    public partial class FormateurView : UserControl
    {
        public FormateurView()
        {
            InitializeComponent();    dataGridView1.DataSource = GlobalConfig.dataconnction.GetAllFormateurs();
        }

        private void buttonRoaded1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
