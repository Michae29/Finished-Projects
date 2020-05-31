
<?php
    $dsn = 'mysql:host=localhost;dbname=362_proj';
    $username = 'root';
    $password = '';

    try {
        $db = new PDO($dsn, $username, $password);
    } catch (PDOException $e) {
        $error_message = $e->getMessage();
		echo $error_message;
        include('DB_error.php');
        exit();
    }
?>