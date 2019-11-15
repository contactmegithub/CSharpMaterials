<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="DemoWebForms.Registration" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>New User Registration</h2>
   
<asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
<asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
<asp:Label ID="Label3" runat="server" Text="Email"></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
<asp:Label ID="Label4" runat="server" Text="Contact"></asp:Label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
<asp:Label ID="Label5" runat="server" Text="Address"></asp:Label><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
<asp:Label ID="Label6" runat="server" Text="State"></asp:Label><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
<asp:Label ID="Label7" runat="server" Text="Country"></asp:Label><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />     

<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
<asp:Button ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click" />

</asp:Content>

