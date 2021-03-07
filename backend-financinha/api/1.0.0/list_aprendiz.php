<?php
	require_once 'connection.php';

	$token = $_POST['post_token'];

	$sql = "SELECT 	r.name AS resp, 
					a.name AS apr, 
					a.id AS id_apr, 
					a.level AS level_apr
			FROM token
			INNER JOIN user r
			ON token.user_id = r.id
			JOIN user a 
			ON a.id_responsible = r.id
			WHERE token.token =  '$token'";

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