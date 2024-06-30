<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="requiredSerivices1._Default"  validateRequest="false" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <pre style="border-width: 1px; border-style: solid; border-color: rgb(240, 240, 224); padding: 5px; margin-top: -5px; font-size: 1.2em; font-family: &quot;Courier New&quot;; background-color: rgb(229, 229, 204); color: rgb(0, 0, 0); font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;">http://localhost:53286/ReqServices.svc?singleWsdl</pre>
    <pre style="border-width: 1px; border-style: solid; border-color: rgb(240, 240, 224); padding: 5px; margin-top: -5px; font-size: 18px; font-family: &quot;Courier New&quot;; background-color: rgb(229, 229, 204); color: rgb(0, 0, 0); font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;">&nbsp;</pre>

    <p>
        &nbsp;</p>
    <p>
    WebDownloading:</p>
<p>
    Send URL of the website you want as a string:
    <asp:TextBox ID="url" runat="server" Height="19px" Width="268px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Height="33px" Text="submit url" Width="144px" OnClick="Button1_Click" />
</p>
    <p>
        URL as string:</p>
<p>
    <asp:TextBox ID="webstring" runat="server" ReadOnly="True" TextMode="MultiLine" ScrollBars = "Vertical" Height="364px" Width="1085px"></asp:TextBox>
    </p>
<p>
    &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <pre style="border-width: 1px; border-style: solid; border-color: rgb(240, 240, 224); padding: 5px; margin-top: -5px; font-size: 18px; font-family: &quot;Courier New&quot;; background-color: rgb(229, 229, 204); color: rgb(0, 0, 0); font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;">&nbsp;</pre>
    <br class="Apple-interchange-newline" />
    <p>
        Word Filter:</p>
    <p>
        send a string to be filtered:
        <asp:TextBox ID="unfiltered" runat="server" Height="150px" TextMode="MultiLine" Width="775px" ScrollBars ="Vertical"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Height="35px" OnClick="Button2_Click" Text="submit" Width="150px" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        string after removing stop words: <asp:TextBox ID="filtered" runat="server" Height="250px" TextMode="MultiLine" Width="700px"></asp:TextBox>
    </p>
<p>
        &nbsp;</p>
    <p>
        <a>http://localhost:53023/combelecService.svc?singleWsdl</a></p>
    <p>
        &nbsp;</p>
    <p>
        Weather Forecast 5 Days:</p>
    <p>
        Enter Zip Code :&nbsp;
        <asp:TextBox ID="Zip" runat="server" Height="18px" Width="133px"></asp:TextBox>
        <asp:Button ID="forecast" runat="server" OnClick="forecast_Click" Text="Find Forecast" />
    </p>
    <p>
        5-day weather Forecast:
        <asp:TextBox ID="foreout" runat="server"  TextMode="MultiLine"  ScrollBars ="Vertical" Height="253px" Width="872px"></asp:TextBox>
    </p>
<p>
        &nbsp;</p>
    <p>
        Solar Energy Savings:</p>
    <p>
        Enter Zip Code:
        <asp:TextBox ID="zip2" runat="server"></asp:TextBox>
    </p>
    <p>
        Enter Panel Area (m2):
        <asp:TextBox ID="area" runat="server"></asp:TextBox>
    </p>
    <p>
        Enter Panel efficiency:
        <asp:TextBox ID="paneleff" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="efficiency" runat="server" OnClick="efficiency_Click" Text="calculate" />
    </p>
<p>
        &nbsp;</p>
    <p>
        Saving result:
        <asp:TextBox ID="saving" runat="server" TextMode="MultiLine"  ScrollBars ="Vertical"  Height="90px" Width="960px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
<p>
    &nbsp;</p>

</asp:Content>
