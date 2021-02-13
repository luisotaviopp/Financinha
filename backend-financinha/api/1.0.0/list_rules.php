<?php
	require_once 'connection.php';

    $token = $_POST['post_token'];

	$sql = "SELECT user.name AS created_by, rule.name, rule.description, rule.value FROM token
            INNER JOIN rule
            ON token.user_id = rule.created_by
            LEFT JOIN user
            ON user.id = token.user_id
            WHERE token.token = '$token'";

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