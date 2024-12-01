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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCustomerRegister_Click(object sender, EventArgs e)
        {
            panelMove.Left = BtnCustomerRegister.Left+50;
        }

        private void BtnAddRoom_Click_1(object sender, EventArgs e)
        {
            panelMove.Left = BtnAddRoom.Left+10;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront(); // showing add room panel in front after clicking addRoom btn.

        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            panelMove.Left=BtnCheckOut.Left+20;
        }

        private void BtnCustomerDetails_Click(object sender, EventArgs e)
        {
            panelMove.Left=BtnCustomerDetails.Left+50;
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            panelMove.Left=BtnEmployee.Left+10;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
