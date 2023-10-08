<?php
$con1="SELECT locacion, CAST(ROUND(AVG(nota),2) AS DEC(10,2)) media_notas 
FROM estudiante GROUP BY locacion";
	$result1=$conexion->query($con1);
?>
<table class="table">
	<tr>
		<th>Locacion</th>
		<th>Media de la Nota</th>
	</tr>
		<?php
			while($dato1 = $result1->fetch(PDO::FETCH_ASSOC)){
				echo'<tr>
						<td>'.$dato1['locacion'].'</td>
						<td>'.$dato1['media_notas'].'</td>
					</tr>';
			}
		?>
</table>