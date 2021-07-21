<%@ Page Title="" Language="C#" MasterPageFile="~/OverviewMaster.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="txtIDNo" runat="server" Width="154px"></asp:TextBox>
    <br />
    <asp:Label ID="lblIDNo" runat="server" Text="Are you sure you want to delete this record? "></asp:Label>
    <br />
<asp:Button ID="btnYes" runat="server" Text="Yes" Width="70px" OnClick="btnYes_Click" />
<asp:Button ID="btnNo" runat="server" Text="No" Width="69px" OnClick="btnNo_Click" />
</asp:Content>

