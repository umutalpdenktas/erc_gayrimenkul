<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="apt_deneme1.index" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>AdminLTE 3 | Log in</title>

  <!-- Google Font: Source Sans Pro -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="../../plugins/fontawesome-free/css/all.min.css">
  <!-- icheck bootstrap -->
  <link rel="stylesheet" href="../../plugins/icheck-bootstrap/icheck-bootstrap.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="../../dist/css/adminlte.min.css">
</head>
<body class="hold-transition login-page">
<div class="login-box">
  <div class="login-logo">
    <a href="#"><b>Erciyas</b> Gayrimenkul</a>
  </div>
  <!-- /.login-logo -->
  <div class="card">
    <div class="card-body login-card-body">
      <p class="login-box-msg">Giriş Yap</p>

        <form id="form1" runat="server">
        <div class="input-group mb-3">
            <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
          <div class="input-group-append" class="form-control">
            <div class="input-group-text">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Kullanıcı Adını Girin" ForeColor="Red"></asp:RequiredFieldValidator>
              <span class="fas fa-envelope"></span>
            </div>
          </div>
        </div>
        <div class="input-group mb-3">
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Şifreyi Girin" ForeColor="Red"></asp:RequiredFieldValidator>
              <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-8">

          </div>
          <!-- /.col -->
          <div class="col-4">
              <asp:Button ID="Button1" runat="server" Text="Giriş" class="btn btn-primary btn-block" OnClick="Button1_Click" />
          </div>
          <!-- /.col -->
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
        </form>

            

      
    </div>
    <!-- /.login-card-body -->
  </div>
</div>
<!-- /.login-box -->

<!-- jQuery -->
<script src="../../plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- AdminLTE App -->
<script src="../../dist/js/adminlte.min.js"></script>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/iletisim.aspx">İletişim</asp:HyperLink></p>
</body>
</html>

