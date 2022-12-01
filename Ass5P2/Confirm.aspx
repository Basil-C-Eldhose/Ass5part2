<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="Ass5P2.Confirm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome Admin</h1>
            <br />
            <h3>Confirm Registation</h3>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="lid" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="uname" HeaderText="User Name" />
                    <asp:BoundField DataField="pass" HeaderText="Password" />
                    <asp:BoundField DataField="state" HeaderText="Status" />
                    <asp:CommandField DeleteText="Confirm" HeaderText="Change Status" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
            <br />
            <h3>Confirmed Users</h3>
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="uname" HeaderText="User Name" />
                    <asp:BoundField DataField="pass" HeaderText="Password" />
                    <asp:BoundField DataField="state" HeaderText="Status" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
