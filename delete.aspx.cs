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
    public partial class delete : System.Web.UI.Page
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int houseNumber = int.Parse(TextBox7.Text);           
                int customer_id = new Appointment().Customer();
                com = new SqlConnection(con);
                com.Open();
                string sss = $"UPDATE  address SET steet='" + TextBox5.Text + "', city='" + TextBox6.Text+ "', house_number='" + TextBox7.Text + "' WHERE customer_id='" + customer_id+ "'";
                comm = new SqlCommand(sss, com);
                ds = new DataSet();
                adap = new SqlDataAdapter();
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();
                com.Close();

                Response.Redirect("delivery.aspx");

            }

            catch
            {
                Console.WriteLine("Error processing Table to the gridview");
            }
        }
    }
}