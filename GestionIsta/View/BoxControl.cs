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
    public partial class BoxControl : UserControl
    {
        public BoxControl()
        {
            InitializeComponent();
        }

        private void ClosePictureBox_MouseHover(object sender, EventArgs e)
        {
            ClosePictureBox.Image = Image.FromFile("../../Images/CloseImgeRed.ico");
        }

        private void ClosePictureBox_MouseLeave(object sender, EventArgs e)
        {
            ClosePictureBox.Image = Image.FromFile("../../Images/icons8_Close_Window.ico");
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();

        }

        private void MinPictureBox_Click(object sender, EventArgs e)
        {
         
        }

        private void MinPictureBox_MouseHover(object sender, EventArgs e)
        {
            MinPictureBox.Image = Image.FromFile("../../Images/icons8_Compress_1.ico");
        }

        private void MinPictureBox_MouseLeave(object sender, EventArgs e)
        {
            MinPictureBox.Image = Image.FromFile("../../Images/icons8_Compress.ico");
        }
    }
}
