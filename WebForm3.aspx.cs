using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication4
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        public String con = "Data Source=DESKTOP-ESHNQ89;Initial Catalog=Ma_B_Tailors;Integrated Security=True";
        public SqlConnection com;
        public SqlCommand comm;
        public SqlDataAdapter adap;
        public DataSet ds;
        SqlDataReader big;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int customer_id = new Appointment().Customer(); //when the user clickes the confirm buttom then this method is envoked
            //int address_id = Address2(); // call the needed methods
            String type = "door house";
            DateTime date = DateTime.Now;
            int id = 16;
            int fee = 20;
            try
            {
                com = new SqlConnection(con);
                com.Open();
                string sss = $"INSERT INTO orders (customer_id) VALUES ('{id}')"; // save the valiues
                comm = new SqlCommand(sss, com);
                adap = new SqlDataAdapter();
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();
                com.Close();
            }

            catch
            {
                Console.WriteLine("Error processing Table to the gridview");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}