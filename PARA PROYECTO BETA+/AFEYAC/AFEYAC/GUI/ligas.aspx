<%@ Page Title="" Language="C#" MasterPageFile="~/MassterPage/ProyectoAFEYAC.Master" AutoEventWireup="true" CodeBehind="ligas.aspx.cs" Inherits="AFEYAC.GUI.ligas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphTitulo" runat="server">
    <strong>Nuestras ligas de Fútbol</strong>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContenido" runat="server">



    <asp:GridView ID="GridView1" runat="server" class="table table-bordered"></asp:GridView>



</asp:Content>
