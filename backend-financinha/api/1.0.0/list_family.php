<?php
	require_once 'connection.php';

	$token = $_POST['post_token'];

	$sql = "SELECT  user.name as name,
			relation_type.relation as relation
			FROM token
			INNER JOIN user
			ON token.user_id = user.id
			INNER join relation
			on (user.id = relation.user_b)
			LEFT JOIN relation_type
			on relation_type.id = relation.relation_type
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