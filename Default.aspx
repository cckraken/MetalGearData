<%@ Page Title="" Language="C#" MasterPageFile="~/OverviewMaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblUserInfo" runat="server"></asp:Label>
    <p>
</p>
<p>
    <asp:ListBox ID="lstRecords" runat="server" Height="207px" Width="355px" OnSelectedIndexChanged="lstDetails_SelectedIndexChanged"></asp:ListBox>
</p>
<p>
    <asp:Label ID="lblError" runat="server"></asp:Label>
</p>
<p>
    Please enter an Ability Rank (AA, SS+, etc)</p>
<p>
    <asp:TextBox ID="txtAbilityRank" runat="server" Width="180px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnApply" runat="server" Text="Apply " Width="137px" OnClick="btnApply_Click" />
    <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" Width="140px" OnClick="btnDisplayAll_Click" />
</p>
<p>
    <asp:Button ID="btnAdd" runat="server" Text="Add" Width="65px" OnClick="btnAdd_Click" />
    <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="66px" OnClick="btnEdit_Click" />
    <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="61px" OnClick="btnDelete_Click" />
</p>
</asp:Content>

