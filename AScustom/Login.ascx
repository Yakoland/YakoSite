<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="WebApplication4.AScustom.Login" %>
<link href="../bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
<script src="../jQuery/jquery-3.1.1.min.js" type="text/javascript"></script>
<script src="../bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
<link href="../css/Default.css" rel="stylesheet" type="text/css" />
<script src="../jQuery/Default.js" type="text/javascript"></script>
 <div class="container">
    <div class="modal fade" id="myModal" role="dialog">
        <div class="modal-dialog Cssascx">
            <div class="modal-content Cssascx">
                <div class="modal-header">
                    <button type="button" class="close">&times;</button>
                    <h4 class="modal-title">Bienvenido</h4>
                </div>
                <div class="modal-body">
                    <div class="container">
                        <div class="form-group" id="campoUsuario">
                            <label for="txtUsuario">Usuario</label>
                            <asp:TextBox ID="txtUsuario" class="form-control" runat="server" Width="204px"></asp:TextBox>
                        </div>
                        <div class="form-group" id="campoPassWord">
                            <label for="txtPassword">Password</label>
                            <asp:TextBox ID="txtPassword" class="form-control" runat="server" Width="204px"></asp:TextBox>
                        </div>
                        <div class="form-group" id="botonEntrar">
                            <asp:Button ID="Entrar" class="btn btn-primary" runat="server" Text="Entrar" />
                        </div>
                        <div class="form-group" id="requireValidarorCampos">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" class="alert alert-danger" runat="server" 
                                    ErrorMessage="Debe Ingresar un Usuario" 
                            ControlToValidate="txtUsuario"></asp:RequiredFieldValidator><br /><br />

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" class="alert alert-danger" runat="server" 
                                        ErrorMessage="Debe Ingresar un Password" 
                                ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                </div>
            </div>
        </div>
    </div>
</div>