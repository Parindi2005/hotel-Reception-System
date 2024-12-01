using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.User_Controls
{
    public partial class UC_AddRoom : UserControl
    {
        ClassFunction fn = new ClassFunction(); // create object of cassfunction
        string query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds =  fn.getData(query);    //call getdata function to display in Uc_Addroom
            DataGridView_2 .DataSource = ds.Tables[0];

        }
    }
}
