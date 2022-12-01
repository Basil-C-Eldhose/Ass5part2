<%@ Page Title="" Language="C#" MasterPageFile="~/Mass.Master" AutoEventWireup="true" CodeBehind="UserR.aspx.cs" Inherits="Ass5P2.UserR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>UserRegistartion</h1>
    <table>
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="* Required"></asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td>Age</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>Phone</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>User Name</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
