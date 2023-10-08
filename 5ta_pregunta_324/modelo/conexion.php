<?php
$servidor="localhost";
$baseDatos="midb_agostopa";
$usuario="root";
$contrasena="";

// sirve para cotejar la conexion
try{
    //$conexion=msqli_connect($servidor,$usuario,$contrasena,$baseDatos);
    $conexion=new PDO("mysql:host=$servidor;dbname=$baseDatos", $usuario, $contrasena);
    //echo "Conexión realizada midb_agostopa";
    // se usa en caso de que se cometa algún error
}catch(Exception $error){
    echo $error ->getMessage();
}

?>