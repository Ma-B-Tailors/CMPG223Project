using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; //declare cextension 
using System.Data;

namespace WebApplication4
{
    public partial class orderDetail : System.Web.UI.Page
    {
        public String con = "Data Source=DESKTOP-ESHNQ89;Initial Catalog=Ma_B_Tailors;Integrated Security=True"; // values to declare connection always
        public SqlConnection com;
        public SqlCommand comm;
        public SqlDataAdapter adap;
        public DataSet ds;
        SqlDataReader big;

      
        protected void Page_Load(object sender, EventArgs e)
        {
            int tailor_id = new payment().Tailors2();
            int delivery_id = new payment().Delivery(); // Save the oder details values in the order detail table in our database but first we need to call our method from the above and other pages in order to make our code simple. we are re-using them
            int customer_id = new Appointment().Customer();
            int product_id = new payment().Product_id();
            DateTime date = DateTime.Now;   
             //<<<<<<<<<<< the date of which the order was saved in our database
             
            try
            {
                com = new SqlConnection(con);
                com.Open();
                string sss = $"INSERT INTO orders (customer_id, tailor_id, delivery_id, Adate, product_id) VALUES ('{customer_id}', '{tailor_id}', '{delivery_id}','{date}', '{product_id}')"; // save the valiues
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

        public int Order_id()
        {
            int customer_id = new Appointment().Customer();
            int order_id = 0;

            com = new SqlConnection(con);
            com.Open();
            adap = new SqlDataAdapter();
            string sss = $"SELECT * FROM orders WHERE customer_id='" + customer_id + "'"; //this code is for getting the product id in the uniform cart and returning it to be used else
            comm = new SqlCommand(sss, com);
            big = comm.ExecuteReader();
            while (big.Read())
            {
                order_id = int.Parse(big.GetValue(0).ToString()); //loop through the values in the uniform_cart cart and save it

            }
            return order_id;

        }

        public void orderDetails()
        {
           
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            int product_id = new payment().Product_id(); // Save the oder details values in the order detail table in our database but first we need to call our method from the above and other pages in order to make our code simple. we are re-using them
            int order_id = Order_id();
            int delivery_id = new payment().Delivery();
            float productprice = new payment().Productprice();
            DateTime date = DateTime.Now;                                   //<<<<<<<<<<< the date of which the order was saved in our database
            //int cellNo = int.Parse(TextBox3.Text);
            try
            {
                com = new SqlConnection(con);
                com.Open();
                string sss = $"INSERT INTO Details (product_id, ItermCost, delivery_id, order_id) VALUES ('{product_id}', '{productprice}', '{delivery_id}', '{order_id}')"; // save the valiues
                comm = new SqlCommand(sss, com);
                adap = new SqlDataAdapter();
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();
                com.Close();

                Response.Redirect("landing.html");

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