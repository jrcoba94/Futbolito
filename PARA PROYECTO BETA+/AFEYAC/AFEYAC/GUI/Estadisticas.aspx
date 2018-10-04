<%@ Page Title="" Language="C#" MasterPageFile="~/MassterPage/ProyectoAFEYAC.Master" AutoEventWireup="true" CodeBehind="Estadisticas.aspx.cs" Inherits="AFEYAC.GUI.Estadisticas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphTitulo" runat="server">
    <strong>Estadísticas Mejores equipos</strong> 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContenido" runat="server">


 <div class="container-fluid">
	<div class="row">
		<div class="col-md-9">

         <div class="container-fluid">
	<div class="row">
		<div class="col-md-12">

            <div id="etab_tbl_div" class="tabdiv">
                <br />
                <br />
                <table id="s_table_0" class="tblscss" width="100%" cellpadding="0" cellspacing="0">
	<thead>
	<tr>
		<th width="20" class="sort asc" axis="int" id="tblrank_id">
			Pos		</th>
				<th class="bno_sort" style="border-right:0px;" width="5%"></th>
				<th width="120" class="sort asc" axis="string" style="border-left:0px;">
			<div style="margin-left:-15px;">Equipos</div>
		</th>
				<th class="sort asc" axis="int">JJ</th>
						<th class="sort asc" axis="int">JG</th>
						<th class="sort asc" axis="int">JE</th>
						<th class="sort asc" axis="int">JP</th>
										<th class="sort asc" axis="int">DG</th>
				
		<th class="sort asc" axis="int">GF</th>

				
		<th class="sort asc" axis="int">GC</th>

																						<th class="sort asc" axis="int">Pts</th>
					</tr>
	</thead>
	<tbody>
			<tr>
			<td>1						</td>
						<td style="border-right:0px;">
				<img width="30" height="30" src="http://ligasabatinadefutbol.com.mx/media/bearleague/bl13353155772068.png" class="embl_in_tbl" alt="ACAN">			</td>
						<td style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="">			
				<a href="#">ACAN</a>
			</td>
						<td>22</td>
									<td>14</td>
									<td>3</td>
									<td>5</td>
															<td>32</td>
									<td>66</td>
									<td>34</td>
																																	<td>45</td>
									
		</tr>
				<tr>
			<td>2						</td>
						<td style="border-right:0px;">
				<img width="30" height="30" src="http://ligasabatinadefutbol.com.mx/media/bearleague/bl13636738521385.jpg" class="embl_in_tbl" alt="KUCAB F.C.">			</td>
						<td style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="">			
				<a href="#">KUCAB F.C.</a>
			</td>
						<td>22</td>
									<td>14</td>
									<td>2</td>
									<td>6</td>
															<td>19</td>
									<td>58</td>
									<td>39</td>
																																	<td>44</td>
									
		</tr>
				<tr>
			<td>3						</td>
						<td style="border-right:0px;">
				<img width="30" height="30" src="http://ligasabatinadefutbol.com.mx/media/bearleague/bl14331573531581.jpg" class="embl_in_tbl" alt="GALLOS F.C">			</td>
						<td style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="">			
				<a href="#">GALLOS F.C</a>
			</td>
						<td>22</td>
									<td>13</td>
									<td>4</td>
									<td>5</td>
															<td>31</td>
									<td>52</td>
									<td>21</td>
																																	<td>43</td>
									
		</tr>
				<tr>
			<td>4						</td>
						<td style="border-right:0px;">
							</td>
						<td style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="">			
				<a href="#">Veteranos de Faheli</a>
			</td>
						<td>21</td>
									<td>13</td>
									<td>4</td>
									<td>4</td>
															<td>19</td>
									<td>50</td>
									<td>31</td>
																																	<td>43</td>
									
		</tr>
				<tr>
			<td>5						</td>
						<td style="border-right:0px;">
							</td>
						<td style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="">			
				<a href="#">Deportivo San Juan</a>
			</td>
						<td>22</td>
									<td>12</td>
									<td>3</td>
									<td>7</td>
															<td>-5</td>
									<td>31</td>
									<td>36</td>
																																	<td>39</td>
									
		</tr>
				<tr>
			<td>6						</td>
						<td style="border-right:0px;">
				<img width="30" height="30" src="http://ligasabatinadefutbol.com.mx/media/bearleague/bl14256811272666.jpg" class="embl_in_tbl" alt="HAPA">			</td>
						<td style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="">			
				<a href="#">HAPA</a>
			</td>
						<td>21</td>
									<td>9</td>
									<td>4</td>
									<td>8</td>
															<td>12</td>
									<td>47</td>
									<td>35</td>
																																	<td>31</td>
									
		</tr>
				<tr>
			<td>7						</td>
						<td style="border-right:0px;">
							</td>
						<td style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="">			
				<a href="#">Tepitos</a>
			</td>
						<td>21</td>
									<td>8</td>
									<td>4</td>
									<td>9</td>
															<td>3</td>
									<td>41</td>
									<td>38</td>
																																	<td>28</td>
									
		</tr>
				<tr>
			<td>8						</td>
						<td style="border-right:0px;">
				<img width="30" height="30" src="http://ligasabatinadefutbol.com.mx/media/bearleague/bl13354129711154.png" class="embl_in_tbl" alt="Español F.C.">			</td>
						<td style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="">			
				<a href="#">Español F.C.</a>
			</td>
						<td>21</td>
									<td>8</td>
									<td>3</td>
									<td>10</td>
															<td>4</td>
									<td>50</td>
									<td>46</td>
																																	<td>27</td>
									
		</tr>
				<tr>
			<td>9						</td>
						<td style="border-right:0px;">
				<img width="30" height="30" src="http://ligasabatinadefutbol.com.mx/media/bearleague/bl13354137162289.png" class="embl_in_tbl" alt="Veteranos de Kukab">			</td>
						<td style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="">			
				<a href="#">Veteranos de Kukab</a>
			</td>
						<td>22</td>
									<td>8</td>
									<td>0</td>
									<td>14</td>
															<td>-15</td>
									<td>43</td>
									<td>58</td>
																																	<td>24</td>
									
		</tr>
				<tr>
			<td>10						</td>
						<td style="border-right:0px;">
				<img width="30" height="30" src="http://ligasabatinadefutbol.com.mx/media/bearleague/bl13396513042321.jpg" class="embl_in_tbl" alt="Deportivo Villa">			</td>
						<td style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="">			
				<a href="#">Deportivo Villa</a>
			</td>
						<td>23</td>
									<td>6</td>
									<td>6</td>
									<td>11</td>
															<td>-16</td>
									<td>49</td>
									<td>65</td>
																																	<td>24</td>
									
		</tr>
				<tr>
			<td>11						</td>
						<td style="border-right:0px;">
				<img width="30" height="30" src="http://ligasabatinadefutbol.com.mx/media/bearleague/bl1335410815230.jpg" class="embl_in_tbl" alt="Leones Negros">			</td>
						<td style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="">			
				<a href="#">Leones Negros</a>
			</td>
						<td>21</td>
									<td>6</td>
									<td>4</td>
									<td>11</td>
															<td>-8</td>
									<td>32</td>
									<td>40</td>
																																	<td>22</td>
									
		</tr>
				<tr>
			<td>12						</td>
						<td style="border-right:0px;">
				<img width="30" height="30" src="http://ligasabatinadefutbol.com.mx/media/bearleague/bl137058288162.png" class="embl_in_tbl" alt="D.S.P.">			</td>
						<td style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="">			
				<a href="#">D.S.P.</a>
			</td>
						<td>20</td>
									<td>4</td>
									<td>6</td>
									<td>10</td>
															<td>-26</td>
									<td>18</td>
									<td>44</td>
																																	<td>18</td>
									
		</tr>
				<tr>
			<td>13						</td>
						<td style="border-right:0px;">
				<img width="30" height="30" src="http://ligasabatinadefutbol.com.mx/media/bearleague/bl13946006091683.jpg" class="embl_in_tbl" alt="Veterinaria Calkiní">			</td>
						<td style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="">			
				<a href="#">Veterinaria Calkiní</a>
			</td>
						<td>22</td>
									<td>3</td>
									<td>1</td>
									<td>18</td>
															<td>-50</td>
									<td>33</td>
									<td>83</td>
																																	<td>11</td>
									
		</tr>
			</tbody>
