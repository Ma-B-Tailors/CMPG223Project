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
    public partial class product : System.Web.UI.Page
    {
        public String con = "Data Source=DESKTOP-ESHNQ89;Initial Catalog=Ma_B_Tailors;Integrated Security=True";
        public SqlConnection com;
        public SqlCommand comm;
        public SqlDataAdapter adap;
        public DataSet ds;
        SqlDataReader big;

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
                    if (!Page.IsPostBack)
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

            }

            catch
            {
                Console.WriteLine("Error processing Table to the gridview");
            }

        }
        public int Tailors()
        {

            // Store the tailor's primary key from tailor table in a separate re-usable method called Tailor

            String name_of_Tailor = DropDownList1.Text;
            int Tailor = 0;

            com = new SqlConnection(con);  //start a new connection
            com.Open();
            adap = new SqlDataAdapter();
            string sss = $"SELECT * FROM Tailor WHERE first_name='" + name_of_Tailor + "'";
            comm = new SqlCommand(sss, com);
            big = comm.ExecuteReader();
            while (big.Read())
            {
                Tailor = int.Parse(big.GetValue(0).ToString());

            }


            return Tailor; //value retured

        }

       
        protected void Button1_Click(object sender, EventArgs e)
        {
            int tailor_id = Tailors();
            int customer_id = new Appointment().Customer();
            try
            {
                com = new SqlConnection(con);
                com.Open();
                string sss = $"INSERT INTO Size (neck, chest, shoulder_width, arm_length, waist, insean, customer_id, tailor_id) VALUES ('{float.Parse(TextBox1.Text)}', '{float.Parse(TextBox2.Text)}', '{float.Parse(TextBox3.Text)}', '{float.Parse(TextBox4.Text)}', '{float.Parse(TextBox5.Text)}', '{float.Parse(TextBox6.Text)}', '{customer_id}', '{tailor_id}')";
                comm = new SqlCommand(sss, com);
                adap = new SqlDataAdapter();
                adap.InsertCommand = comm;
                adap.InsertCommand.ExecuteNonQuery();
                com.Close();

                Response.Redirect("productIterms.aspx");


            }

            catch
            {
                Console.WriteLine("Error processing Table to the gridview");
            }
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}