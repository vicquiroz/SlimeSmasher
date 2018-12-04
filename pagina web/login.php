<?php 
$username = "";
$password    = "";
$db = mysqli_connect("db.inf.uct.cl","vquiroz","vquiroz8656","vquiroz")
or die	( "fallo de coneccion a mysql" . mysqli_connect_error());
	$vuelta = "<a href=\'login.html'\>volver</a>";
  $username = $_POST['username'];
  $password = $_POST['password']; 
  $password = md5($password);
  $query = "SELECT * FROM users WHERE username='$username' AND password='$password'";
  $results = mysqli_query($db, $query);
  if (mysqli_num_rows($results) == 1) {
  	   header("location: juego.html");
         }
  else {
  		die("Combinacion de correo y contraseña incorreta" . $vuelta );
  	}
  ?>
