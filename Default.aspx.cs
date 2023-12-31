using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;

public partial class _Default : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection("Server=localhost;Database=sample1;Uid=root;Pwd=12345;");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Bind data to the GridView
            dataload(); 
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    
    private void UpdateDataInDatabase(int id, string pname, string cno,string address)
    {
        //this function is used to update the edited information to a connected database...
        con.Open();
        MySqlCommand cmd = new MySqlCommand("UPDATE patient_info SET pname = '" + pname + "',cno = '" + cno + "',address = '" + address + "' WHERE id = '" + id + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("<script>alert('Patient Information was modified Successfully..')</script>");
    }
   
   
    public void dataload()
    {
        // this function is used to show the information from the connected database using the session variable it was declared in a dview form...
        string id = Session["det"].ToString();
        string qu = "select id,pname,cno,address,disease,remarks from patient_info where id='" + id + "' && status='a' ";
        con.Open();
        MySqlDataAdapter da = new MySqlDataAdapter(qu, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
        con.Close();
    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
    {
        // this function property of grid view is used to update the patient name, contact number, address using id as a datakey...
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["ID"]);
        string pname = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("pname")).Text;
        string cno = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("cno")).Text;
        string address = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("address")).Text;
        UpdateDataInDatabase(id, pname, cno,address);
        GridView1.EditIndex = -1;
        dataload();
    }
    protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
    {
        // this is used to edit the index of grid view
        GridView1.EditIndex = e.NewEditIndex;
        dataload();
    }
    protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
    {
        // it is used to canceling a edit ...
        GridView1.EditIndex = -1;
        dataload();
    }
    protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
    {
        //it is a property used to delete the data by an 'ID' as a datakey...
        string id = GridView1.DataKeys[e.RowIndex].Values["ID"].ToString();
        DeleteDataInDatabase(Convert.ToInt32(id));
        dataload();
    }
    private void DeleteDataInDatabase(int id)
    {
        // this funtion is used to delete or update the information 'alive' into 'dead' information to the database..
        con.Open();
        MySqlCommand cmd = new MySqlCommand("UPDATE patient_info SET status='d' WHERE id = '" + id + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();
        //messeage box..
        Response.Write("<script>alert('Patient Information was Deleted..')</script>");
        
    }
}