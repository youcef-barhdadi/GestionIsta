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
    public partial class AdminVeiw : UserControl
    {
        public AdminVeiw()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindForm().Controls["panelMain"].Controls.Clear();
            FindForm().Controls["panelMain"].Controls.Add(new StagiaireView());
        }

        private void Home_Click(object sender, EventArgs e)
        {
            FindForm().Controls["panelMain"].Controls.Clear();
            FindForm().Controls["panelMain"].Controls.Add(new FormateurView());
        }
    }
}
