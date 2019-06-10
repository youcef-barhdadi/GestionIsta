using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionIsta.View
{
    public partial class ReglureUser : UserControl
    {
        public ReglureUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindForm().Controls["panelMain"].Controls.Clear();
            FindForm().Controls["panelMain"].Controls.Add(new StagiaireView());
            FindForm().Controls["panelMain"].Controls[0].Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
