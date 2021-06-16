<%@ Page Title="" Language="C#" MasterPageFile="~/muhasebe/daireler/Site1.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="apt_deneme1.iletisim1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>AdminLTE 3 | Contact us</title>

  <!-- Google Font: Source Sans Pro -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="../../plugins/fontawesome-free/css/all.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="../../dist/css/adminlte.min.css">
</head>
<body class="hold-transition sidebar-mini layout-fixed">
<!-- Site wrapper -->
<div class="wrapper">
  <!-- Navbar -->
    <!-- Left navbar links -->


    <!-- Right navbar links -->
   

      <!-- Messages Dropdown Menu -->
      
      <!-- Notifications Dropdown Menu -->

  
  <!-- /.navbar -->

  <!-- Main Sidebar Container -->
  

  <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper" style="margin-left:5px;">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <div class="container-fluid">
        <div class="row mb-2">
          <div class="col-sm-6">
            <h1>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx">İletişim</asp:HyperLink></h1>
          </div>
          <div class="col-sm-6">

          </div>
        </div>
      </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class="content">

      <!-- Default box -->
      <div class="card">
        <div class="card-body row">
          <div class="col-5 text-center d-flex align-items-center justify-content-center">
            <div class="">
              <h2>Erciyas<strong> Gayrimenkul</strong></h2>
              <p class="lead mb-5">Oğuzlar Mahallesi 1364. sokak No:4/4<br>
                Telefon: (0312) 905 50 50
              </p>
            </div>
          </div>
          <div class="col-7">
            <div class="form-group">
              <label for="inputName">İsim</label>
                <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
              <label for="inputEmail">Mail</label>
                <asp:TextBox ID="TextBox2" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
            </div>
            <div class="form-group">
              <label for="inputSubject">Konu</label>
                <asp:TextBox ID="TextBox3" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
              <label for="inputMessage">Mesaj</label>
                <asp:TextBox ID="TextBox4" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
              
                <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Gönder" OnClick="Button1_Click"/>
                <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </div>
          </div>
        </div>
      </div>

    </section>
    <!-- /.content -->
  </div>
  <!-- /.content-wrapper -->

  <footer class="main-footer">
    <div class="float-right d-none d-sm-block">
      <b>Version</b> 3.1.0
    </div>
    <strong>Tüm Hakları Saklıdır.® 2021</strong>
  </footer>

  <!-- Control Sidebar -->
  <aside class="control-sidebar control-sidebar-dark">
    <!-- Control sidebar content goes here -->
  </aside>
  <!-- /.control-sidebar -->
</div>
<!-- ./wrapper -->

<!-- jQuery -->
<script src="../../plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- AdminLTE App -->
<script src="../../dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="../../dist/js/demo.js"></script>
</body>
</html>

</asp:Content>
