<?php
$con=mysqli_connect("db.inf.uct.cl","vquiroz","vquiroz8656","vquiroz");


$consult= "SELECT * FROM users";
$resultado = mysqli_query($con,$consult);
 while ($data = mysqli_fetch_array($resultado)) 
 {
 
 
 }
?>