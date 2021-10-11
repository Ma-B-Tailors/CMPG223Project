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
    public partial class foward : System.Web.UI.Page
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
        public int Tailors()
        {



            String name_of_Tailor = Session["Value2"].ToString();
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
            Response.Redirect("ViewAppointment.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAppointment2.aspx");
        }
    }
}