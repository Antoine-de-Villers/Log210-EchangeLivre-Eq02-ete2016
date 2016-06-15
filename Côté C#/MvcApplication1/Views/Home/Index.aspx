<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page - My ASP.NET MVC Application
</asp:Content>

<asp:Content ID="indexFeatured" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Home Page.</h1>
            </hgroup>
            <p>
                L'échange de livres d'éts est une application web simple pour vente ou échanger des livre usager ainsi 
                qu'achetter des livre de la coop.
                <%--To learn more about ASP.NET MVC visit
                <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
                The page features <mark>videos, tutorials, and samples</mark> to help you get the most from ASP.NET MVC.
                If you have any questions about ASP.NET MVC visit
                <a href="http://forums.asp.net/1146.aspx/1?MVC" title="ASP.NET MVC Forum">our forums</a>.--%>
            </p>
        </div>
    </section>
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Voici ce que vous pouvez faire</h3>
    <ol class="round">
        <li class="one">
            <h5>Partir du bon pied!</h5>
           Sur ce site, vous pourrez faire l'échange de livre facilement en utilisant la Coop. 
        </li>



        <li class="two">
            <h5>Créez vos offres</h5>
           Vous pourrez créer vos propres offres de livre!
        </li>

        <li class="three">
            <h5>Récupération sur place</h5>
            Faites affaire avec votre Coop pour récupérer vos livres sur place grâce à un système d'étiquette!
        </li>
    </ol>
</asp:Content>
