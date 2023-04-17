<?php include("db.php")?>
<?php

session_start();
$username = $_POST['usuario'];
$password = $_POST['password'];
$ci = $_POST['ci'];
$role = 'Invitado';

// Hash de la contraseña
$password_hash = password_hash($password, PASSWORD_DEFAULT);

// Query para insertar los datos en la tabla 'usuario'
$sql = "INSERT INTO usuario (CI, Usuario, Password, Created_at, role) VALUES ('$ci', '$username', '$password_hash', current_timestamp(), '$role')";

// Ejecuta el query
if ($conn->query($sql) === TRUE) {
    header('Location: index.php');
    exit;
} else {
    echo "Error al crear el registro: " . $conn->error;
}

// Cierra la conexión a la base de datos
$conn->close();

?>