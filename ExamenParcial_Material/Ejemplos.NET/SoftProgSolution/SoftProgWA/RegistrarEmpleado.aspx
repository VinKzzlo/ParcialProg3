<%@ Page Title="" Language="C#" MasterPageFile="~/SoftProg.Master" AutoEventWireup="true" CodeBehind="RegistrarEmpleado.aspx.cs" Inherits="SoftProgWA.RegistrarEmpleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_Title" runat="server">
    Registrar Empleado
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_Scripts" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_Contenido" runat="server">
    <div class="container">
        <div class="card">
            <div class="card-header">
                <h2>Registrar Empleado</h2>
            </div>
            <div class="card-body">
                <div class="mb-3 row">
                    <asp:Label ID="lblDNI" runat="server" CssClass="col-sm-2 col-form-label" Text="DNI: "></asp:Label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtDNIEmpleado" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="mb-3 row">
                    <asp:Label CssClass="col-sm-2 form-label" ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                    <div class="col-sm-8">
                        <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="mb-3 row">
                    <asp:Label ID="lblApellidoPaterno" runat="server" Text="Apellido Paterno: " CssClass="col-sm-2 col-form-label"></asp:Label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtApellidoPaterno" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="mb-3 row">
                    <asp:Label ID="lblArea" CssClass="col-sm-2 form-label" runat="server" Text="Area:"></asp:Label>
                    <div class="col-sm-8">
                        <asp:DropDownList ID="ddlAreas" CssClass="form-select" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="mb-3 row">
                    <div class="col-sm-2">
                        <asp:Label ID="lblGenero" runat="server" Text="Género: " CssClass="col-form-label"></asp:Label>
                    </div>
                    <div class="col-sm-8">
                        <div class="form-check form-check-inline">
                            <input type="radio" runat="server" id="rbMasculino" class="form-check-input" />
                            <label class="form-check-label" runat="server" for="cphContenido_rbMasculino">Masculino</label>
                        </div>
                        <div class="form-check form-check-inline">
                            <input type="radio" runat="server" id="rbFemenino" class="form-check-input" />
                            <label class="form-check-label" runat="server" for="cphContenido_rbFemenino">Femenino</label>
                        </div>
                    </div>
                </div>
                <div class="mb-3 row">
                    <asp:Label runat="server" Text="Fecha Nacimiento: " CssClass="col-sm-2 col-form-label"></asp:Label>
                    <div class="col-sm-8">
                        <input id="dtpFechaNacimiento" class="form-control" type="date" runat="server" />
                    </div>
                </div>
                <div class="mb-3 row">
                    <asp:Label ID="lblCargo" runat="server" Text="Cargo: " CssClass="col-sm-2 col-form-label"></asp:Label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtCargo" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="mb-3 row">
                    <asp:Label ID="lblSueldo" runat="server" Text="Sueldo: " CssClass="col-sm-2 col-form-label"></asp:Label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtSueldo" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="card-footer">
                <asp:LinkButton ID="btnGuardar" CssClass="float-end btn btn-primary" runat="server" Text="<i class='fa-solid fa-floppy-disk pe-2'></i> Guardar" OnClick="btnGuardar_Click"/>
            </div>
        </div>
    </div>
</asp:Content>
