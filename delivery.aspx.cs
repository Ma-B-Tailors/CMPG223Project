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
    public partial class delivery : System.Web.UI.Page
    {
        public String con = "Data Source=DESKTOP-ESHNQ89;Initial Catalog=Ma_B_Tailors;Integrated Security=True";
        public SqlConnection com;
        public SqlCommand comm;
        public SqlDataAdapter adap;
        public DataSet ds;
        SqlDataReader big;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Value1"] == null)
            {
                Response.Redirect("Login.aspx");

            }
            else {
                try
                {
                    com = new SqlConnection(con);
                    com.Open();
                    adap = new SqlDataAdapter();
                    string sss = $"SELECT * FROM address";
                    comm = new SqlCommand(sss, com);
                    big = comm.ExecuteReader();
                    while (big.Read())
                    {
                        Label1.Text = big.GetValue(1).ToString() + ", " + big.GetValue(2).ToString() + ", " + big.GetValue(3).ToString();

                    }
                }
                catch
                {
                    Console.WriteLine("Error processing Table to the gridview");
                }
            }
           
        }

        public int Address2() // get the address_id from address table 
        {
           
            
            int address = 0;
            int customer_id = new Appointment().Customer(); //call the customer method to use as a condition
            com = new SqlConnection(con);
            com.Open();
            adap = new SqlDataAdapter();
            string sss = $"SELECT * FROM address WHERE customer_id='" + customer_id + "'";
            comm = new SqlCommand(sss, com);
            big = comm.ExecuteReader();
            while (big.Read())
            {
                address = int.Parse(big.GetValue(0).ToString());

            }

            return address;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            int customer_id = new Appointment().Customer(); //when the user clickes the confirm buttom then this method is envoked
            int address_id = Address2(); // call the needed methods
            String type = "door house";
            int fee = 20;
            try
            {
                com = new SqlConnection(con);
                com.Open();
                string sss = $"INSERT INTO delivery (deliveryType, delivery_fee, address_id, customer_id) VALUES ('{type}', '{fee}', '{address_id}', '{customer_id}')"; // save the valiues
                comm = new SqlCommand(sss, com);
                adap = new SqlDataAdapter();
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();
                com.Close();

                Label2.Text = "Address successfully confirmed, you may proceed";
            }

            catch
            {
                Console.WriteLine("Error processing Table to the gridview");
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("delete.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            Session["Value4"] = "50";

            int customer_id = new Appointment().Customer();
            int address_id = new Appointment().Address();
            string type = "pickup";
            int fee = 1;
            try
            {
                com = new SqlConnection(con);
                com.Open();
                string sss = $"INSERT INTO delivery (deliveryType, delivery_fee, address_id, customer_id) VALUES ('{type}', '{fee}', '{address_id}', '{customer_id}')"; // save the valiues
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

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("payment.aspx");

        }
    }
}