<!DOCTYPE html>
<html>
<head>
	
	<title>Jugadores Registrados</title>
	<meta charset="utf-8">
<script>
    var objeto = null
	if (window.XMLHttpRequest) objeto = new XMLHttpRequest()
	else if (window.ActiveXObject) objeto = new ActiveXObject("Microsoft.XMLHTTP")
</script>
</head>
<body>
	<h1>Jugadores Registrados</h1>
	<div id="miCapa">
	<table border=1>
		<tr> <td>username</td>
			 <td>email</td>
			 <td></td>
		</tr>
<?php
include("conex.inc");
$consulta = "SELECT * FROM users";
$respuesta = mysqli_query($db, $consulta);

while($fila=mysqli_fetch_object($respuesta)){
	echo "<tr> <td> $fila->username </td>
			   <td> $fila->email</td>
		 </tr>";
}
?>
</table>
</div>
</body>
</html>