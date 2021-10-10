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
    public partial class Size : System.Web.UI.Page
    {
        String con = "Data Source=DESKTOP-ESHNQ89;Initial Catalog=Ma_B_Tailors;Integrated Security=True";
        SqlConnection com;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet set;
        SqlDataReader big;
        public DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Value1"] == null)
                {
                    Response.Redirect("Login.aspx");

                }
                else
                {
                    com = new SqlConnection(con);
                    com.Open();
                    string sss = $"SELECT first_name, tailor_id FROM Tailor ";
                    ds = new DataSet();
                    adap = new SqlDataAdapter();
                    comm = new SqlCommand(sss, com);
                    adap.SelectCommand = comm;
                    adap.Fill(ds);

                    DropDownList1.DataTextField = "first_name";

                    DropDownList1.DataSource = ds;
                    DropDownList1.DataBind();
                    com.Close();
                }

            }

            catch
            {
                Console.WriteLine("Error processing Table to the gridview");
            }


        }
       

        public int Tailors()
        {

            // populate the drop down lists, and anything else for loading the page.

            String name_of_Tailor = DropDownList1.Text;
            int Tailor = 0;

            com = new SqlConnection(con);
            com.Open();
            adap = new SqlDataAdapter();
            string sss = $"SELECT * FROM Tailor WHERE first_name='" + name_of_Tailor + "'";
            comm = new SqlCommand(sss, com);
            big = comm.ExecuteReader();
            while (big.Read())
            {
                Tailor = int.Parse(big.GetValue(0).ToString());

            }


            return Tailor;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                com = new SqlConnection(con);
                com.Open();
                string sss = $"INSERT INTO product (descr) VALUES ('{TextBox4.Text}')";
                comm = new SqlCommand(sss, com);
                adap = new SqlDataAdapter();
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();
                com.Close();

                Response.Redirect("Login.aspx");


            }

            catch
            {
                Console.WriteLine("Error processing Table to the gridview");
            }
        }

       
    }

    
}
