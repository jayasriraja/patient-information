using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;

public partial class dview : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection("Server=localhost;Database=sample1;Uid=root;Pwd=12345;");
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    // this form is a search page of a information..
    protected void Button1_Click1(object sender, EventArgs e)
    {
        //it shows the information by searching the name from a database...
        // bind the data to the gridview..
        con.Open();
        MySqlDataAdapter cmd = new MySqlDataAdapter("select id,pname,cno from patient_info where pname like '" + TextBox1.Text + "%' && status='a';", con);
        DataSet dd = new DataSet();
        cmd.Fill(dd);
        GridView1.DataSource = dd.Tables[0];
        GridView1.DataBind();
        con.Close();

    }
  
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        //it is a session variable to store the id of a particular information for search & edit purpose....
        Session["det"] = GridView1.SelectedRow.Cells[0].Text;
        Response.Redirect("Default.aspx");
    }
}