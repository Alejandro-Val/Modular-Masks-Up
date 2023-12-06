<?php
    //Datos de conexión a la base de datos
    $servername = "localhost";
    $user = "id20458499_root";
    $pass = "yFyp6GPB84\}Df3M";
    $dbname = "id20458499_masksupdb";
    
    $username = $_POST["username"];
    $password = $_POST["password"];
    $passwordHash = hash('sha256', $password);;
    $age = $_POST["age"];
    
    //Obtener los datos enviados desde Unity
    if(isset($_POST["username"]) && isset($_POST["password"]) && isset($_POST["age"])){
    
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
            echo "El nombre de usuario ya está en uso";
        }
        else{
            // Si el nombre de usuario no está en uso, insertar los datos del usuario en la tabla de usuarios
            $sql = "INSERT INTO user (username, password, age) VALUES ('".$username."', '".$passwordHash."', '".$age."')";
            if (mysqli_query($conn, $sql)) {
                $id_usuario = mysqli_insert_id($conn);
                $sql2 = "INSERT INTO achievements (id_user) VALUES ('".$id_usuario."')";
                if (mysqli_query($conn, $sql2)) {
                    echo "Cuenta creada";
                } else {
                    echo "Hubo un error, vuelve a intentarlo";
                }
            } 
            else {
                echo "Hubo un error, vuelve a intentarlo";
            }
        }
    
        //Cerrar la conexión a la base de datos
        mysqli_close($conn);
        
    }
    else{
        echo "Error: los campos username y password son requeridos";
    }

?>