</table>
<br>
<script type="text/javascript">
    new Grid($('s_table_0'));
</script>
                <br />
                <br />
</div>


		</div>
	</div>
</div>

		</div>
		<div class="col-md-3">

  
            <div class="row">
				<div class="col-md-12">

                    <div id="derecha">
        		<table cellpadding="0" cellspacing="0" class="moduletable">
			<tbody><tr class="degradado">
			<th class="degradado">
				<a>Tabla General			</a></th>
		</tr>
			<tr>
			<td>
				
<table width="100%" class="tblview">	<tbody><tr class="Tabla General			">
		<th width="20">№</th>
				<th style="border-left:0px;">
		<div><a>Team</a></div>
		</th>
										
																												<th>
		<a>Puntos		</a></th>
					</tr>
	<tr class="tblro1">
	<td width="20">1</td>
		<td width="80%" style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="nowrap" class="blteamname">
		
				
		<a href="/index.php/estadisticas/team/5/1">ACAN</a>
			</td>
					
														<td>45</td>
			
</tr>
<tr class="tblro0">
	<td width="20">2</td>
		<td width="80%" style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="nowrap" class="blteamname">
		
				
		<a href="/index.php/estadisticas/team/5/18">KUCAB F.C.</a>
			</td>
					
														<td>44</td>
			
