<?php
	require_once 'connection.php';

	$token = $_POST['post_token'];

	$sql = "SELECT  value, type, reason, event.created_at
			FROM token
			INNER JOIN event
			ON token.user_id = event.user_id
			WHERE token = '$token'";

	$result = $conn->query($sql);

	if ($result->num_rows > 0)
	{
		$emparray = array();

		while($row = mysqli_fetch_assoc($result))
		{
			$emparray[] = $row;
		}

		echo json_encode($emparray);
	} 
	else 
	{
		echo "Nenhuma solicitação encontrada no momento.";
	}

	$conn->close();
?>