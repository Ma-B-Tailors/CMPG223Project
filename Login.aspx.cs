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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        String con = "Data Source=DESKTOP-ESHNQ89;Initial Catalog=Ma_B_Tailors;Integrated Security=True";
        SqlConnection com;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet set;
        SqlDataReader big;

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Value2"] = TextBox1.Text;

            try
            {
                com = new SqlConnection(con);
                com.Open();
                adap = new SqlDataAdapter();
                string sss = $"SELECT * FROM Tailor";
                comm = new SqlCommand(sss, com);
                big = comm.ExecuteReader();
                while (big.Read())
                {
                    if (big[1].ToString() == TextBox1.Text && big[4].ToString() == TextBox4.Text)
                    {
                        Response.Redirect("foward.aspx");
                    }
                    else
                    {
                        Label5.Text = "incorrect username or password";
                    }


                }

                com.Close();
            }


            catch
            {
                Console.WriteLine("Error occured while checking the existance of the user");
            }

           


        }
       

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["Value1"] = TextBox1.Text;

            try
            {
                com = new SqlConnection(con);
                com.Open();
                adap = new SqlDataAdapter();
                string sss = $"SELECT * FROM customer";
                comm = new SqlCommand(sss, com);
                big = comm.ExecuteReader();
                while (big.Read())
                {
                    if (big[1].ToString() == TextBox1.Text && big[4].ToString() == TextBox4.Text)
                    {
                        Response.Redirect("landing.html");
                    }
                    else
                    {
                        Label5.Text = "incorrect username or password";
                    }


                }

                com.Close();
            }


            catch
            {
                Console.WriteLine("Error occured while checking the existance of the user");
            }
        }

        
    }
}