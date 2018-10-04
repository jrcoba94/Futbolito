<%@ Page Title="" Language="C#" MasterPageFile="~/MassterPage/ProyectoAFEYAC.Master" AutoEventWireup="true" CodeBehind="EquiposLiga.aspx.cs" Inherits="AFEYAC.GUI.EquiposLiga" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphTitulo" runat="server">

    <a>Copa Interescolar Lázaro Cárdenas Equipos</a>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContenido" runat="server">

   <div class="website-top">
    <h3><p></p></h3>
			</div>
    <div class="row">
            <div class="box">

                <div class="col-lg-12">
                <div class="alert alert-success alert-dismissable">
				 
				<button type="button" class="close" data-dismiss="alert" aria-hidden="true">
					×
				</button>
				<h4>
					¡Esta liga !
				</h4> <strong></strong>La Copa Interescolar Lázaro Cárdenas es una liga registrada a la Asociación De Fútbol Del Estado De Yucatán que actualmente cuenta con 8 equipos afiliados a esta liga.<a href="Bases.aspx" class="hvr-bounce-to-bottom"></a>
		     	</div>
                </div>

             
                <div class="col-lg-12">

                       <h4><strong>Equipos</strong></h4>

                   
                      <asp:GridView ID="GridView1" runat="server" class="table table-bordered" AutoGenerateColumns="False" DataKeyNames="IDequipo" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                          <Columns>
                              <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                              <asp:BoundField DataField="Fundacion" HeaderText="Fundación" />
                              <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" />
                              <asp:BoundField DataField="Estatus" HeaderText="Estatus"/>
                              <asp:BoundField DataField="Nombre1" HeaderText="Director" />
                              <asp:BoundField DataField="Nombre2" HeaderText="Dueño" />
                              <asp:BoundField DataField="Tipo" HeaderText="Categoria" />
                              <asp:ButtonField CommandName="Detalle" Text="Jugadores" />
                          </Columns>
                       </asp:GridView>

                </div>


            </div>
        </div>

</asp:Content>
