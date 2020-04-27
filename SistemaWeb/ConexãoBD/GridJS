<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DBGrid3.aspx.cs" Inherits="Albertinho09.DBGrid3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <script>
        
        
        function getConfirmacao() {
            
            var a = PageMethods.ConfirmaExclusao(onSucess, onError);

            function onSucess(result) {
                var teste = confirm(result);
                console.log(teste);
                if (teste)
                    PageMethods.DeletaRegistro(sucesso, falha);
            }

            function onError(result) {
                alert('Algo errado.');
            }

            function sucesso(result) {
                aler('Sucesso');
            }

            function falha(result) {
                alert('Algo errado.');
            }
        }
    </script> 
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 118px;
            left: 240px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 116px;
            left: 539px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 117px;
            left: 137px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 117px;
            left: 456px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 176px;
            left: 647px;
            z-index: 1;
            width: 87px;
            height: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Text="Data Inicial"></asp:Label>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style4" Text="Data Final"></asp:Label>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style5" onClick="Button1_Click"
         CommandName="Delete" OnClientClick="getConfirmacao()"  Text="Deletar" />
    </form>
  
</body>
</html>
