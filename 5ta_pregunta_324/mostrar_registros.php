<?php
	$con="select * from estudiante";
	$result = $conexion->query($con);
?>

<table class="table">
	<tr>
		<th>Usuario</th>
		<th>Nombre</th>
		<th>Apellido_Pat</th>
		<th>Apellido_Mat</th>
		<th>Semestre</th>
		<th>Locacion</th>
		<th>Genero</th>
		<th>Ocupacion</th>
		<th>Notas</th>
	</tr>
	<?php
		while ($dato = $result->fetch(PDO::FETCH_ASSOC)) 
		{
			if ($dato['ocupacion'] != "docente") {
				echo'<tr>
					<td>'.$dato['usuario'].'</td>
					<td>'.$dato['nombre'].'</td>
					<td>'.$dato['ap_paterno'].'</td>
					<td>'.$dato['ap_materno'].'</td>
					<td>'.$dato['semestre'].'</td>
					<td>'.$dato['locacion'].'</td>
					<td>'.$dato['genero'].'</td>
					<td>'.$dato['ocupacion'].'</td>
					<td>'.$dato['nota'].'</td>
				</tr>';
			}
		}

	?>
</table>


