<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductCRUD.aspx.cs" Inherits="SerializeAndDeserializeWeb.ProductCRUD" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-2"></div>
    <div class="col-md-8">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <h4>Product Details</h4>
            </div>
            <div class="panel-body">
                <div class="row">
                    <p class="col-md-3">
                        <asp:Label ID="Label1" runat="server" Text="ID" CssClass="control-label"> </asp:Label>
                        <asp:TextBox ID="_txtID" runat="server" CssClass="form-control"></asp:TextBox>
                    </p>
                    <p class="col-md-9">
                        <asp:Label ID="Label2" runat="server" Text="Product Name" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="_txtName" runat="server" CssClass="form-control"></asp:TextBox>
                    </p>
                </div>
                <div class="row">
                    <p class="col-md-4">
                        <asp:Label ID="Label3" runat="server" Text="Price" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="_txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
                    </p>
                    <p class="col-md-4">
                        <asp:Label ID="Label4" runat="server" Text="Unit" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="_txtUnit" runat="server" CssClass="form-control"></asp:TextBox>
                    </p>
                    <p class="col-md-4">
                        <asp:Label ID="Label8" runat="server" Text="Category Name" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="_txtCategory" runat="server" CssClass="form-control"></asp:TextBox>
                    </p>
                </div>
            </div>
            <div class="panel-footer"></div>
        </div>
        <div class="panel panel-success">
            <div class="panel-heading">
                <h4>Product Description</h4>
            </div>
            <div class="panel-body">
                <p class="col-md-4">
                    <asp:Label ID="Label5" runat="server" Text="Color" CssClass="control-label"></asp:Label>
                    <asp:TextBox ID="_txtColor" runat="server" CssClass="form-control" TextMode="Color"></asp:TextBox>
                </p>
                <p class="col-md-4">
                    <asp:Label ID="Label6" runat="server" Text="Size" CssClass="control-label"></asp:Label>
                    <asp:TextBox ID="_txtSize" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                </p>
                <p class="col-md-4">
                    <asp:Label ID="Label7" runat="server" Text="Weight" CssClass="control-label"></asp:Label>
                    <asp:TextBox ID="_txtWeight" runat="server" CssClass="form-control"></asp:TextBox>
                </p>
            </div>
            <div class="panel-footer"></div>
        </div>
        <div class="panel panel-danger panel-body text-center">
            <asp:Button ID="_btnSave" runat="server" Text="Save" CssClass="btn btn-info" OnClick="_btnSave_Click" />
            <asp:Button ID="_btnClear" runat="server" Text="Clear" CssClass="btn btn-danger" OnClientClick="this.form.reset();return false;" />
        </div>
        <div class="panel panel-warning">
            <div class="panel-heading">
                <h4>Product List</h4>
            </div>
            <div class="panel-body">
                <div class="table-responsive">
                    <asp:GridView ID="_grdvwProduct" runat="server" DataSourceID="XmlDataSource1" CssClass="table table-condensed" GridLines="None" AutoGenerateColumns="false" AllowPaging="True">
                        <Columns>
                            <asp:TemplateField HeaderText="ID">
                                <ItemTemplate>
                                    <%# XPath("@id") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Name">
                                <ItemTemplate>
                                    <%# XPath("name") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Category Name">
                                <ItemTemplate>
                                    <%# XPath("@categoryname") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Price">
                                <ItemTemplate>
                                    <%# XPath("price") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Unit">
                                <ItemTemplate>
                                    <%# XPath("price/@unit") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Color">
                                <ItemTemplate>
                                    <%# XPath("description/color") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Size">
                                <ItemTemplate>
                                    <%# XPath("description/size") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Weight">
                                <ItemTemplate>
                                    <%# XPath("description/weight") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <HeaderStyle CssClass="success" />
                    </asp:GridView>
                </div>
                <asp:XmlDataSource runat="server" ID="XmlDataSource1" DataFile="~/ProductWEB.xml"></asp:XmlDataSource>
                <%--<asp:Label ID="Label9" runat="server"></asp:Label><br />
                <asp:Label ID="Label10" runat="server"></asp:Label><br />
                <asp:Label ID="Label11" runat="server"></asp:Label><br />
                <asp:Label ID="Label12" runat="server"></asp:Label><br />
                <asp:Label ID="Label13" runat="server"></asp:Label><br />
                <asp:Label ID="Label14" runat="server"></asp:Label><br />
                <asp:Label ID="Label15" runat="server"></asp:Label><br />
                <asp:Label ID="Label16" runat="server"></asp:Label>--%>
            </div>
            <div class="panel-footer"></div>
        </div>
    </div>
    <div class="col-md-2"></div>
</asp:Content>
