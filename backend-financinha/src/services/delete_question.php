<?php
		require_once '../../api/1.0.0/connection.php';

    $id = $_GET['id'];

	$sql = "UPDATE question SET is_active = false WHERE id = $id";
    
	if ($conn->query($sql) === TRUE)
    {
        echo "Questão deletada.";
        header('location: ../../table_questions.php');
    }
    else
    {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }
    
    $conn->close();
?>

