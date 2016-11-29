<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="WebServiceDeserialization.Result" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="_rptrEDP" runat="server">
        <ItemTemplate>
            <asp:HyperLink runat="server" Text='<%# Container.DataItem.ToString() %>'/></br>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
