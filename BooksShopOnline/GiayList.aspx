<%@ Page Title="Trang chủ" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GiayList.aspx.cs" Inherits="BooksShopOnline.GiayList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
 <div>
 <hgroup>
 <h2><%: Page.Title %></h2>
 </hgroup>
 <asp:ListView ID="ListView" runat="server" DataKeyNames="ID"
GroupItemCount="4"
 ItemType="BooksShopOnline.Models.Giay" SelectMethod="">
 <EmptyDataTemplate>
 <table >
 <tr>
 <td>No data was returned.</td>
 </tr>
 </table>
 </EmptyDataTemplate>
 <EmptyItemTemplate>
 <td/>
 </EmptyItemTemplate>
 <GroupTemplate>
 <tr id="itemPlaceholderContainer" runat="server">
 <td id="itemPlaceholder" runat="server"></td>
 </tr>
 </GroupTemplate>
 <ItemTemplate>
 <td runat="server">
 <table>
 <tr>
 <td>
 <a href="GiayDetails.aspx?ID=<%#:Item.ID%>">
 <img src ="/Images/<%#:Item.ImagePath%>"
 width="280" height="350"
style="border:solid" /></a>
 </td>
 </tr>
<tr>
 <td>
 <a href="GiayDetails.aspx?ID=<%#:Item.ID%>">
 <span>
 <%#:Item.Tengiay%>
 </span>
 </a>
<br />
 <span>
 <b>Price:
</b><%#:String.Format("{0:c}",Item.Giatien)%>
 </span>
<br />
 </td>
 </tr>
<tr>
 <td>&nbsp;</td>
 </tr>
 </table>
</p>
 </td>
 </ItemTemplate>
 <LayoutTemplate>
 <table style="width:100%;">
 <tbody>
 <tr>
 <td>
 <table id="groupPlaceholderContainer" runat="server"
style="width:100%">
 <tr id="groupPlaceholder"></tr>
 </table>
 </td>
 </tr>
<tr>
 <td></td>
 </tr>
<tr></tr>
 </tbody>
 </table>
 </LayoutTemplate>
 </asp:ListView>
 </div>
 </section>
</asp:Content>
