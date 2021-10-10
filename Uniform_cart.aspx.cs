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

    //Hint never forget to close the connection when the Database is done.


    public partial class Uniform_cart : System.Web.UI.Page
    {
        public String con = "Data Source=DESKTOP-ESHNQ89;Initial Catalog=Ma_B_Tailors;Integrated Security=True";
        public SqlConnection com;
        public SqlCommand comm;
        public SqlDataAdapter adap;
        public DataSet ds;
        SqlDataReader big;

        public int Product()
        {
            int customer_id = new Appointment().Customer();
            int product_id = 0;

            if (Session["Value1"] == null)
            {
                Response.Redirect("Login.aspx");

            }
            else
            {
             
                com = new SqlConnection(con);
                com.Open();
                adap = new SqlDataAdapter();
                string sss = $"SELECT * FROM uniform_cart WHERE customer_id='" + customer_id + "'";
                comm = new SqlCommand(sss, com);
                big = comm.ExecuteReader();
                while (big.Read())
                {
                    product_id = int.Parse(big.GetValue(1).ToString());

                }
            }


            return product_id;


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //populate the grid view with the iterms/product that the user has selected 

            int product_id = Product();

            if (Session["Value1"] == null)
            {
                Response.Redirect("Login.aspx");

            }
            else
            {

                if (!Page.IsPostBack)
                {
                    com = new SqlConnection(con);
                    com.Open();
                    string sss = $"SELECT product_name, price FROM product WHERE product_id='" + product_id + "'";
                    ds = new DataSet();
                    adap = new SqlDataAdapter();
                    comm = new SqlCommand(sss, com);
                    adap.SelectCommand = comm;
                    adap.Fill(ds);

                    GridView1.DataSource = ds;
                    GridView1.DataBind();

                    com.Close(); // close the connection

                }

            }
        }

      
       
        protected void Button2_Click(object sender, EventArgs e)
        {
            int product_id = Product();
            com = new SqlConnection(con);
            com.Open();
            string delete_query = "DELETE FROM uniform_cart WHERE product_id ='" + product_id + "'";
            SqlCommand cmd = new SqlCommand(delete_query, com);
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.DeleteCommand = cmd;
            adap.DeleteCommand.ExecuteNonQuery();

            com.Close();

            Session["Value1"] = "ha";
            Response.Redirect("productIterms.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("delivery.aspx");
        }
    }
}