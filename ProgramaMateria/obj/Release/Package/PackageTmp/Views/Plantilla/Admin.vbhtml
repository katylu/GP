﻿<!DOCTYPE html>
<html lang="es-py">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>Gestion de Actas de Notas - UAA</title>

    <!-- Bootstrap core CSS-->
    <link href="~/scripts/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Custom fonts for this template-->
    <link href="~/scripts/vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />

    <!-- Page level plugin CSS-->

    <link href="~/scripts/vendor/datatables/dataTables.bootstrap4.css" rel="stylesheet" />
    <!-- Custom styles for this template-->
    <link href="~/scripts/css/sb-admin.css" rel="stylesheet" />

</head>
<body class="fixed-nav sticky-footer bg-dark" id="page-top">
    <!-- Navigation-->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top" id="mainNav">
        <a class="navbar-brand" href="/Home">Gestion de Actas de Notas</a>
        <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarResponsive">
			<ul class="navbar-nav navbar-sidenav" id="exampleAccordion">



				<li class="nav-item" data-toggle="tooltip" data-placement="right" title="ABM's">
					<a class="nav-link nav-link-collapse collapsed" data-toggle="collapse" href="#collapseComponents" data-parent="#exampleAccordion">
						<i class="fa fa-fw fa-wrench"></i>
						<span class="nav-link-text">Mantenimiento</span>
					</a>
					<ul class="sidenav-second-level collapse" id="collapseComponents">
						<li>
							<a href="/Facultad">Facultad</a>
						</li>
						<li>
							<a href="/Carrera">Carrera</a>
						</li>
						<li>
							<a href="/Alumno">Alumno</a>
						</li>
						<li>
							<a href="/Profesor">Profesor</a>
						</li>
						<li>
							<a href="/Materia">Materia</a>
						</li>
						<li>
							<a href="/Curso">Curso</a>
						</li>

					</ul>
				</li>

				<!--esto es un menu anidado-->
				<!--<li class="nav-item" data-toggle="tooltip" data-placement="right" title="ABM's">
			<a class="nav-link nav-link-collapse collapsed" data-toggle="collapse" href="#collapseComponents2" data-parent="#exampleAccordion">
				<i class="fa fa-fw fa-address-book"></i>
				<span class="nav-link-text">Administración</span>
			</a>
			<ul class="sidenav-second-level collapse" id="collapseComponents2">
				<li>
					<a href="/Usuario">Usuarios</a>
				</li>
			</ul>
		</li>-->

			</ul>


			<ul class="navbar-nav sidenav-toggler">
				<li class="nav-item">
					<a class="nav-link text-center" id="sidenavToggler">
						<i class="fa fa-fw fa-angle-left"></i>
					</a>
				</li>
			</ul>
			<ul class="navbar-nav ml-auto">
				<li class="nav-item dropdown">
					<a class="nav-link dropdown-toggle mr-lg-2" id="messagesDropdown" href="#" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
						<i class="fa fa-fw fa-envelope"></i>
						<span class="d-lg-none">
							Messages
							<span class="badge badge-pill badge-primary">12 New</span>
						</span>
						<span class="indicator text-primary d-none d-lg-block">
							<i class="fa fa-fw fa-circle"></i>
						</span>
					</a>
					<div class="dropdown-menu" aria-labelledby="messagesDropdown">
						<h6 class="dropdown-header">New Messages:</h6>
						<div class="dropdown-divider"></div>
						<a class="dropdown-item" href="#">
							<strong>David Miller</strong>
							<span class="small float-right text-muted">11:21 AM</span>
							<div class="dropdown-message small">Hey there! This new version of SB Admin is pretty awesome! These messages clip off when they reach the end of the box so they don't overflow over to the sides!</div>
						</a>
						<div class="dropdown-divider"></div>
						<a class="dropdown-item" href="#">
							<strong>Jane Smith</strong>
							<span class="small float-right text-muted">11:21 AM</span>
							<div class="dropdown-message small">I was wondering if you could meet for an appointment at 3:00 instead of 4:00. Thanks!</div>
						</a>
						<div class="dropdown-divider"></div>
						<a class="dropdown-item" href="#">
							<strong>John Doe</strong>
							<span class="small float-right text-muted">11:21 AM</span>
							<div class="dropdown-message small">I've sent the final files over to you for review. When you're able to sign off of them let me know and we can discuss distribution.</div>
						</a>
						<div class="dropdown-divider"></div>
						<a class="dropdown-item small" href="#">View all messages</a>
					</div>
				</li>
				<li class="nav-item dropdown">
					<a class="nav-link dropdown-toggle mr-lg-2" id="alertsDropdown" href="#" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
						<i class="fa fa-fw fa-bell"></i>
						<span class="d-lg-none">
							Alerts
							<span class="badge badge-pill badge-warning">6 New</span>
						</span>
						<span class="indicator text-warning d-none d-lg-block">
							<i class="fa fa-fw fa-circle"></i>
						</span>
					</a>
					<div class="dropdown-menu" aria-labelledby="alertsDropdown">
						<h6 class="dropdown-header">New Alerts:</h6>
						<div class="dropdown-divider"></div>
						<a class="dropdown-item" href="#">
							<span class="text-success">
								<strong>
									<i class="fa fa-long-arrow-up fa-fw"></i>Status Update
								</strong>
							</span>
							<span class="small float-right text-muted">11:21 AM</span>
							<div class="dropdown-message small">This is an automated server response message. All systems are online.</div>
						</a>
						<div class="dropdown-divider"></div>
						<a class="dropdown-item" href="#">
							<span class="text-danger">
								<strong>
									<i class="fa fa-long-arrow-down fa-fw"></i>Status Update
								</strong>
							</span>
							<span class="small float-right text-muted">11:21 AM</span>
							<div class="dropdown-message small">This is an automated server response message. All systems are online.</div>
						</a>
						<div class="dropdown-divider"></div>
						<a class="dropdown-item" href="#">
							<span class="text-success">
								<strong>
									<i class="fa fa-long-arrow-up fa-fw"></i>Status Update
								</strong>
							</span>
							<span class="small float-right text-muted">11:21 AM</span>
							<div class="dropdown-message small">This is an automated server response message. All systems are online.</div>
						</a>
						<div class="dropdown-divider"></div>
						<a class="dropdown-item small" href="#">View all alerts</a>
					</div>
				</li>
				<li class="nav-item">
					<form class="form-inline my-2 my-lg-0 mr-lg-2">
						<div class="input-group">
							<input class="form-control" type="text" placeholder="Search for...">
							<span class="input-group-append">
								<button class="btn btn-primary" type="button">
									<i class="fa fa-search"></i>
								</button>
							</span>
						</div>
					</form>
				</li>
				<li class="nav-item">
					<a class="nav-link" data-toggle="modal" data-target="#exampleModal">
						<i class="fa fa-fw fa-sign-out"></i>Logout
					</a>
				</li>
			</ul>
		</div>
		@*<table>
			<tbody>
				@For Each row In ViewData("login")
			@<tr>
				<td>@row("nombre_usuario")</td>
			</tr>
				Next
			</tbody>
		</table>*@

	</nav>
		<div class="content-wrapper">
		<div class="container-fluid">
		</div>



		<!-- /.container-fluid-->
				<!-- /.content-wrapper-->
				<footer class="sticky-footer">
					<div class="container">
						<div class="text-center">
							<small>UNIVERSIDAD AUTONOMA DE ASUNCION</small>
						</div>
					</div>
				</footer>
				<!-- Scroll to Top Button-->
				<a class="scroll-to-top rounded" href="#page-top">
					<i class="fa fa-angle-up"></i>
				</a>
				<!-- Logout Modal-->
				<div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
					<div class="modal-dialog" role="document">
						<div class="modal-content">
							<div class="modal-header">
								<h5 class="modal-title" id="exampleModalLabel">Ready to Leave?</h5>
								<button class="close" type="button" data-dismiss="modal" aria-label="Close">
									<span aria-hidden="true">×</span>
								</button>
							</div>
							<div class="modal-body">Select "Logout" below if you are ready to end your current session.</div>
							<div class="modal-footer">
								<button class="btn btn-secondary" type="button" data-dismiss="modal">Cancel</button>
								<a class="btn btn-primary" href="login.html">Logout</a>
							</div>
						</div>
					</div>
				</div>

				<!-- /.box-header -->
				<div class="box-body">
					<div class="row">
						<div class="col-md-12">
							<!--Contenido-->
							<div>
								@RenderBody
							</div>
							<!--Fin Contenido-->
						</div>
					</div>

				</div>

				<!-- Bootstrap core JavaScript-->
				<script src="~/scripts/vendor/jquery/jquery.min.js"></script>
				<script src="~/scripts/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
				<!--<script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>-->
				<!-- Core plugin JavaScript-->

				<script src="~/scripts/vendor/jquery-easing/jquery.easing.min.js"></script>
				<!-- Page level plugin JavaScript-->

				<script src="~/scripts/vendor/chart.js/Chart.min.js"></script>
				<script src="~/scripts/vendor/datatables/jquery.dataTables.js"></script>
				<script src="~/scripts/vendor/datatables/dataTables.bootstrap4.js"></script>
				<!-- Custom scripts for all pages-->


				<script src="~/scripts/js/sb-admin.min.js"></script>
				<!-- Custom scripts for this page-->

				<script src="~/scripts/js/sb-admin-datatables.min.js"></script>
				<script src="~/scripts/js/sb-admin-charts.min.js"></script>
</div>
</body>
</html>
