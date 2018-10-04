<%@ Page Title="" Language="C#" MasterPageFile="~/MassterPage/ProyectoAFEYAC.Master" AutoEventWireup="true" CodeBehind="Miembros.aspx.cs" Inherits="AFEYAC.GUI.Miembros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphTitulo" runat="server">

    <strong>Descargar credencial</strong>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContenido" runat="server">
    <asp:Panel ID="Panel1" runat="server" Enabled="False">

        <center><embed width="600" height="400" src="../Recursos/img/Credencial.pdf" />
            <br />
            <br />
            <br />
        </center>


    </asp:Panel>
</asp:Content>
