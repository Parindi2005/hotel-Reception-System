using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    internal class ClassFunction
    {
        protected SqlConnection getConnection ()
        {
            SqlConnection con = new SqlConnection ();
            con.ConnectionString = " data source =  PARINDINITHISH ; database=HotelManage;integrated sequrity=True";
            return con; // 'con'is object of sql connection gag
        }

        public DataSet getData (string query)  // get data from database
            // 'DataSet'-oject that can store data from sql
        {
            SqlConnection con = getConnection (); //getting sql connection
            SqlCommand cmd = new SqlCommand (); //create object of sql command
            cmd.Connection = con;  // pass connection to that command
            cmd.CommandText = query; //return commanmd text
            SqlDataAdapter da = new SqlDataAdapter (cmd); // pass cmd into sqlAdaptor
            DataSet ds = new DataSet ();  // with help of Adoptor, fill data inside DataSet
            da.Fill (ds);
            return ds; // data contains inside 'ds'

        }

        // set data into sql.& do deletion,update,add...
        public void setData (string query, DataSet message)
        {
            SqlConnection con = getConnection ();
            SqlCommand cmd = new SqlCommand (); // create object
            cmd.Connection = con; // pass the connection
            con.Open (); // open the connection
            cmd.CommandText = query; //pass the query
            cmd.ExecuteNonQuery (); //execute
            con.Close ();  // close 

            MessageBox.Show("'"+ message+"'" ,"Sucess",MessageBoxButtons.OK ,MessageBoxIcon.Information);


        }
    }
}
