<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClienteWebCS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div>
        <asp:Label ID="label3" runat="server" Text="Operaciones brindadas en el WEB SERVICE"></asp:Label>
    </div>
    <br />
    <div>
        <asp:Label ID="label4" runat="server" Text="Operaciones que requieran de un solo numero usarna el Primer Numero"></asp:Label>
    </div>
    <br />
    <div>
        <asp:Label ID="label_nro1" runat="server" Text="Primer Numero"></asp:Label>
        <asp:TextBox ID="tb_nro1" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="label_nro2" runat="server" Text="Segundo Numero"></asp:Label>
        <asp:TextBox ID="tb_nro2" runat="server"></asp:TextBox>
    </div>
    <br />

    <asp:Button ID="btn_sumar" runat="server" Text="Sumar" OnClick="btn_sumar_Click" />
    <asp:Button ID="btn_restar" runat="server" Text="Restar" OnClick="btn_restar_Click" />
    <asp:Button ID="btn_multiplicar" runat="server" Text="Multiplicar" OnClick="btn_multiplicar_Click" />
    <asp:Button ID="btn_dividir" runat="server" Text="Dividir" OnClick="btn_dividir_Click" />
    <asp:Button ID="btn_potencia" runat="server" Text="Potencia" OnClick="btn_potencia_Click" />
    <asp:Button ID="btn_radicacion" runat="server" Text="Raiz" OnClick="btn_radicacion_Click" />
    <asp:Button ID="btn_factorial" runat="server" Text="Factorial" OnClick="btn_factorial_Click" />
    <asp:Button ID="btn_seno" runat="server" Text="Seno" OnClick="btn_seno_Click" />
    <asp:Button ID="btn_coseno" runat="server" Text="Coseno" OnClick="btn_coseno_Click" />
    <asp:Button ID="btn_porcentaje" runat="server" Text="Porcentaje" OnClick="btn_porcentaje_Click" />
    <br />
    <div>
        <br />
        <asp:Label ID="label_resultado" runat="server" Text="Resultado: "></asp:Label>
        <asp:TextBox ID="tb_resultado" runat="server"></asp:TextBox>
    </div>
    <br />
</asp:Content>
