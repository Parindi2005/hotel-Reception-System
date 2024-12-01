using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class FormHotel : Form
    {
        public FormHotel()
        {
            InitializeComponent();
        }

       

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtUserName.Text== "pari" && TxtPassword.Text=="pass")
            {
                labelForget_Psswd.Visible = false;
                FormDashboard d1 = new FormDashboard();   //opening after correct login
                this.Hide(); // hide login pge
                d1.Show(); // showing dashboard

            }
            else
            {
                labelForget_Psswd.Visible = true;
                TxtPassword.Clear();
            }
        }
    }
}
