<?php
	session_start();
	if (!empty($_POST['btningresar'])) {
		if (!empty($_POST['usuario']) and !empty($_POST['password'])) {
			$usuario=$_POST['usuario'];
			$password=$_POST['password'];
			$consulta="select * from estudiante where usuario='$usuario' and password = '$password'";
			$resultado = $conexion->query($consulta);

			if ($obj = $resultado->fetch(PDO::FETCH_ASSOC)) {
				if ($obj['ocupacion'] == "estudiante") {
					$_SESSION['nom']=$obj['nombre'];
					header("location: inicio2.php");	
				}
				elseif ($obj['ocupacion'] == "docente") {
					$_SESSION['nom']=$obj['nombre'];
					header("location: inicio.php");
				}
			} 
			else {
				echo "<div class='alert alert-danger'> Acceso Denegado </div>";
			}
		} 
	}
?>