<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="WebServiceDeserialization.Result" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="_rptrEDP" runat="server">
        <ItemTemplate>
            <%--<div class="col-sm-3">
                    <div class="well">
                        <asp:HyperLink runat="server" CssClass="btn btn-hyperlink" Text='<%# Container.DataItem.ToString()%>' NavigateUrl='<%#string.Concat("~/ProductDetails.aspx?id=",Container.DataItem.ToString()) %>' ID="_hyprlnkEDP"></asp:HyperLink>
                    </div>
                </div>--%>
            <div class="col-sm-3"></div>
            <div class="col-sm-6">
                <div class="row">
                    <div class="well">
                        <asp:Panel runat="server" Height="500px">

                        </asp:Panel>
                    </div>
                </div>
            </div>
            <div class="col-sm-3"></div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
