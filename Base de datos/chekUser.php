<?php
    //Datos de conexión a la base de datos
    $servername = "localhost";
    $user = "id20458499_root";
    $pass = "yFyp6GPB84\}Df3M";
    $dbname = "id20458499_masksupdb";
    
    $username = $_POST["username"];
    $password = $_POST["password"];
    $passwordHash = hash('sha256', $password);;
    
    //Obtener los datos enviados desde Unity
    if(isset($_POST["username"]) && isset($_POST["password"])){
    
        //Conectar a la base de datos
        $conn = mysqli_connect($servername, $user, $pass, $dbname);
    
        //Verificar si la conexión fue exitosa
        if(!$conn){
            die("Error al conectarse a la base de datos: " . mysqli_connect_error());
        }
    
        //Consultar la tabla de usuarios para verificar si el usuario existe
        $query = "SELECT * FROM user WHERE username='".$username."' AND password='".$passwordHash."'";
        $result = mysqli_query($conn, $query);
    
        //Verificar si se encontró un registro en la tabla de usuarios
        if(mysqli_num_rows($result) > 0){
            //El usuario existe
            echo "Iniciando sesión";
        }else{
            //El usuario no existe
            echo "El nombre de jugador o la contraseña son incorrectos, por favor vuelve a intentarlo";
        }
    
        //Cerrar la conexión a la base de datos
        mysqli_close($conn);
        
    }
    else{
        echo "Error: los campos username y password son requeridos";
    }
?>