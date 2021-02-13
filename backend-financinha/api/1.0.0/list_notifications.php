<?php
	require_once 'connection.php';

	$token = $_POST['post_token'];

	$sql = "SELECT user.name as de, relation_type.relation as relacao, notification.id
			FROM token
			INNER JOIN notification
			ON token.user_id = notification.to_user
			INNER JOIN user
			ON notification.from_user = user.id
			INNER JOIN relation_type
			on relation_type.id = notification.relation_type
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
		echo "Nenhuma regra cadastrada.";
	}

	$conn->close();
?>