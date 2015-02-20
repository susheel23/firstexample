using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        con.Open();
        cmd = new SqlCommand("insert into Table_1 values('" + name + "')", con);
        int a = cmd.ExecuteNonQuery();
        if (a > 0)
        {

            Label1.Text = "Data inserted";
        }
        else
        {
            Label1.Text = "Data Faied";
        }
        con.Close();
    }
}