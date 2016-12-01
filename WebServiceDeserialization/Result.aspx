<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="WebServiceDeserialization.Result" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="_rptrEDP" runat="server">
        <ItemTemplate>
            <div class="col-sm-4"></div>
            <div class="col-sm-4">
                <div class=" panel panel-info">
                    <div class="panel-heading">
                        <h4>Details</h4>
                    </div>
                    <div class="panel-body">
                    <asp:HyperLink runat="server" CssClass="btn btn-hyperlink" Text='<%# Container.DataItem.ToString()%>' NavigateUrl='<%#string.Concat("~/ProductDetails.aspx?id=",Container.DataItem.ToString()) %>' ID="_hyprlnkEDP"></asp:HyperLink></br>
                    <asp:Label CssClass="control-label" ID="lbl_Store" runat="server" Text="Store:"></asp:Label></br>
                    <asp:Label CssClass="control-label" ID="lbl_Name" runat="server" Text="Name:"></asp:Label></br>
                    <asp:Label CssClass="control-label" ID="lbl_Description" runat="server" Text="Description:"></asp:Label></br>
                    <asp:Label CssClass="control-label" ID="lbl_Price" runat="server" Text="Price:"></asp:Label></br>
                    <asp:Label CssClass="control-label" ID="lbl_Manufacturer" runat="server" Text="Manufacturer:"></asp:Label></br>
                    <asp:Image ID="img_Prod" runat="server" /></br>
                    <asp:Label CssClass="control-label" ID="lbl_Availability" runat="server" Text="Availability:"></asp:Label></br>
                    </div>
                </div>
            </div>
            <div class="col-sm-4"></div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