</tr>
<tr class="tblro1">
	<td width="20">3</td>
		<td width="80%" style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="nowrap" class="blteamname">
		
				
		<a href="/index.php/estadisticas/team/5/2">GALLOS F.C</a>
			</td>
					
														<td>43</td>
			
</tr>
<tr class="tblro0">
	<td width="20">4</td>
		<td width="80%" style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="nowrap" class="blteamname">
		
				
		<a href="/index.php/estadisticas/team/5/24">Veteranos de Faheli</a>
			</td>
					
														<td>43</td>
			
</tr>
<tr class="tblro1">
	<td width="20">5</td>
		<td width="80%" style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="nowrap" class="blteamname">
		
				
		<a href="/index.php/estadisticas/team/5/23">Deportivo San Juan</a>
			</td>
					
														<td>39</td>
			
</tr>
<tr class="tblro0">
	<td width="20">6</td>
		<td width="80%" style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="nowrap" class="blteamname">
		
				
		<a href="/index.php/estadisticas/team/5/6">HAPA</a>
			</td>
					
														<td>31</td>
			
</tr>
<tr class="tblro1">
	<td width="20">7</td>
		<td width="80%" style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="nowrap" class="blteamname">
		
				
		<a href="/index.php/estadisticas/team/5/20">Tepitos</a>
			</td>
					
														<td>28</td>
			
</tr>
<tr class="tblro0">
	<td width="20">8</td>
		<td width="80%" style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="nowrap" class="blteamname">
		
				
		<a href="/index.php/estadisticas/team/5/7">Español F.C.</a>
			</td>
					
														<td>27</td>
			
</tr>
<tr class="tblro1">
	<td width="20">9</td>
		<td width="80%" style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="nowrap" class="blteamname">
		
				
		<a href="/index.php/estadisticas/team/5/11">Veteranos de Kukab</a>
			</td>
					
														<td>24</td>
			
</tr>
<tr class="tblro0">
	<td width="20">10</td>
		<td width="80%" style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="nowrap" class="blteamname">
		
				
		<a href="/index.php/estadisticas/team/5/13">Deportivo Villa</a>
			</td>
					
														<td>24</td>
			
</tr>
<tr class="tblro1">
	<td width="20">11</td>
		<td width="80%" style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="nowrap" class="blteamname">
		
				
		<a href="/index.php/estadisticas/team/5/4">Leones Negros</a>
			</td>
					
														<td>22</td>
			
</tr>
<tr class="tblro0">
	<td width="20">12</td>
		<td width="80%" style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="nowrap" class="blteamname">
		
				
		<a href="/index.php/estadisticas/team/5/17">D.S.P.</a>
			</td>
					
														<td>18</td>
			
</tr>
<tr class="tblro1">
	<td width="20">13</td>
		<td width="80%" style="text-align:left;border-left:0px; padding:0px 10px;" nowrap="nowrap" class="blteamname">
		
				
		<a href="/index.php/estadisticas/team/5/22">Veterinaria Calkiní</a>
			</td>
					
														<td>11</td>
			
</tr>
</tbody></table>
			</td>
		</tr>
		</tbody></table>
		<table cellpadding="0" cellspacing="0" class="moduletable">
			<tbody><tr class="degradado">
			<th class="degradado">
				<br />
				<a>Tabla de Goleo			</a></th>
		</tr>
			<tr>
			<td>
				<div class="jsm_playerstat">
