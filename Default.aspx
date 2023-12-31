<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>details page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #FFFFCC">
       
        
             <center>
                 <h1>&nbsp;</h1>
                 <h1 style="font-family: elephant; background-color: #FFCC99">PATIENT INFORMATION</h1>
             </center>
        
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <center>
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="ID" 
                AutoGenerateColumns="False" onrowcancelingedit="GridView1_RowCancelingEdit1" 
                onrowdeleting="GridView1_RowDeleting1" onrowediting="GridView1_RowEditing1" 
                onrowupdating="GridView1_RowUpdating1" 
                onselectedindexchanged="GridView1_SelectedIndexChanged1" >
            <Columns>
                <asp:BoundField HeaderText="ID" SortExpression="ID" ReadOnly="True" 
                    DataField="id" />
                <asp:TemplateField HeaderText="Patient Name">
                <EditItemTemplate>
        <asp:TextBox ID="pname" runat="server" Text='<%# Bind("pname") %>'></asp:TextBox>
                </EditItemTemplate>
    <ItemTemplate>
        <asp:Label ID="lblName" runat="server" Text='<%# Bind("pname") %>'></asp:Label>
    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Contact No">
                <EditItemTemplate>
        <asp:TextBox ID="cno" runat="server" Text='<%# Bind("cno") %>'></asp:TextBox>
                </EditItemTemplate>
    <ItemTemplate>
        <asp:Label ID="lblName2" runat="server" Text='<%# Bind("cno") %>'></asp:Label>
    </ItemTemplate></asp:TemplateField>
                <asp:TemplateField HeaderText="Address">
                <EditItemTemplate>
        <asp:TextBox ID="address" runat="server" Text='<%# Bind("address") %>'></asp:TextBox>
                </EditItemTemplate>
    <ItemTemplate>
        <asp:Label ID="lblName3" runat="server" Text='<%# Bind("address") %>'></asp:Label>
    </ItemTemplate>
        </asp:TemplateField>
                <asp:BoundField DataField="disease" HeaderText="Disease" />
                <asp:BoundField DataField="remarks" HeaderText="Remarks" />
                <asp:CommandField HeaderText="Modify" ShowDeleteButton="True" 
                    ShowEditButton="True" />
            </Columns>
               
        </asp:GridView>
        </center>
    
    </div>
    </form>
</body>
</html>
