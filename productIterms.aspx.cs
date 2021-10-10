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
    public partial class productIterms : System.Web.UI.Page
    {

        public String con = "Data Source=DESKTOP-ESHNQ89;Initial Catalog=Ma_B_Tailors;Integrated Security=True";
        public SqlConnection com;
        public SqlCommand comm;
        public SqlDataAdapter adap;
        public DataSet ds;
        SqlDataReader big;

        protected void Page_Load(object sender, EventArgs e)
        {
            // if the user is not loged in then they will be taken back to the log in page
            if (Session["Value1"] == null)
            {
                Response.Redirect("Login.aspx");

            }

        }

      

        public String Product()
        {
            // Store the names of the products that the customer has selected and re-use them else-where
            String product = "";
            if (RadioButton1.Checked)
            {
                product = "School Trousers";
            }
            if (RadioButton2.Checked)
            {
                product = "long sleeve t shirts";
            }
            if (RadioButton3.Checked)
            {
                product = "School skirts";
            }
            if (RadioButton4.Checked)
            {
                product = "School blazer";
            }
            if (RadioButton5.Checked)
            {
                product = "short sleeve t shirts";
            }

            return product;
        }

        public int Products()
        {

          //Select the product_id of the user-product which has been stored and return it to be used else in the code

            int product = 0;

            String productName = Product();  //re-use the method created called product to compare the product_name to that which the user has selected

            com = new SqlConnection(con);
            com.Open();
            adap = new SqlDataAdapter();
            string sss = $"SELECT * FROM product WHERE product_name='" + productName + "'";
            comm = new SqlCommand(sss, com);
            big = comm.ExecuteReader();
            while (big.Read())
            {
                product = int.Parse(big.GetValue(0).ToString());

            }

            com.Close(); //close the connection
            return product; // product_id which is an int has been returned

        }



        public int Size()
        {
            //Select the product_id of the user-product which has been stored and return it to be used else in the code

            int size = 0;
            int customer_id = new Appointment().Customer();

            String productName = Product();  //re-use the method created called product to compare the product_name to that which the user has selected

            com = new SqlConnection(con);
            com.Open();
            adap = new SqlDataAdapter();
            string sss = $"SELECT * FROM Size WHERE customer_id='" + customer_id + "'";
            comm = new SqlCommand(sss, com);
            big = comm.ExecuteReader();
            while (big.Read())
            {
                size = int.Parse(big.GetValue(0).ToString());

            }

            com.Close(); //close the connection
            return size; // 
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
           //Save all the details which the customer has selected in the uniform_cart that the user can update or confirm
            int product_id = Products();   // call of the methods which will be used for the condition in our connection string. 
            int customer_id = new Appointment().Customer();
            int size = Size();
            String descr = "Happy";
            DateTime date = DateTime.Now;

            try
            {
                com = new SqlConnection(con);
                com.Open();
                string sss = $"INSERT INTO uniform_cart (product_id, size_id, ADate, customer_id) VALUES ('{product_id}', '{size}', '{date}', '{customer_id}')";
                comm = new SqlCommand(sss, com);
                adap = new SqlDataAdapter();
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();
                com.Close();

                Response.Redirect("Uniform_cart.aspx");


            }

            catch
            {
                Console.WriteLine("Error processing Table to the gridview");
            }

        }




       
    }
}