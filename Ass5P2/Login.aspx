<%@ Page Title="" Language="C#" MasterPageFile="~/Mass.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ass5P2.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login</h1>
    <table>
        <tr>
            <td>User Name</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>Password</td>
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
