using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;

public partial class register : System.Web.UI.Page
{
    // connection to exist  MySQL database..
    MySqlConnection con = new MySqlConnection("Server=localhost;Database=sample1;Uid=root;Pwd=12345;");
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //it is used to generate a auto generated id number..
        int count;
        con.Open();
        MySqlCommand cmd = new MySqlCommand("select count(*) from patient_info", con);
        count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
        TextBox1.Text = count.ToString();
        con.Close();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        // this button is used to save the details to a database..
        con.Open();
        var sqldtfmt = System.DateTime.Now.ToString("yy/MM/dd hh:mm:ss");
        MySqlCommand cmd = new MySqlCommand("insert into patient_info(id,pname,cno,address,disease,remarks,username,fdt,status) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','admin','" + sqldtfmt.ToString() + "','a')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        // message box..
        Response.Write("<script>alert('Patient Information was Registered..')</script>");
    }
     
}