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
    public partial class ViewAppointment : System.Web.UI.Page
    {
        public String con = "Data Source=DESKTOP-ESHNQ89;Initial Catalog=Ma_B_Tailors;Integrated Security=True";
        public SqlConnection com;
        public SqlCommand comm;
        public SqlDataAdapter adap;
        public DataSet ds;
        SqlDataReader big;

        protected void Page_Load(object sender, EventArgs e)
        {
            int tailor_id = new foward().Tailors();


            com = new SqlConnection(con);
            com.Open();
            string sss = $"SELECT address_id, ADate FROM Appointment WHERE tailor_id='" + tailor_id + "'";
            ds = new DataSet();
            adap = new SqlDataAdapter();
            comm = new SqlCommand(sss, com);
            adap.SelectCommand = comm;
            adap.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();

            com.Close(); // c
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}