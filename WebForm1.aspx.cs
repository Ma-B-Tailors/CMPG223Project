﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
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
            int cellNo = int.Parse(TextBox3.Text);
            try
            {
                com = new SqlConnection(con);
                com.Open();
                string sss = $"INSERT INTO customer (first_name, last_name, cellNo, password) VALUES ('{TextBox1.Text}', '{TextBox2.Text}', '{cellNo}', '{TextBox4.Text}')";
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