<table width="100%" cellpadding="0" cellspacing="0" border="0" class="mdjb_js">
   
	<tbody><tr>
	<td><div style="float:left;width:27px;height:37px;margin:0px 10px 0px 0px;"><img style="border:1px solid #aaa;" src="../Recursos/img/11001761_754422701321459_1445233970524857615_n.jpg" title="Gol" height="25"></div></td><td align="center"><strong>23</strong></td><td><a href="/index.php/estadisticas/player/5/86">Jorge Mas</a></td><td><a href="/index.php/estadisticas/team/5/1">ACAN</a></td>	</tr>
	<tr>
	<td><div style="float:left;width:27px;height:37px;margin:0px 10px 0px 0px;"><img style="border:1px solid #aaa;" src="../Recursos/img/11001761_754422701321459_1445233970524857615_n.jpg" title="Gol" height="25"></div></td><td align="center"><strong>21</strong></td><td><a href="/index.php/estadisticas/player/5/166">Victor Alfonso Huchin Caamal</a></td><td><a href="/index.php/estadisticas/team/5/2">GALLOS F.C</a></td>	</tr>
	<tr>
	<td><div style="float:left;width:27px;height:37px;margin:0px 10px 0px 0px;"><img style="border:1px solid #aaa;" src="../Recursos/img/11001761_754422701321459_1445233970524857615_n.jpg" title="Gol" height="25"></div></td><td align="center"><strong>20</strong></td><td><a href="/index.php/estadisticas/player/5/653">Emmanuel Uc Chi</a></td><td><a href="/index.php/estadisticas/team/5/13">Deportivo Villa</a></td>	</tr>
	<tr>
	<td><div style="float:left;width:27px;height:37px;margin:0px 10px 0px 0px;"><img style="border:1px solid #aaa;" src="../Recursos/img/11001761_754422701321459_1445233970524857615_n.jpg" title="Gol" height="25"></div></td><td align="center"><strong>20</strong></td><td><a href="/index.php/estadisticas/player/5/109">Ruperto Brito Ordoñez</a></td><td><a href="/index.php/estadisticas/team/5/1">ACAN</a></td>	</tr>
	<tr>
	<td><div style="float:left;width:27px;height:37px;margin:0px 10px 0px 0px;"><img style="border:1px solid #aaa;" src="../Recursos/img/11001761_754422701321459_1445233970524857615_n.jpg" title="Gol" height="25"></div></td><td align="center"><strong>19</strong></td><td><a href="/index.php/estadisticas/player/5/737">Diego Huchin</a></td><td><a href="/index.php/estadisticas/team/5/6">HAPA</a></td>	</tr>
	<tr>
	<td><div style="float:left;width:27px;height:37px;margin:0px 10px 0px 0px;"><img style="border:1px solid #aaa;" src="../Recursos/img/11001761_754422701321459_1445233970524857615_n.jpg" title="Gol" height="25"></div></td><td align="center"><strong>14</strong></td><td><a href="/index.php/estadisticas/player/5/888">Abraham Chan Che</a></td><td><a href="/index.php/estadisticas/team/5/24">Veteranos de Faheli</a></td>	</tr>
	<tr>
	<td><div style="float:left;width:27px;height:37px;margin:0px 10px 0px 0px;"><img style="border:1px solid #aaa;" src="../Recursos/img/11001761_754422701321459_1445233970524857615_n.jpg" title="Gol" height="25"></div></td><td align="center"><strong>13</strong></td><td><a href="/index.php/estadisticas/player/5/865">Edgar David Kin Martinez</a></td><td><a href="/index.php/estadisticas/team/5/7">Español F.C.</a></td>	</tr>
	<tr>
	<td><div style="float:left;width:27px;height:37px;margin:0px 10px 0px 0px;"><img style="border:1px solid #aaa;" src="../Recursos/img/11001761_754422701321459_1445233970524857615_n.jpg" title="Gol" height="25"></div></td><td align="center"><strong>10</strong></td><td><a href="/index.php/estadisticas/player/5/26">EMANUEL SALAZAR</a></td><td><a href="/index.php/estadisticas/team/5/18">KUCAB F.C.</a></td>	</tr>
</tbody></table>
                    <br />
                    <br />
</div>			</td>
		</tr>
		</tbody></table>
	
        </div>

				</div>
			</div>
            

	

		</div>
	</div>
</div>

</asp:Content>
