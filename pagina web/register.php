<?php
$username = "";
$email_1    = "";
$password_1    = "";
$db = mysqli_connect("db.inf.uct.cl","vquiroz","vquiroz8656","vquiroz")
    
    or die	( "fallo de coneccion a mysql" . mysqli_connect_error());
    
$username = $_POST["username"];
$email_1=$_POST["email_1"];
$email_2=$_POST["email_2"];
$password_1=$_POST["password_1"];
$password_2=$_POST["password_2"];
$vuelta="<a href=\"http://pillan.inf.uct.cl/~vquiroz/nuevo%20intento/\">volver</a>"; 
$consulta_usuario= "SELECT* FROM users WHERE username='$username' OR email='$email_1' LIMIT 1 ";
$result= mysqli_query($db, $consulta_usuario);
$usuario= mysqli_fetch_assoc($result);


if($username == ""|| $email_1==""|| $email_2==""|| $password_1==""|| $password_2==""){
        die("faltan datos " . $vuelta) ;
      }
else{
        if($email_1!=$email_2 ){
        die("los correos no coinciden " . $vuelta);
      }
        if($password_1!=$password_2 ){
        die("las contraseñas no coinciden " . $vuelta);
      } 
        if($usuario)
        {
        	if($usuario['username'] == $username)
        	{
        		die("nombre de usuario en uso " . $vuelta );
        	}
        	if($usuario['email'] == $email_1)
        	{
        		die("correo en uso " . $vuelta );
        	}
        }
    }       

$password = md5($password_1);//encrypt the password before saving in the database
  	$query = "INSERT INTO users (username, email, password)
     VALUES('$username','$email_1', '$password')";
     mysqli_query($db, $query);
     header("location: juego.html");

?>