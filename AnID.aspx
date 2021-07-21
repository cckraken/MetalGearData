<%@ Page Title="" Language="C#" MasterPageFile="~/OverviewMaster.master" AutoEventWireup="true" CodeFile="AnID.aspx.cs" Inherits="AnID" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   

    <p>
        &nbsp;</p>
    &nbsp;
   
    <p>
        <asp:Label ID="lblCodeName" runat="server" style="z-index: 1; left: 60px; top: 150px; position: absolute" Text="Code Name"></asp:Label>

        <asp:TextBox ID="txtCodeName" runat="server" style="z-index: 1; left: 180px; top: 150px; position: absolute"></asp:TextBox>
    </p>
    &nbsp;
   
    <p>
        <asp:Label ID="lblAbilityRank" runat="server" style="z-index: 1; left: 60px; top: 196px; position: absolute" Text="Ability Rank"></asp:Label>

        <asp:TextBox ID="txtAbilityRank" runat="server" style="z-index: 1; left: 180px; top: 196px; position: absolute"></asp:TextBox>
    </p>
    &nbsp;
   
    <p>
        <asp:Label ID="lblAssignedTo" runat="server" style="z-index: 1; left: 60px; top: 244px; position: absolute" Text="Assigned To"></asp:Label>

        <asp:DropDownList ID="ddlAssignedTo" runat="server" style="z-index: 1; left: 180px; top: 244px; position: absolute"> </asp:DropDownList>
    </p>
     &nbsp;
   
    <p>
        <asp:Label ID="lblAffiliation" runat="server" style="z-index: 1; left: 60px; top: 290px; position: absolute" Text="Affiliation"></asp:Label>

        <asp:TextBox ID="txtAffiliation" runat="server" style="z-index: 1; left: 180px; top: 290px; position: absolute"></asp:TextBox>
    </p>
     &nbsp;
   
    <p>
        <asp:Label ID="lblHairColour" runat="server" style="z-index: 1; left: 60px; top: 336px; position: absolute" Text="Hair Colour"></asp:Label>

        <asp:TextBox ID="txtHairColour" runat="server" style="z-index: 1; left: 180px; top: 336px; position: absolute"></asp:TextBox>
    </p>
    &nbsp;
   
    <p>
        <asp:Label ID="lblEthnicity" runat="server" style="z-index: 1; left: 60px; top: 382px; position: absolute" Text="Ethnicity"></asp:Label>

        <asp:TextBox ID="txtEthnicity" runat="server" style="z-index: 1; left: 180px; top: 382px; position: absolute"></asp:TextBox>
    </p>

    <p>

    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    &nbsp;
   
    <p>
        <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; left: 60px; top: 428px; position: absolute" Text="Date Joined"></asp:Label>

        <asp:TextBox ID="txtDateJoined" runat="server" style="z-index: 1; left: 180px; top: 428px; position: absolute"></asp:TextBox>
    </p>
    &nbsp;
   
    <p>
        <asp:Label ID="lblAtMotherBase" runat="server" style="z-index: 1; left: 60px; top: 474px; position: absolute" Text="At MotherBase"></asp:Label>

        <asp:TextBox ID="txtAtMotherBase" runat="server" style="z-index: 1; left: 180px; top: 465px; position: absolute"></asp:TextBox>

        <asp:Label ID="lblTF" runat="server" style="z-index: 1; left: 380px; top: 470px; position: absolute" Text="Enter 'True' or 'False'"></asp:Label>
    </p>

    <p>
         <asp:Label ID="lblYearsAtBase" runat="server" style="z-index: 1; left: 60px; top: 520px; position: absolute" Text ="YearsAtBase"></asp:Label>
        <asp:TextBox ID="txtYearsAtBase" runat="server" style="z-index: 1; left: 180px; top: 525px; position: absolute"></asp:TextBox>
    </p>
    &nbsp;
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 154px; top: 632px; position: absolute" Text=""></asp:Label>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnOK" runat="server" Text="OK" Width="58px" style="margin-left: 37px" OnClick="btnOK_Click" />
        &nbsp;<asp:Button ID="btnClose" runat="server" Text="Close" Width="62px" OnClick="btnClose_Click" style="margin-left: 19px" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
  
   



























</asp:Content>

