﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SoftProg.Master" AutoEventWireup="true" CodeBehind="ListarEmpleados.aspx.cs" Inherits="SoftProgWA.ListarEmpleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_Title" runat="server">
    Listar Empleados
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_Scripts" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_Contenido" runat="server">
    <div class="container">
        <div class="container row">
            <div class="row align-items-center">
                <div class="col-auto">
                    <asp:Label ID="lblNombreDNI" CssClass="form-label" runat="server"
                        Text="Ingrese el DNI o el nombre:"></asp:Label>
                </div>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtNombreDNI" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-sm-2">
                    <asp:LinkButton ID="lbBuscar" CssClass="btn btn-info" runat="server"
                        Text="<i class='fa-solid fa-magnifying-glass pe-2'></i> Buscar" />
                </div>
                <div class="col text-end p-3">
                    <asp:LinkButton ID="lbRegistrar" CssClass="btn btn-success" runat="server"
                        Text="<i class='fa-solid fa-plus pe-2'></i> Registrar Empleado"
                        OnClick="lbRegistrar_Click"/>
                </div>
            </div>
            <div class="container row">
                <asp:GridView ID="dgvEmpleados" runat="server" AutoGenerateColumns="false"
                    OnRowDataBound="dgvEmpleados_RowDataBound" AllowPaging="true"
                    OnPageIndexChanging="dgvEmpleados_PageIndexChanging" PageSize="5"
                    CssClass="table table-hover table-responsive table-striped">
                    <Columns>
                        <asp:BoundField HeaderText="DNI" ItemStyle-CssClass="align-middle" />
                        <asp:BoundField HeaderText="Nombre Completo" ItemStyle-CssClass="align-middle" />
                        <asp:BoundField HeaderText="Area" ItemStyle-CssClass="align-middle" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton runat="server" Text="<i class='fa-solid fa-edit'></i> Modificar" CssClass="btn btn-warning" />
                                <asp:LinkButton runat="server" Text="<i class='fa-solid fa-trash'></i> Eliminar" CssClass="btn btn-danger" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
