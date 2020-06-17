<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication13.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 479px;
        height: 308px;
        position: absolute;
        top: 288px;
        left: 220px;
        z-index: 1;
    }
    .auto-style3 {
        position: absolute;
        top: 211px;
        top: 211px;
        left: 674px;
        z-index: 1;
    }
    .auto-style4 {
        width: 160px;
        height: 158px;
        position: absolute;
        top: 381px;
        left: 710px;
        z-index: 1;
    }
        .auto-style5 {
            position: absolute;
            top: 230px;
            left: 473px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 646px;
            left: 522px;
            z-index: 1;
            height: 27px;
            width: 182px;
            right: 475px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional"
            ViewStateMode="Enabled">
   <ContentTemplate>
        <asp:Label ID="registros" runat="server" CssClass="auto-style6"></asp:Label>
    </ContentTemplate>
    <Triggers>
      <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
   </Triggers>
</asp:UpdatePanel>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style5" AutoPostBack="True"  OnTextChanged="TextBox1_TextChanged" Visible="False"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" CssClass="auto-style3" OnClick="Button1_Click" Text="Listar Vôos" />
    <asp:GridView ID="GridView1" runat="server" CssClass="auto-style1">
</asp:GridView>
<asp:GridView ID="GridView2" runat="server" CssClass="auto-style4">
</asp:GridView>
    <asp:Timer ID="Timer1" runat="server" Interval="5000" OnTick="Timer1_Tick">
    </asp:Timer>
</asp:Content>
