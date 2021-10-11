using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; // extention to access the connection variables
using System.Data;

namespace WebApplication4
{
    public partial class payment : System.Web.UI.Page
    {
        public String con = "Data Source=DESKTOP-ESHNQ89;Initial Catalog=Ma_B_Tailors;Integrated Security=True"; // values to declare connection always
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
        }

        public int Product_id() // get the product id from thee uniform cart in order to be able to save it in the order table 
                                //note this method will be used when the orderDetail page loads
        {
            int customer_id = new Appointment().Customer();
            int product = 0;

            com = new SqlConnection(con);
            com.Open();
            adap = new SqlDataAdapter();
            string sss = $"SELECT * FROM uniform_cart WHERE customer_id='" + customer_id + "'"; //this code is for getting the product id in the uniform cart and returning it to be used else
            comm = new SqlCommand(sss, com);
            big = comm.ExecuteReader();
            while (big.Read())
            {
                product = int.Parse(big.GetValue(1).ToString()); //loop through the values in the uniform_cart cart and save it

            }

            return product; // int value of product id in uniform cart

        }

        public float Productprice() // get the product price from thee product table in order to be able to save it in the order- detail table 
                                    //note this method will be used when the orderDetail page loads
        {
            int customer_id = new Appointment().Customer();
            int product_id = Product_id();
            float productprice = 0F;

            com = new SqlConnection(con);
            com.Open();
            adap = new SqlDataAdapter();
            string sss = $"SELECT * FROM product WHERE product_id='" + product_id + "'"; //this code is for getting the product id in the uniform cart and returning it to be used else
            comm = new SqlCommand(sss, com);
            big = comm.ExecuteReader();
            while (big.Read())
            {
                productprice = float.Parse(big.GetValue(0).ToString()); //loop through the values in the uniform_cart cart and save it

            }

            return productprice; // return the price of the choosen product

        }

        public int Delivery() // gets the delivery id from the delivery table and returns it to be used else
        {
            int customer_id = new Appointment().Customer();
            int delivery = 0;

            com = new SqlConnection(con);
            com.Open();
            adap = new SqlDataAdapter();
            string sss = $"SELECT * FROM delivery WHERE customer_id='" + customer_id + "'"; //this code is for getting the product id in the uniform cart and returning it to be used else
            comm = new SqlCommand(sss, com);
            big = comm.ExecuteReader();
            while (big.Read())
            {
                delivery = int.Parse(big.GetValue(0).ToString()); //loop through the values in the uniform_cart cart and save it

            }
            return delivery;
        }
        public int Tailors2()
        {
            int customer_id = new Appointment().Customer();

            // Store the tailor's primary key from tailor table in a separate re-usable method called Tailor
            int Tailor = 0;

            com = new SqlConnection(con);  //start a new connection
            com.Open();
            adap = new SqlDataAdapter();
            string sss = $"SELECT * FROM Size WHERE customer_id='" + customer_id + "'";
            comm = new SqlCommand(sss, com);
            big = comm.ExecuteReader();
            while (big.Read())
            {
                Tailor = int.Parse(big.GetValue(8).ToString());

            }


            return Tailor; //value retured

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int customer_id = new Appointment().Customer();
                com = new SqlConnection(con);
                com.Open();
                string sss = $"INSERT INTO payment(email, customer_id) VALUES('{TextBox1.Text}', '{customer_id}')";
                comm = new SqlCommand(sss, com);
                ds = new DataSet();
                adap = new SqlDataAdapter();
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();
                com.Close();

                Response.Redirect("orderDetail.aspx"); // take the user to the page where they will be able to view their order
            }

            catch
            {
                Console.WriteLine("Error processing Table to the gridview");
            }
           
        }
        
   


    }
}