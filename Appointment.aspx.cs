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
    public partial class Appointment : System.Web.UI.Page
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
        public void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String name_of_Tailor = DropDownList1.SelectedValue.ToString();
            Label3.Text = name_of_Tailor;
        }
        public int Tailors()
        {

            

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

        public int Customer() // get the customer_id when the user log in 
        {

            // String name_of_customer = Session["Value1"].ToString();
            int customer = 0;
            if (Session["Value1"].ToString() != null || Session["Value1"].ToString() != "")
            {
                com = new SqlConnection(con);
                com.Open();
                adap = new SqlDataAdapter();
                string sss = $"SELECT * FROM customer WHERE first_name='" + Session["Value1"].ToString() + "'";
                comm = new SqlCommand(sss, com);
                big = comm.ExecuteReader();
                while (big.Read())
                {
                    customer = int.Parse(big.GetValue(0).ToString());

                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }


            return customer;

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int houseNumber = int.Parse(TextBox7.Text);
                int tailor_id = Tailors();
                int customer_id = Customer();
                com = new SqlConnection(con);
                com.Open();
                string sss = $"INSERT INTO address(steet, city, house_number, customer_id) VALUES('{TextBox5.Text}', '{TextBox6.Text}', '{houseNumber}', '{customer_id}')";
                comm = new SqlCommand(sss, com);
                ds = new DataSet();
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

        public int Address()
        {
            int houseNumber = int.Parse(TextBox7.Text);
            String name_of_customer = Session["Value1"].ToString();
            int address = 0;
            int customer_id = Customer();
            com = new SqlConnection(con);
            com.Open();
            adap = new SqlDataAdapter();
            string sss = $"SELECT * FROM address WHERE customer_id='" + customer_id + "'";
            comm = new SqlCommand(sss, com);
            big = comm.ExecuteReader();
            while (big.Read())
            {
                address = int.Parse(big.GetValue(0).ToString());

            }

            return address;

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioButton1.Checked)
                {
                    int tailor_id = Tailors();
                    int customer_id = Customer();
                    int address_id = Address();
                    com = new SqlConnection(con);
                    com.Open();
                    string sss = $"INSERT INTO Appointment (ADate, tailor_id, customer_id, address_id) VALUES ('{TextBox1.Text}', '{tailor_id}', '{customer_id}','{address_id}')";
                    comm = new SqlCommand(sss, com);
                    ds = new DataSet();
                    adap = new SqlDataAdapter();
                    adap.InsertCommand = comm;
                    adap.InsertCommand.ExecuteNonQuery();
                    com.Close();

                    Response.Redirect("productIterms.aspx");
                }
                else
                {
                    Label3.Text = "please confirm your address above!!";
                }
            }

            catch
            {
                Console.WriteLine("Error processing Table to the gridview");
            }
        }

       

        // int some = new Appointment().Customer();
    }
}