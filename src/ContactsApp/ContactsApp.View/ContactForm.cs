using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void PhotoButton_MouseEnter(object sender, EventArgs e)
        {
            PhotoButton.Image = Properties.Resources.add_photo_32x32;
        }

        private void PhotoButton_MouseLeave(object sender, EventArgs e)
        {
            PhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
