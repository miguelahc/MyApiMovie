<%@ Page Title="" Language="C#" MasterPageFile="~/MyApiMovie.Master" AutoEventWireup="true" CodeBehind="SearchByTitle.aspx.cs" Inherits="MyApiMovie.WebSite.SearchByTitle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="main">

					<section id="contact" class="four">
						<div class="container">

							<header>
								<h2>Búsqueda de Peliculas</h2>
							</header>

							<p><strong>MyApiMovie</strong>, es una aplicación libre de entretenimiento que proporciona información de películas de una forma rápida y amiable, las cuales pueden ser asociadas a una cuenta de usuario. </p>
							
							
								<div class="row half">
									<div class="12u"><input type="text" name="email" placeholder="Título de la película" />
									</div>
								</div>
								<div class="row">
									<div class="12u">
										<input type="submit" value="Buscar Película" />
									</div>
								</div>
							

						</div>
					</section>

			</div>
</asp:Content>
