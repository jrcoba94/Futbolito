<%@ Page Title="" Language="C#" MasterPageFile="~/MassterPage/ProyectoAFEYAC.Master" AutoEventWireup="true" CodeBehind="Jugadores.aspx.cs" Inherits="AFEYAC.GUI.Jugadores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphTitulo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContenido" runat="server">

    <asp:GridView ID="GridView1" runat="server" class="table table-bordered" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="ApellidoPaterno" HeaderText="Apellido Paterno" />
            <asp:BoundField DataField="ApellidoMaterno" HeaderText="Apellido Materno" />
            <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" />
            <asp:BoundField DataField="Edad" HeaderText="Edad" />
            <asp:BoundField DataField="Escolaridad" HeaderText="Escolaridad" />
            <asp:BoundField DataField="Posicion" HeaderText="Posición" />
            <asp:BoundField DataField="Tipo" HeaderText="Categoria" />
        </Columns>
    </asp:GridView>

    <asp:Image ID="Image1" runat="server" />


</asp:Content>
